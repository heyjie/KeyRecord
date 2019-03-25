//CloseFrm.cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GlobalHook.Properties;

namespace GlobalHook
{
    public partial class CloseFrm : Form
    {
        public CloseFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(rb_Min.Checked&&!rb_Max.Checked)
            {
                Settings.Default.rbMin = this.rb_Min.Checked;
                Settings.Default.rbMax = this.rb_Max.Checked;
            }
            if (!rb_Min.Checked && rb_Max.Checked)
            {
                Settings.Default.rbMin = this.rb_Min.Checked;
                Settings.Default.rbMax = this.rb_Max.Checked;
            }
            if(this.checkBox1.Checked)
            {
                Settings.Default.chkSave = false;
            }
            else
                Settings.Default.chkSave = true;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void CloseFrm_Load(object sender, EventArgs e)
        {
            this.rb_Min.Checked = Settings.Default.rbMin;
            this.rb_Max.Checked = Settings.Default.rbMax;
            this.checkBox1.Checked = !Settings.Default.chkSave;
        }

        private void CloseFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Save();
        }
    }
}
