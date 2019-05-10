//ProcessFrm.cs
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
        public ProcessFrm()
        {
            InitializeComponent();
        }

        private void ProcessFrm_Load(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                Thread1();
            }).Start();
        }

        private void Thread1()
        {
            Process[] ps = Process.GetProcesses();
            List<Procession> pro = new List<Procession>();
            foreach (Process p in ps)
            {
                Procession po = new Procession();
                try { po.Id = p.Id; }
                catch { po.Id = -1; }
                try { po.MainWindowTitle = p.MainWindowTitle; }
                catch { po.MainWindowTitle = "拒绝访问"; }
                try { po.ProcessName = p.ProcessName; }
                catch { po.ProcessName = "拒绝访问"; }
                try { po.StartTime = p.StartTime; }
                catch { po.StartTime = new DateTime(); }
                pro.Add(po);
                this.Invoke(new Action(() =>
                {
                    toolStripProgressBar1.Increment(2);
                }));
            }
            this.Invoke(new Action(() =>
            {
                foreach (var item in pro)
                {
                    int index = dataGridView1.Rows.Add();
                    dataGridView1.Rows[index].Cells[0].Value = item.Id;
                    dataGridView1.Rows[index].Cells[1].Value = item.MainWindowTitle;
                    dataGridView1.Rows[index].Cells[2].Value = item.ProcessName;
                    dataGridView1.Rows[index].Cells[3].Value = item.StartTime;
                }
                toolStripProgressBar1.Value = toolStripProgressBar1.Maximum;
                toolStripStatusLabel1.Text = "完成";
            }));
        }

        void RandomProgressBar()
        {
            Random rd = new Random();
            Thread.Sleep(20000);
            for (int j = 0; j < 10; j++)
            {

                for (int i = 0; i < 20; i++)
                {
                    Thread.Sleep(10);
                    toolStripProgressBar1.Size = new Size(100 + rd.Next(50, 200), 16);
                }
                for (int k = 0; k < 20; k++)
                {
                    Thread.Sleep(10);
                    toolStripProgressBar1.Size = new Size(200 - rd.Next(1, 100), 16);
                }

                toolStripProgressBar1.Size = new Size(100, 16);
            }
            Thread.Sleep(5000);
            for (int j = 0; j < 10; j++)
            {

                for (int i = 0; i < 20; i++)
                {
                    //Thread.Sleep(10);
                    toolStripProgressBar1.Size = new Size(rd.Next(100, 500) + i, rd.Next(16, 30));
                }
                for (int k = 0; k < 20; k++)
                {
                    //Thread.Sleep(30);
                    toolStripProgressBar1.Size = new Size(rd.Next(1, 200) - k, rd.Next(16, 40));
                }

            }
            toolStripProgressBar1.Size = new Size(100, 16);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    public class Procession
    {
        public int Id;
        public string ProcessName;
        public string MainWindowTitle;
        public DateTime StartTime;
    }
}
