//SaveFrm.cs
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
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
