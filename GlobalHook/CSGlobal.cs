using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using GlobalHook.Common;
using GlobalHook.Model;
using log4net;

namespace GlobalHook
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
        log4net.ILog log = log4net.LogManager.GetLogger("GlobalHook.Logging");
        private BindingList<KeyMouseModel> keyMs = new BindingList<KeyMouseModel>();

        public ILog Log { get => log; set => log = value; }
        public BindingList<KeyMouseModel> KeyMs { get => keyMs; set => keyMs = value; }

        public KeyboardHook k_hook = new KeyboardHook();
        public MouseHook m_hook = new MouseHook();

        //public HookOutputFrm hookFrm = new HookOutputFrm();
        public HookOutputFrm2 hookFrm = new HookOutputFrm2();

        
    }
}
