using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using KeyRecord.Common;
using KeyRecord.Model;
using log4net;
using KeyRecord.UserForm;

namespace KeyRecord
{
    public sealed class CSGlobal
    {
        #region  获取自身的单例模式
        private CSGlobal()
        {

        }

        private static CSGlobal instance;
        public static CSGlobal GetInstance()
        {
            if (instance == null)
            {
                instance = new CSGlobal();
            }
            return instance;
        }
        #endregion
        log4net.ILog log = log4net.LogManager.GetLogger("KeyRecord.Logging");
        private BindingList<KeyMouseModel> keyMs = new BindingList<KeyMouseModel>();

        public ILog Log
        {
            get
            {
                return log;
            }

            set
            {
                log = value;
            }
        }

        public BindingList<KeyMouseModel> KeyMs
        {
            get
            {
                return keyMs;
            }

            set
            {
                keyMs = value;
            }
        }
        //hook
        public KeyboardHook k_hook = new KeyboardHook();
        public MouseHook m_hook = new MouseHook();

        public HookOutputFrm2 hookFrm = new HookOutputFrm2();
    }
}
