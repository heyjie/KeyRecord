using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace GlobalHook.Common
{
    class CSKeyValue
    {
        //分隔符
        private char f_Separator = ';';
        public char F_Separator
        {
            get { return f_Separator; }
            set { f_Separator = value; }
        }

        //赋值号
        private char f_Assign = '=';
        public char F_Assign
        {
            get { return f_Assign; }
            set { f_Assign = value; }
        }
        //值域号
        private char f_Value = '"';
        public char F_Value
        {
            get { return f_Value; }
            set { f_Value = value; }
        }

        private Dictionary<string, string> dictItems = new Dictionary<string, string>();
        public Dictionary<string, string> DictItems
        {
            get { return dictItems; }
            set { dictItems = value; }
        }

        public CSKeyValue() { }

        public CSKeyValue(string Context)
        {
            CSInitial(Context);
        }

        public void CSInitial(string Context)
        {
            //如果为空，只做变量初始化
            if (string.IsNullOrEmpty(Context))
            {
                DictItems.Clear();
                return;
            }
            string[] str_G1 = Context.Split(new char[] { f_Separator }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string str_Sep in str_G1)
            {
                //滤除空节点
                if (string.IsNullOrEmpty(str_Sep))
                {
                    continue;
                }
                int i_Assign = str_Sep.IndexOf(F_Assign);
                if (i_Assign < 0) { continue; }
                string str_Key = str_Sep.Substring(0, i_Assign).Trim();
                string str_Value = str_Sep.Substring(i_Assign + 1).Trim();
                //整理Value值，取消值域号
                int i_Value_First = str_Value.IndexOf(F_Value);
                int i_Value_Last = str_Value.LastIndexOf(F_Value);
                if ((i_Value_First > -1) && (i_Value_Last > i_Value_First))
                {
                    str_Value = str_Value.Substring(i_Value_First + 1, i_Value_Last - i_Value_First - 1);
                }

                CSAdd(str_Key, str_Value);
            }
        }

        public CSKeyValue(DataRow DR)
        {
            if (DR == null)
            {
                return;
            }
            foreach (DataColumn dc in DR.Table.Columns)
            {
                CSAdd(dc.ColumnName, DR[dc.ColumnName].ToString());
            }
        }

        /// <summary> 向字典缓存追加一对键值对
        /// 追加方法：如果不存的Key，则Add；否则，Upadte
        /// </summary>
        /// <param name="str_Key"></param>
        /// <param name="str_Value"></param>
        /// <returns>
        /// 1：代表新增1个
        /// 0：代表更新1个
        /// </returns>
        public int CSAdd(string str_Key, string str_Value)
        {
            if (string.IsNullOrEmpty(str_Key))
            {
                return 0;
            }
            if ((str_Value != null) && (str_Value.Contains(Convert.ToString(this.F_Separator))))
            {
                throw new Exception(string.Format("数据中不能包含分隔符({0})！", this.F_Separator));
            }
            if (DictItems.ContainsKey(str_Key))
            {
                DictItems[str_Key] = str_Value;
                return 0;
            }
            else
            {
                if (string.IsNullOrEmpty(str_Value))
                {
                    DictItems.Add(str_Key, "");
                }
                else
                {
                    DictItems.Add(str_Key, str_Value);
                }
                return 1;
            }
        }
        public int CSAdd(string str_Value)
        {
            int i = DictItems.Count;
            if (DictItems.ContainsKey(i.ToString()))
            {
                Exception ex = new Exception(string.Format("已存在相同的Key值({0})!", i));
                throw ex;
            }
            return CSAdd(i.ToString(), str_Value);
        }
        public int CSAdd(CSKeyValue CSKV)
        {
            if ((CSKV == null) || (CSKV.DictItems.Count < 1))
            {
                return -1;
            }
            int i = 0;
            foreach (KeyValuePair<string, string> kvp in CSKV.DictItems)
            {
                this.CSAdd(kvp.Key, kvp.Value);
                i++;
            }
            return i;
        }

        /// <summary> 向字典缓存移除一对键值对
        /// 
        /// </summary>
        /// <param name="str_Key"></param>
        /// <returns>
        /// -1：代表参数错误；
        /// 0：代表未有任何变化；
        /// 1：代表正常操作成功；
        /// </returns>
        public int CSRemove(string str_Key)
        {
            if (string.IsNullOrEmpty(str_Key))
            {
                return -1;
            }
            if (DictItems.Remove(str_Key))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="str_Key"></param>
        /// <returns></returns>
        public string CSGetValue(string str_Key)
        {
            if (string.IsNullOrEmpty(str_Key))
            {
                return string.Empty;
            }
            if (DictItems.ContainsKey(str_Key))
            {
                return DictItems[str_Key].Replace(F_Value, ' ');
            }
            else
            {
                return string.Empty;
            }
        }

        /// <summary> 
        /// 给字典列表对应节点赋值
        /// </summary>
        /// <param name="CSKey">节点关键字</param>
        /// <param name="CSValue">节点值</param>
        /// <returns>
        /// -1：异常；
        /// 1：成功；
        /// 0：没有操作
        /// </returns>
        public int CSSetValue(string CSKey, string CSValue)
        {
            if (string.IsNullOrEmpty(CSKey))
            {
                return -1;
            }
            if (DictItems.ContainsKey(CSKey))
            {
                DictItems[CSKey] = CSValue;
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public string ToItemSerializeString(string CSKey)
        {
            if (DictItems.ContainsKey(CSKey))
            {
                return string.Format("{0} {1} {2}{3}{2}", CSKey, f_Assign, f_Value, CSGetValue(CSKey));
            }
            else
            {
                return string.Empty;
            }
        }

        /// <summary> 将字典缓存序列化
        /// 
        /// </summary>
        /// <returns></returns>
        public string ToSerializedString()
        {
            if (DictItems.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                //需要重新开辟DictItems的副本，以免发生DictItems的并发变化
                Dictionary<string, string> tmpDict = new Dictionary<string, string>(DictItems);
                foreach (KeyValuePair<string, string> m in tmpDict)
                {
                    sb.Append(string.Format("{0} {1} {2}{3}{2} {4}", m.Key, f_Assign, f_Value, m.Value, f_Separator));
                }
                if (sb.ToString().EndsWith(f_Separator.ToString()))
                {
                    int i_Length = sb.ToString().Length;
                    return sb.ToString().Substring(0, i_Length - 1);
                }
                else
                {
                    return sb.ToString();
                }
            }
            else
            {
                return string.Empty;
            }
        }

        /// <summary> 转换成数据列数组
        /// 为了方便进行对象与数据表之间的转换，特提供本功能。
        /// </summary>
        /// <returns></returns>
        public virtual DataColumn[] ToTableColumns()
        {
            if (DictItems.Count > 0)
            {
                DataColumn[] dcg = new DataColumn[DictItems.Count];
                int i = 0;
                foreach (KeyValuePair<string, string> kvp in DictItems)
                {
                    DataColumn dc = new DataColumn(kvp.Key, typeof(string));
                    dcg[i] = dc;
                    i++;
                }
                return dcg;
            }
            else
            {
                return null;
            }
        }

    }
}
