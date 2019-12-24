using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace GlobalHook.DataBase
{
    public class DBUtils
    {
        public static string getInsertSqlForEntity(object obj, string key = "")
        {
            FieldInfo[] fields = obj.GetType().GetFields();
            StringBuilder stringBuilder = new StringBuilder("insert into " + obj.GetType().Name + "(");
            StringBuilder stringBuilder2 = new StringBuilder(" values(");
            foreach (FieldInfo fieldInfo in fields)
            {
                if (!fieldInfo.Name.Equals(key))
                {
                    stringBuilder.Append(fieldInfo.Name + ",");
                    object value = fieldInfo.GetValue(obj);
                    if (fieldInfo.FieldType.Name.Equals("String"))
                    {
                        stringBuilder2.Append("'");
                        stringBuilder2.Append(value.ToString());
                        stringBuilder2.Append("',");
                    }
                    else
                    {
                        stringBuilder2.Append(value.ToString());
                        stringBuilder2.Append(",");
                    }
                }
            }
            stringBuilder.Append(")");
            stringBuilder2.Append(")");
            string text = stringBuilder.ToString() + stringBuilder2.ToString();
            return text.Replace(",)", ")");
        }

        public static string getUpdateSqlForEntity(object obj, string[] condition)
        {
            FieldInfo[] fields = obj.GetType().GetFields();
            StringBuilder stringBuilder = new StringBuilder("update " + obj.GetType().Name + " set ");
            StringBuilder stringBuilder2 = new StringBuilder(" where 1 = 1 ");
            foreach (FieldInfo fieldInfo in fields)
            {
                bool flag = false;
                foreach (string text in condition)
                {
                    if (text.Equals(fieldInfo.Name))
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    stringBuilder2.Append(" and " + fieldInfo.Name + " = ");
                    object value = fieldInfo.GetValue(obj);
                    if (fieldInfo.FieldType.Name.Equals("String"))
                    {
                        stringBuilder2.Append("'");
                        stringBuilder2.Append(value.ToString());
                        stringBuilder2.Append("'");
                    }
                    else
                    {
                        stringBuilder2.Append(value.ToString());
                    }
                }
                else
                {
                    stringBuilder.Append(fieldInfo.Name + " = ");
                    object value = fieldInfo.GetValue(obj);
                    if (fieldInfo.FieldType.Name.Equals("String"))
                    {
                        stringBuilder.Append("'");
                        stringBuilder.Append(value.ToString());
                        stringBuilder.Append("',");
                    }
                    else
                    {
                        stringBuilder.Append(value.ToString());
                        stringBuilder.Append(",");
                    }
                }
            }
            string text2 = stringBuilder.ToString() + stringBuilder2.ToString();
            return text2.Replace(", where", " where");
        }
    }
}
