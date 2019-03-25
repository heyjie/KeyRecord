//KeyMouseModel
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GlobalHook
{
    public class KeyMouseModel
    {
        /// <summary>
        /// 操作的设备名称
        /// </summary>
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// 按下了哪个键
        /// </summary>
        private string keyData;
        public string KeyData
        {
            get { return keyData; }
            set { keyData = value; }
        }

        /// <summary>
        /// 当前操作x坐标
        /// </summary>
        private string locationX;
        public string LocationX
        {
            get { return locationX; }
            set { locationX = value; }
        }

        /// <summary>
        /// 当前操作y坐标
        /// </summary>
        private string locationY;
        public string LocationY
        {
            get { return locationY; }
            set { locationY = value; }
        }

        /// <summary>
        /// 当前操作窗口
        /// </summary>
        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        /// <summary>
        /// 当前操作窗口所属
        /// </summary>
        private string className;
        public string ClassName
        {
            get { return className; }
            set { className = value; }
        }

        /// <summary>
        /// 当前操作时间
        /// </summary>
        private string date;
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
    }
}
