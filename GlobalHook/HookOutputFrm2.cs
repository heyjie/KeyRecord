using GlobalHook.Common;
using GlobalHook.Model;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace GlobalHook
{
    public partial class HookOutputFrm2 : MetroForm
    {
        public HookOutputFrm2()
        {
            InitializeComponent();
        }

        private void HookOutputFrm2_Load(object sender, EventArgs e)
        {
            CSGlobal.GetInstance().k_hook.KeyDown += K_hook_KeyDown;//全局按键事件
            CSGlobal.GetInstance().k_hook.KeyUp += K_hook_KeyUp;
            CSGlobal.GetInstance().k_hook.Start();//安装键盘钩子           
            CSGlobal.GetInstance().m_hook.MouseDown += M_hook_MouseDown;//全局点击事件
            CSGlobal.GetInstance().m_hook.Start();
            this.metroGrid_kmData.DataSource = CSGlobal.GetInstance().KeyMs;
        }


        private void M_hook_MouseDown(object sender, MouseEventArgs e)
        {
            if (IsDisposed) return;
            string info = string.Empty;
            string tit = string.Empty;
            Icon ico = null;
            StringBuilder className = new StringBuilder(256);
            try
            {
                int x = Cursor.Position.X;
                int y = Cursor.Position.Y;
                Point p = new Point(x, y);
                IntPtr formHandle = Common.Common.WindowFromPoint(p);//得到窗口句柄 
                StringBuilder title = new StringBuilder(256);
                Common.Common.GetWindowText(formHandle, title, title.Capacity);//得到窗口的标题 
                Common.Common.GetClassName(formHandle, className, className.Capacity);
                //获取路径
                int pId = 0;
                IntPtr pHandle = IntPtr.Zero;
                Common.Common.GetWindowThreadProcessId(formHandle, out pId);
                pHandle = Common.Common.OpenProcess(Common.Common.PROCESS_ALL_ACCESS, 0, pId);
                //System.Diagnostics.Process myProcess = System.Diagnostics.Process.GetProcessById(pId);
                StringBuilder sb = new StringBuilder(Common.Common.MAX_PATH);
                //GetModuleFileName(pHandle, sb, sb.Capacity);
                Common.Common.GetModuleFileNameEx(pHandle, IntPtr.Zero, sb, Common.Common.MAX_PATH);
                Common.Common.CloseHandle(pHandle);
                //获取图标
                IntPtr[] largeIcons, smallIcons;
                int IconCount = Common.Common.ExtractIconEx(sb.ToString(), -1, null, null, 0);
                largeIcons = new IntPtr[IconCount];
                smallIcons = new IntPtr[IconCount];
                //GC.KeepAlive(Common.Common.ExtractIconEx(sb.ToString(), 0, largeIcons, smallIcons, IconCount));
                Common.Common.ExtractIconEx(sb.ToString(), 0, largeIcons, smallIcons, IconCount);
                IntPtr icon = new IntPtr(0);
                try
                {
                    icon = largeIcons[0];
                    ico = Icon.FromHandle(icon);
                }
                catch (Exception ex)
                {
                    Console.Out.WriteLine(ex.Message);
                }
                tit = title.ToString();
                info = sb.ToString();
            }
            catch (Exception ex)
            {
                tit = ex.Message;
                info = ex.Message;
            }
            KeyMouseModel km = new KeyMouseModel();
            km.CategoryIcon = (Bitmap)imageList.Images["mousec.png"];
            km.DeviceName = "鼠标";
            km.KeyType = e.ToString();
            km.KeyData = e.Button.ToString();
            km.LocationX = e.X;
            km.LocationY = e.Y;
            km.Title = tit;
            km.ClassName = className.ToString();
            km.ProcessPath = info;
            km.ExecuteDate = DateTime.Now.ToString();
            km.ProgramIcon = ico == null ? (Bitmap)imageList.Images["win.ico"] : ico.ToBitmap();
            CSGlobal.GetInstance().KeyMs.Add(km);
            this.metroGrid_kmData.FirstDisplayedScrollingRowIndex = this.metroGrid_kmData.Rows.Count - 1;
            km.AddKeyMouseData();
        }

        private void K_hook_KeyUp(object sender, KeyEventArgs e)
        {
            CSGlobal.GetInstance().k_hook.KeyDown += K_hook_KeyDown;
        }

        private void K_hook_KeyDown(object sender, KeyEventArgs e)
        {
            CSGlobal.GetInstance().k_hook.KeyDown -= K_hook_KeyDown;
            //判断按下的键（Alt + A）
            if (e.KeyValue == (int)Keys.A && (int)Control.ModifierKeys == (int)Keys.Alt)
            //if (e.KeyData.ToString() == Settings.Default.lblKeyState)
            {
                //System.Windows.Forms.MessageBox.Show("按下了指定快捷键组合");
                if (this.Visible == true)
                {
                    this.Hide();
                    this.ShowInTaskbar = false;
                }
                else
                {
                    this.ShowInTaskbar = true;
                    //this.WindowState = FormWindowState.Normal;
                    this.Show();
                }
            }
            string info = string.Empty;
            string tit = string.Empty;
            Icon ico = null;
            StringBuilder className = new StringBuilder(256);
            try
            {
                IntPtr formHandle = Common.Common.GetForegroundWindow();
                StringBuilder title = new StringBuilder(256);
                Common.Common.GetWindowText(formHandle, title, title.Capacity);//得到窗口的标题 
                Common.Common.GetClassName(formHandle, className, className.Capacity);
                //获取路径
                int pId = 0;
                IntPtr pHandle = IntPtr.Zero;
                Common.Common.GetWindowThreadProcessId(formHandle, out pId);
                pHandle = Common.Common.OpenProcess(Common.Common.PROCESS_ALL_ACCESS, 0, pId);
                StringBuilder sb = new StringBuilder(Common.Common.MAX_PATH);
                //GetModuleFileName(pHandle, sb, sb.Capacity);
                Common.Common.GetModuleFileNameEx(pHandle, IntPtr.Zero, sb, Common.Common.MAX_PATH);
                Common.Common.CloseHandle(pHandle);
                //获取图标
                IntPtr[] largeIcons, smallIcons;
                int IconCount = Common.Common.ExtractIconEx(sb.ToString(), -1, null, null, 0);
                largeIcons = new IntPtr[IconCount];
                smallIcons = new IntPtr[IconCount];
                Common.Common.ExtractIconEx(sb.ToString(), 0, largeIcons, smallIcons, IconCount);
                IntPtr icon = new IntPtr(0);
                try
                {
                    icon = largeIcons[0];
                    ico = Icon.FromHandle(icon);
                }
                catch (Exception ex)
                {
                    Console.Out.WriteLine(ex.Message);
                }
                tit = title.ToString();
                info = sb.ToString();
            }
            catch (Exception ex)
            {
                tit = ex.Message;
                info = ex.Message;
            }
            KeyMouseModel km = new KeyMouseModel();
            km.CategoryIcon = (Bitmap)imageList.Images["keyboardc.png"];
            km.DeviceName = "键盘";
            km.KeyData = e.KeyData.ToString();
            km.LocationX = 0;
            km.LocationY = 0;
            km.Title = tit;
            km.ClassName = className.ToString();
            km.ProcessPath = info;
            km.ExecuteDate = DateTime.Now.ToString();
            km.ProgramIcon = ico == null ? (Bitmap)imageList.Images["win.ico"] : ico.ToBitmap();
            CSGlobal.GetInstance().KeyMs.Add(km);
            if(!this.metroGrid_kmData.Focused)
            {
                this.metroGrid_kmData.FirstDisplayedScrollingRowIndex = this.metroGrid_kmData.Rows.Count - 1;
                km.AddKeyMouseData();
            }
            
        }

        //右键打开文件夹
        private void ToolStripMenuItem_open_Click(object sender, EventArgs e)
        {
            var selectRows = metroGrid_kmData.SelectedRows;
            if (selectRows.Count == 0)
            {
                return;
            }
            string filePath = selectRows[0].Cells["ProcessPath"].Value.ToString();
            try
            {
                if (!File.Exists(filePath) && !Directory.Exists(filePath))
                    return;
                if (Directory.Exists(filePath))
                    Process.Start(@"explorer.exe", "/select,\"" + filePath + "\"");
                else
                {
                    IntPtr pidlList = Common.Common.ILCreateFromPathW(filePath);
                    if (pidlList != IntPtr.Zero)
                    {
                        try
                        {
                            Marshal.ThrowExceptionForHR(Common.Common.SHOpenFolderAndSelectItems(pidlList, 0, IntPtr.Zero, 0));
                        }
                        finally
                        {
                            Common.Common.ILFree(pidlList);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(CSGlobal.GetInstance().hookFrm, "打开文件夹失败\n" + ex.ToString(), "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var m = new Random();
            int next = m.Next(0, 13);
            metroStyleManager1.Style = (MetroColorStyle)next;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            metroStyleManager1.Theme = metroStyleManager1.Theme == MetroThemeStyle.Light ? MetroThemeStyle.Dark : MetroThemeStyle.Light;
        }
    }
}
