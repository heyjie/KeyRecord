//SetFrm.cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GlobalHook.Properties;
using Microsoft.Win32;

namespace GlobalHook
{
    public partial class SetFrm : Form
    {
        public KeyboardHook k_hook;
        public HookOutputFrm hookFrm;
        public SetFrm()
        {
            InitializeComponent();
            //Middle.SaveSet+=new Middle.SaveSetEventHandler(Middle_SaveSet);

        }
        private void SetFrm_Load(object sender, EventArgs e)
        {
            k_hook = new KeyboardHook();
            k_hook.KeyDown += new KeyEventHandler(k_hook_KeyDown);//全局按键事件
            //加载设置
            this.rad_AutoSave.Checked = Settings.Default.radAutoSaveState;
            this.rad_ManualSave.Checked = Settings.Default.radManualSaveState;
            this.tb_SavePath.Text = Settings.Default.tbSavePathState;
            this.tb_Time.Text = Settings.Default.tbTimeState;
            this.tb_FileName.Text = Settings.Default.tbName;
            this.chk_Key.Checked = Settings.Default.chkKeyState;
            this.chk_Mouse.Checked = Settings.Default.chkMouseState;
            this.rad_Yes.Checked = Settings.Default.radYesState;
            this.rad_No.Checked = Settings.Default.radNoState;
            this.lbl_Key.Text = Settings.Default.lblKeyState;
            this.tb_SetKey.Text = Settings.Default.tbSetKeyState;
            this.chk_Prompt.Checked = Settings.Default.chkSave;
            this.chk_Hide.Checked = Settings.Default.chkHide;
            this.chk_BootRun.Checked = Settings.Default.chkBootRun;
            this.chk_HideRun.Checked = Settings.Default.chkHideRun;
            lbl_Key.Visible = true;
        }

        private void rad_AutoSave_CheckedChanged(object sender, EventArgs e)
        {
            tb_SavePath.Enabled = true;
            tb_Time.Enabled = true;
            chk_Key.Enabled = true;
            chk_Mouse.Enabled = true;
            tb_FileName.Enabled = true;
        }

        private void rad_ManualSave_CheckedChanged(object sender, EventArgs e)
        {
            tb_SavePath.Enabled = false;
            tb_Time.Enabled = false;
            chk_Key.Enabled = false;
            chk_Mouse.Enabled = false;
            tb_FileName.Enabled = false;
            //this.tb_SavePath.Text = "";
            //this.tb_Time.Text = "";
            //this.tb_FileName.Text = "";
            //this.chk_Key.Checked = false;
            //this.chk_Mouse.Checked = false;
        }

        private void lbl_Key_DoubleClick(object sender, EventArgs e)
        {
            lbl_Key.Visible = false;
            k_hook.Start();
            tb_SetKey.Text = "请按下要设置的键";
        }

        void k_hook_KeyDown(object sender, KeyEventArgs e)
        {
            tb_SetKey.Text = e.KeyData.ToString();
            lbl_Key.Text = tb_SetKey.Text;
        }

        //打开帮助
        private void label4_Click(object sender, EventArgs e)
        {
            HelpProvider HP = new HelpProvider();
            HP.HelpNamespace = "Help.txt";
            HP.SetShowHelp(this, true);
        }

