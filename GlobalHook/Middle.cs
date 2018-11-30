using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GlobalHook
{
    public static class Middle
    {
        public delegate void SaveMessage();
        public static event SaveMessage saveallEvent;
        public static event SaveMessage savekeyEvent;
        public static event SaveMessage savemouseEvent;
        public static void DoSaveAllMessage()
        {
            saveallEvent();
        }
        public static void DoSaveKeyMessage()
        {
            savekeyEvent();
        }
        public static void DoSaveMouseMessage()
        {
            savemouseEvent();
        }
    }
}
