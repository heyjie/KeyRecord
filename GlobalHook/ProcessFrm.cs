using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Threading;
using System.Diagnostics;

namespace GlobalHook
{
    public partial class ProcessFrm : Form
    {
        Thread thread1;
        public ProcessFrm()
        {
            InitializeComponent();
        }

        private void ProcessFrm_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;//不检查跨线程的调用是否合法
            //创建无参的线程
            this.thread1 = new Thread(new ThreadStart(this.Thread1));
            this.thread1.Start();//调用Start方法执行线程
            //timer1.Enabled = true;
        }
        private void Thread1()
        {
            //Thread.Sleep(3000);//该线程睡眠3s
            Process[] ps = Process.GetProcesses();
            foreach (Process p in ps)
            {
                string info = "";
                try
                {
                    info = p.Id + "  " + p.ProcessName + "  " + p.MainWindowTitle + "  " + p.StartTime;
                    this.toolStripProgressBar1.Maximum++;
                }
                catch (Exception ex)
                {
                    info = ex.Message;

                }
                this.listBox1.Items.Add(info);
                //this.listBox1.TopIndex = this.listBox1.Items.Count - (int)(this.listBox1.Height / this.listBox1.ItemHeight);
                this.listBox1.TopIndex = this.listBox1.Items.Count - 1;
                if (this.toolStripProgressBar1.Maximum > toolStripProgressBar1.Value)
                {
                    toolStripProgressBar1.Value++;
                }
            }
            toolStripProgressBar1.Value = toolStripProgressBar1.Maximum;
            toolStripStatusLabel1.Text = "完成";
        }

        private void ProcessFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            thread1.Abort();
        }
        //void RandomProgressBar()
        //{
        //    Random rd = new Random();
        //    Thread.Sleep(20000);
        //    for (int j = 0; j < 10; j++)
        //    {

        //        for (int i = 0; i < 20; i++)
        //        {
        //            Thread.Sleep(10);
        //            toolStripProgressBar1.Size = new Size(100 + rd.Next(50, 200), 16);
        //        }
        //        for (int k = 0; k < 20; k++)
        //        {
        //            Thread.Sleep(10);
        //            toolStripProgressBar1.Size = new Size(200 - rd.Next(1, 100), 16);
        //        }
                
        //        toolStripProgressBar1.Size = new Size(100, 16);
        //    }
        //    Thread.Sleep(5000);
        //    for (int j = 0; j < 10; j++)
        //    {

        //        for (int i = 0; i < 20; i++)
        //        {
        //            //Thread.Sleep(10);
        //            toolStripProgressBar1.Size = new Size(rd.Next(100, 500) + i, rd.Next(16, 30));
        //        }
        //        for (int k = 0; k < 20; k++)
        //        {
        //            //Thread.Sleep(30);
        //            toolStripProgressBar1.Size = new Size(rd.Next(1, 200) - k, rd.Next(16, 40));
        //        }

        //    }
        //    toolStripProgressBar1.Size = new Size(100, 16);
        //}
    }
}