        //按下确认
        private void bt_Ok_Click(object sender, EventArgs e)
        {
            if (rad_AutoSave.Checked && !rad_ManualSave.Checked)
            {
                if (tb_FileName.Text.Equals("") || tb_SavePath.Text.Equals("") || tb_Time.Text.Equals("") || (!chk_Key.Checked && !chk_Mouse.Checked))
                {
                    MessageBox.Show("请确认所有保存选项是否更改");
                    return;
                }
                else
                {
                    hookFrm.DoSetAutoSave(tb_SavePath.Text, tb_Time.Text, chk_Key.Checked, chk_Mouse.Checked, tb_FileName.Text);
                    Settings.Default.radAutoSaveState = this.rad_AutoSave.Checked;
                    Settings.Default.radManualSaveState = this.rad_ManualSave.Checked;
                    Settings.Default.tbSavePathState = this.tb_SavePath.Text;
                    Settings.Default.tbTimeState = this.tb_Time.Text;
                    Settings.Default.tbName = this.tb_FileName.Text;
                    Settings.Default.chkKeyState = this.chk_Key.Checked;
                    Settings.Default.chkMouseState = this.chk_Mouse.Checked;
                }
            }

            if (rad_ManualSave.Checked && !rad_AutoSave.Checked)
            {
                hookFrm.DoSetManualSave();
                Settings.Default.radAutoSaveState = this.rad_AutoSave.Checked;
                Settings.Default.radManualSaveState = this.rad_ManualSave.Checked;
                Settings.Default.tbSavePathState = this.tb_SavePath.Text;
                Settings.Default.tbTimeState = this.tb_Time.Text;
                Settings.Default.tbName = this.tb_FileName.Text;
                Settings.Default.chkKeyState = this.chk_Key.Checked;
                Settings.Default.chkMouseState = this.chk_Mouse.Checked;
            }

            if (rad_Yes.Checked && !rad_No.Checked)
            {
                //清除输出栏选项
                //hookFrm.DoSetHideFrm(rad_Yes.Checked);
                Settings.Default.radYesState = this.rad_Yes.Checked;
                Settings.Default.radNoState = this.rad_No.Checked;
            }
            if (rad_No.Checked && !rad_Yes.Checked)
            {
                Settings.Default.radYesState = this.rad_Yes.Checked;
                Settings.Default.radNoState = this.rad_No.Checked;
            }

            if (lbl_Key.Visible == false)
            {
                if (tb_SetKey.Text.Equals("请按下要设置的键"))
                {
                    MessageBox.Show("请确认快捷键是否更改", "提示");
                }
                else
                {
                    Settings.Default.lblKeyState = this.tb_SetKey.Text;
                    this.tb_SetKey.Text = "";
                    Settings.Default.tbSetKeyState = this.tb_SetKey.Text;
                    //Settings.Default.Save();
                }
            }
            if (Settings.Default.lblKeyState == "")//快捷键不为空
            {
                Settings.Default.lblKeyState = "A,Alt";
            }
            if (chk_Prompt.Checked == true)
            {
                Settings.Default.chkSave = true;
            }
            else
                Settings.Default.chkSave = false;

            if (chk_Hide.Checked == true)
            {
                Settings.Default.chkHide = true;
            }
            else
            {
                Settings.Default.chkHide = false;
            }
            if (chk_BootRun.Checked == true)
            {
                Settings.Default.chkBootRun = true;
            }
            else
            {
                Settings.Default.chkBootRun = false;
            }
            if (chk_HideRun.Checked == true)
            {
                Settings.Default.chkHideRun = true;
            }
            else
            {
                Settings.Default.chkHideRun = false;
            }
            
            Settings.Default.Save();//保存设置
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        //按下取消
        private void bt_No_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void tb_SavePath_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
            dialog.Description = "请选择Txt所在文件夹";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "提示");
                    return;
                }
                this.tb_SavePath.Text = dialog.SelectedPath;
                //this.LoadingText = "处理中...";
                //this.LoadingDisplay = true;
                //Action<string> a = DaoRuData;
                //a.BeginInvoke(dialog.SelectedPath, asyncCallback, a);
            }
        }

        private void chk_BootRun_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_BootRun.Checked== true)
                {
                    RegistryKey R_local = Registry.LocalMachine;//RegistryKey R_local = Registry.CurrentUser;
                    RegistryKey R_run = R_local.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
                    R_run.SetValue(Application.ProductName, Application.ExecutablePath);
                    R_run.Close();
                    R_local.Close();
                }
                else
                {
                    RegistryKey R_local = Registry.LocalMachine;//RegistryKey R_local = Registry.CurrentUser;
                    RegistryKey R_run = R_local.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
                    R_run.DeleteValue(Application.ProductName, false);
                    R_run.Close();
                    R_local.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("您需要管理员权限修改", "提示");
            }
        }

        private void SetFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            k_hook.Stop();
        }
    }
}
