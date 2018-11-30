using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;

namespace GlobalHook
{
    public partial class SaveFrm : Form
    {
        //private HookOutputFrm HookOutputFrm;
        //public SaveFrm(HookOutputFrm HookOutputFrm)
        //{
        //    this.HookOutputFrm = HookOutputFrm;
        //} 
        //HookOutputFrm hookFrm;
        public SaveFrm()
        {
            InitializeComponent();
        }

        private void SaveFrm_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = comboBox1.Items.IndexOf("全部保存");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //用委托来处理保存
            //try
            //{
                //if (comboBox1.SelectedItem.ToString() == "全部保存")
                //{
                //    HookOutputFrm.DoSaveAllMessage();
                //}
                //if (comboBox1.SelectedItem.ToString() == "保存键盘输出数据")
                //{
                //    HookOutputFrm.DoSaveKeyMessage();
                //}
                //if (comboBox1.SelectedItem.ToString() == "保存鼠标输出数据")
                //{
                //    HookOutputFrm.DoSaveMouseMessage();
                //}
                if (comboBox1.Text.ToString() == "全部保存")
                {
                    HookOutputFrm.DoSaveAllMessage();
                }
                if (comboBox1.Text.ToString() == "保存键盘输出数据")
                {
                    HookOutputFrm.DoSaveKeyMessage();
                }
                if (comboBox1.Text.ToString() == "保存鼠标输出数据")
                {
                    HookOutputFrm.DoSaveMouseMessage();
                }
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
            this.DialogResult=System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
