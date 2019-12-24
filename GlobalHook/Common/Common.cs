using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace GlobalHook.Common
{
    public static class Common
    {
        //获取活动窗口句柄
        [DllImport("User32.DLL")]
        public static extern IntPtr GetForegroundWindow();

        //获取窗口标题
        [DllImport("user32", SetLastError = true)]
        public static extern int GetWindowText(
        IntPtr hWnd,//窗口句柄 
        StringBuilder lpString,//标题 
        int nMaxCount //最大值 
        );

        //根据窗口句柄获取ID
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern int GetWindowThreadProcessId(IntPtr hwnd, out int ID);//获取线程id

        //获取类的名字 
        [DllImport("user32.dll")]
        public static extern int GetClassName(
            IntPtr hWnd,//句柄 
            StringBuilder lpString, //类名 
            int nMaxCount //最大值 
            );

        // 根据类名和窗口名获取进程句柄
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        
        // 通过进程句柄给窗口发送消息
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        //根据坐标获取窗口句柄 
        [DllImport("user32")]
        public static extern IntPtr WindowFromPoint(
        Point Point  //坐标 
        );
        public const int MAX_PATH = 260;
        public const int PROCESS_ALL_ACCESS = 0x000F0000 | 0x00100000 | 0xFFF;

        //打开一个已存在的进程对象，并返回进程的句柄
        //fdwAccess。
        [DllImport("Kernel32.dll")]
        public extern static IntPtr OpenProcess(int fdwAccess, //指定对进程对象的访问。对于支持安全检查的操作系统，将针对目标进程的任何安全描述符检查此访问
            int fInherit, //指定返回的句柄是否可以由当前进程创建的新进程继承。如果为真，则该句柄是可继承的
            int IDProcess //指定要打开的进程的进程标识符
            );

        //强制结束进程
        [DllImport("shell32.dll")]
        public extern static bool TerminateProcess(IntPtr hProcess, int uExitCode);

        //获取当前进程已加载模块的文件的完整路径，该模块必须由当前进程加载
        //如果想要获取另一个已加载模块的文件路径，可以使用GetModuleFileNameEx函数
        [DllImport("shell32.dll", EntryPoint = "GetModuleFileName")]
        public static extern uint GetModuleFileName(IntPtr hModule, //应用程序或DLL实例句柄,NULL则为获取当前程序可执行文件路径名
            [Out] StringBuilder lpszFileName, //接收路径的字符串缓冲区
            int nSize //接收路径的字符缓冲区的大小
            );

        [System.Runtime.InteropServices.DllImport("shell32.dll")]
        public static extern int ExtractIconEx(string lpszFile, int niconIndex, IntPtr[] phiconLarge, IntPtr[] phiconSmall, int nIcons);

        //hProcess是目标进程的句柄、hModule是目标模块的句柄(当此参数为NULL时函数返回的是进程可执行文件的路径)、lpFilename是存放路径的字符串缓冲区、nSize表示缓冲区的大小。函数调用失败将返回0。
        //注：进程的句柄须有PROCESS_QUERY_INFORMATION和PROCESS_VM_READ权限。
        [DllImport("psapi.dll")]
        public static extern uint GetModuleFileNameEx(IntPtr hProcess, IntPtr hModule, [Out] StringBuilder lpBaseName, [In] [MarshalAs(UnmanagedType.U4)] int nSize);

        [DllImport("Kernel32.dll")]
        public extern static bool CloseHandle(IntPtr hObject);

        /// <summary>
        /// 打开路径并定位文件...对于@"h:\Bleacher Report - Hardaway with the safe call ??.mp4"这样的，explorer.exe /select,d:xxx不认，用API整它
        /// </summary>
        /// <param name="filePath">文件绝对路径</param>
        [DllImport("shell32.dll", ExactSpelling = true)]
        public static extern void ILFree(IntPtr pidlList);

        [DllImport("shell32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern IntPtr ILCreateFromPathW(string pszPath);

        [DllImport("shell32.dll", ExactSpelling = true)]
        public static extern int SHOpenFolderAndSelectItems(IntPtr pidlList, uint cild, IntPtr children, uint dwFlags);
    }
}
