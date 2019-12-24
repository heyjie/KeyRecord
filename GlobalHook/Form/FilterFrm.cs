//FilterFrm
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using GlobalHook.Common;

namespace GlobalHook
{
    public partial class FilterFrm : Form
    {
        public FilterFrm()
        {
            InitializeComponent();
        }

        //打开文件
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.FileName = "日志文件";
            OFD.DefaultExt = ".txt";
            OFD.Filter = "日志文件(.txt)|*.txt";
            if (OFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //新建一个datatable用于保存读入数据  
                DataTable dt = new DataTable();
                dt.Columns.Add("名称", typeof(string));  
                dt.Columns.Add("键值", typeof(string));
                dt.Columns.Add("X坐标", typeof(string));
                dt.Columns.Add("Y坐标", typeof(string));  
                dt.Columns.Add("窗口标题", typeof(string));  
                dt.Columns.Add("窗口所属", typeof(string));
                dt.Columns.Add("记录时间", typeof(string));
                //读入文件  
                StreamReader sr = new StreamReader(OFD.FileName, Encoding.UTF8);
                while (!sr.EndOfStream)
                {  
                    string[] items = sr.ReadLine().Split(';');
                    DataRow dr = dt.NewRow();
                    for (int i = 0; i < items.Length; i++)
                    {
                        dr[i] = items[i];
                    }
                    dt.Rows.Add(dr);
                }  
                //将datatable绑定到datagridview上显示结果  
                BindingSource dataSourceInn = new BindingSource(dt, null);
                dataGridView1.DataSource = dataSourceInn;  
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up))
            {
                DataGridViewAutoFilterColumnHeaderCell filterCell =
                    dataGridView1.CurrentCell.OwningColumn.HeaderCell as
                    DataGridViewAutoFilterColumnHeaderCell;
                if (filterCell != null)
                {
                    filterCell.ShowDropDownList();
                    e.Handled = true;
                }
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            String filterStatus = DataGridViewAutoFilterColumnHeaderCell
                .GetFilterStatus(dataGridView1);
            if (String.IsNullOrEmpty(filterStatus))
            {
                toolStripButton2.Visible = false;
                toolStripLabel1.Visible = false;
            }
            else
            {
                toolStripButton2.Visible = true;
                toolStripLabel1.Visible = true;
                toolStripLabel1.Text = filterStatus;
            }
        }

        private void dataGridView1_BindingContextChanged(object sender, EventArgs e)
        {
            // Continue only if the data source has been set.
            if (dataGridView1.DataSource == null)
            {
                return;
            }

            // Add the AutoFilter header cell to each column.
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (col.Name == "IfChoosed")
                {
                    continue;//跳出对象选择列
                }
                col.HeaderCell = new
                    DataGridViewAutoFilterColumnHeaderCell(col.HeaderCell);
            }

            // Format the OrderTotal column as currency. 
            //csDataGridView_Inn.Columns["OrderTotal"].DefaultCellStyle.Format = "c";

            // Resize the columns to fit their contents.
            // csDataGridView_Object.AutoResizeColumns();
        }

        //全部显示
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DataGridViewAutoFilterColumnHeaderCell.RemoveFilter(dataGridView1);
        }
    }
}
