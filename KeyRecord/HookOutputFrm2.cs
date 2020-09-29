using KeyRecord.Common;
using KeyRecord.Model;
using KeyRecord.UserForm;
using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Wpf;
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

namespace KeyRecord
{
    public partial class HookOutputFrm2 : MetroForm
    {
        public HookOutputFrm2()
        {
            InitializeComponent();
            //图表初始化
            ConstantChanges();
        }

        private void HookOutputFrm2_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“wareHouse_localDataSet.KeyMouse”中。您可以根据需要移动或删除它。
            //this.keyMouseTableAdapter.Fill(this.wareHouse_localDataSet.KeyMouse);
            CSGlobal.GetInstance().k_hook.KeyDown += K_hook_KeyDown;//全局按键事件
            CSGlobal.GetInstance().k_hook.KeyUp += K_hook_KeyUp;
            CSGlobal.GetInstance().k_hook.Start();//安装键盘钩子
            CSGlobal.GetInstance().m_hook.MouseDown += M_hook_MouseDown;//全局点击事件
            CSGlobal.GetInstance().m_hook.Start();
            this.metroGrid_kmData.DataSource = CSGlobal.GetInstance().KeyMs;
        }


        #region 日志记录页
        private async void M_hook_MouseDown(object sender, MouseEventArgs e)
        {
            //获取windos窗口信息
            Dictionary<string, object> winDet = GetWindowDetail();
            string info = winDet["info"].ToString();
            string tit = winDet["tit"].ToString();
            Icon ico = (Icon)winDet["ico"];
            StringBuilder className = (StringBuilder)winDet["className"];
            //添加数据
            KeyMouseModel km = new KeyMouseModel();
            KeyMouse KeyM = new KeyMouse();
            km.CategoryIcon = (Bitmap)imageList.Images["mousec.png"];
            KeyM.DeviceName = km.DeviceName = "鼠标";
            KeyM.KeyData = km.KeyData = e.Button.ToString();
            KeyM.LocationX = km.LocationX = e.X;
            KeyM.LocationY = km.LocationY = e.Y;
            KeyM.Title = km.Title = tit;
            KeyM.ClassName = km.ClassName = className.ToString();
            KeyM.ProcessPath = km.ProcessPath = info;
            km.ExecuteDate = DateTime.Now.ToString();
            KeyM.ExecuteDate = DateTime.Now;
            try
            {
                km.ProgramIcon = ico == null ? (Bitmap)imageList.Images["win.ico"] : ico.ToBitmap();
            }
            catch (Exception ex)
            {
                km.ProgramIcon = (Bitmap)imageList.Images["win.ico"];
            }
            CSGlobal.GetInstance().KeyMs.Add(km);
            using (var context = new WareHouse_localEntities())
            {
                context.KeyMice.Add(KeyM);
                //context.SaveChanges();
                await context.SaveChangesAsync();
            }
            imageList.Images["mousec.png"].Dispose();
            imageList.Images["win.ico"].Dispose();
        }

        private void K_hook_KeyUp(object sender, KeyEventArgs e)
        {
            if (!(e.KeyValue == (int)Keys.LMenu
                || e.KeyValue == (int)Keys.RMenu
                || e.KeyValue == (int)Keys.LControlKey
                || e.KeyValue == (int)Keys.RControlKey
                || e.KeyValue == (int)Keys.LShiftKey
                || e.KeyValue == (int)Keys.RShiftKey
                || e.KeyValue == (int)Keys.LWin
                || e.KeyValue == (int)Keys.RWin
                || e.KeyValue == (int)Keys.Menu
                || e.KeyValue == (int)Keys.Control
                || e.KeyValue == (int)Keys.Shift
                ))
            {
                CSGlobal.GetInstance().k_hook.KeyDown += K_hook_KeyDown;
            }
        }

        private async void K_hook_KeyDown(object sender, KeyEventArgs e)
        {

            //判断按下的键（Alt + A）
            //if (e.KeyData.ToString() == Settings.Default.lblKeyState)
            if (e.KeyValue == (int)Keys.A && (int)Control.ModifierKeys == (int)Keys.Alt)
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
            //避免一直触发事件，除了控制键
            if (!(e.KeyValue == (int)Keys.LMenu
                || e.KeyValue == (int)Keys.RMenu
                || e.KeyValue == (int)Keys.LControlKey
                || e.KeyValue == (int)Keys.RControlKey
                || e.KeyValue == (int)Keys.LShiftKey
                || e.KeyValue == (int)Keys.RShiftKey
                || e.KeyValue == (int)Keys.LWin
                || e.KeyValue == (int)Keys.RWin
                || e.KeyValue == (int)Keys.Menu
                || e.KeyValue == (int)Keys.Control
                || e.KeyValue == (int)Keys.Shift
                ))
            {
                CSGlobal.GetInstance().k_hook.KeyDown -= K_hook_KeyDown;
            }
            //获取widos窗口信息
            Dictionary<string, object> winDet = GetWindowDetail();
            string info = winDet["info"].ToString();
            string tit = winDet["tit"].ToString();
            Icon ico = (Icon)winDet["ico"];
            StringBuilder className = (StringBuilder)winDet["className"];
            //添加数据
            KeyMouseModel km = new KeyMouseModel();
            KeyMouse KeyM = new KeyMouse();
            km.CategoryIcon = (Bitmap)imageList.Images["keyboardc.png"];
            KeyM.DeviceName = km.DeviceName = "键盘";
            KeyM.KeyData = km.KeyData = e.KeyData.ToString();
            km.LocationX = 0;
            km.LocationY = 0;
            KeyM.Title = km.Title = tit;
            KeyM.ClassName = km.ClassName = className.ToString();
            KeyM.ProcessPath = km.ProcessPath = info;
            km.ExecuteDate = DateTime.Now.ToString();
            KeyM.ExecuteDate = DateTime.Now;
            km.ProgramIcon = ico == null ? (Bitmap)imageList.Images["win.ico"] : ico.ToBitmap();
            CSGlobal.GetInstance().KeyMs.Add(km);
            using (var context = new WareHouse_localEntities())
            {
                context.KeyMice.Add(KeyM);
                await context.SaveChangesAsync();
            }
            imageList.Images["keyboardc.png"].Dispose();
            imageList.Images["win.ico"].Dispose();
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

        private Dictionary<string, object> GetWindowDetail()
        {
            string info;
            string tit;
            Icon ico = null;
            StringBuilder className = new StringBuilder(256);
            try
            {
                //int x = Cursor.Position.X;
                //int y = Cursor.Position.Y;
                //Point p = new Point(x, y);
                //IntPtr formHandle = Common.Common.WindowFromPoint(p);// 通过鼠标位置得到窗口句柄 
                IntPtr formHandle = Common.Common.GetForegroundWindow();// 通过活动窗口得到窗口句柄
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
                    Console.Out.WriteLine(String.Format("获取应用图标失败：{0}", ex.Message));
                }
                tit = title.ToString();
                info = sb.ToString();
            }
            catch (Exception ex)
            {
                tit = ex.Message;
                info = ex.Message;
            }

            Dictionary<string, object> winDet = new Dictionary<string, object>();
            winDet.Add("info", info);
            winDet.Add("tit", tit);
            winDet.Add("ico", ico);
            winDet.Add("className", className);
            return winDet;
        }
        #endregion

        #region 图表页
        #region 折线图
        /// <summary>
        /// 初始化实时折线图
        /// </summary>
        public void ConstantChanges()
        {
            var mapper = Mappers.Xy<MeasureModel>()
                .X(model => model.DateTime.Ticks)   //use DateTime.Ticks as X
                .Y(model => model.Value);           //use the value property as Y

            //lets save the mapper globally.
            Charting.For<MeasureModel>(mapper);

            //the ChartValues property will store our values array
            ChartValues = new ChartValues<MeasureModel>();
            ChartValues_Mouse = new ChartValues<MeasureModel>();
            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "鼠标",
                    Values = ChartValues_Mouse,
                    PointGeometrySize = 18,
                    StrokeThickness = 4
                },
                new LineSeries
                {
                    Title = "键盘",
                    Values = ChartValues,
                    PointGeometrySize = 18,
                    StrokeThickness = 4
                }
            };
            cartesianChart1.AxisX.Add(new Axis
            {
                DisableAnimations = true,
                LabelFormatter = value => new System.DateTime((long)value).ToString("mm:ss"),
                Separator = new Separator
                {
                    Step = TimeSpan.FromSeconds(1).Ticks
                }
            });

            SetAxisLimits(System.DateTime.Now);

            //The next code simulates data changes every 500 ms
            Timer = new Timer
            {
                Interval = 2000
            };
            Timer.Tick += TimerOnTick;
            R = new Random();
        }

        public ChartValues<MeasureModel> ChartValues { get; set; }

        public ChartValues<MeasureModel> ChartValues_Mouse { get; set; }
        public Timer Timer { get; set; }
        public Random R { get; set; }

        private void SetAxisLimits(System.DateTime now)
        {
            cartesianChart1.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(1).Ticks; // lets force the axis to be 100ms ahead
            cartesianChart1.AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(8).Ticks; //we only care about the last 8 seconds
        }

        private void TimerOnTick(object sender, EventArgs eventArgs)
        {
            var now = DateTime.Now.AddSeconds(-3);
            int cont1 = 0;
            int cont2 = 0;
            using (var context = new WareHouse_localEntities())
            {
                var L2EQuery_Mouse = context.KeyMice.Where(
                    s => s.ExecuteDate >= now && s.DeviceName == "鼠标"
                    );
                var L2EQuery = context.KeyMice.Where(
                    s => s.ExecuteDate >= now && s.DeviceName == "键盘"
                    );
                //var keyList = L2EQuery.FirstOrDefault<KeyMouse>();
                cont1 = L2EQuery_Mouse.Count<KeyMouse>();
                cont2 = L2EQuery.Count<KeyMouse>();
            }
            ChartValues_Mouse.Add(new MeasureModel
            {
                DateTime = now,
                Value = cont1
            });
            ChartValues.Add(new MeasureModel
            {
                DateTime = now,
                Value = cont2
            });

            SetAxisLimits(now);

            //lets only use the last 30 values
            if (ChartValues.Count > 30) ChartValues.RemoveAt(0);
            if (ChartValues_Mouse.Count > 30) ChartValues.RemoveAt(0);
        }

        public class MeasureModel
        {
            public System.DateTime DateTime { get; set; }
            public double Value { get; set; }
        }
        #endregion

        #region 饼图
        public void PieChartExample()
        {
            Func<ChartPoint, string> labelPoint = chartPoint =>
            string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            var today = DateTime.Now.Date.AddDays(-1);

            using (var context = new WareHouse_localEntities())
            {
                var L2EQuery = from km in context.KeyMice
                               where km.ExecuteDate >= today
                               group km by new { km.KeyData, km.DeviceName } into g
                               orderby g.Count() descending
                               select new { Peo = g.Key, Count = g.Count() };
                var keyList = L2EQuery.ToList();

                SeriesCollection result = new SeriesCollection();

                for (int i = 0; i < keyList.Count; i++)
                {
                    ChartValues<double> chartvalue = new ChartValues<double>();
                    chartvalue.Add(keyList[i].Count);

                    PieSeries series = new PieSeries();
                    series.Values = chartvalue;
                    series.Title = keyList[i].Peo.KeyData;
                    series.DataLabels = true;
                    series.LabelPoint = labelPoint;
                    if (i == 0)
                    {
                        //突出第一名
                        series.PushOut = 15;
                    }
                    result.Add(series);
                    if (i > 8)
                    {
                        //最多展示
                        break;
                    }
                }
                pieChart1.Series = result;
            }

            pieChart1.LegendLocation = LegendLocation.Bottom;
        }

        #endregion
        #endregion

        #region 选项页
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

        private void metroButton3_Click(object sender, EventArgs e)
        {
            ClickHeatMapFrm heatFrm = new ClickHeatMapFrm();
            heatFrm.Show();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(CSGlobal.GetInstance().hookFrm, "该功能还未实现", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroToggle1.Checked)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }
        #endregion

        private void metroTabControl_main_Selected(object sender, TabControlEventArgs e)
        {
            if (metroTabControl_main.SelectedTab == metroTabPage_chart)
            {
                PieChartExample();
                Timer.Start();
            }
            else
            {
                Timer.Stop();
            }
            if (metroTabControl_main.SelectedTab == metroTabPage_count)
            {
                //切换统计选项卡
                var today = DateTime.Now.Date.AddDays(-1);
                using (var context = new WareHouse_localEntities())
                {
                    var L2EQuery = from km in context.KeyMice
                                   where km.ExecuteDate >= today
                                   group km by new { km.KeyData, km.DeviceName } into g
                                   orderby g.Count() descending
                                   select new { Peo = g.Key, Count = g.Count() };
                    var keyList = L2EQuery.ToList();
                    var L2EQuery2 = context.KeyMice.Where(
                    s => s.ExecuteDate >= today
                    );
                    var L2EQuery3 = context.KeyMice;
                    var cont = L2EQuery2.Count<KeyMouse>();
                    var cont2 = L2EQuery3.Count<KeyMouse>();
                    metroTile1.Text = string.Format("今天按了{0}次\n\r一共按了{1}次",cont.ToString(),cont2.ToString());

                    BindingList<KeyMouseModel> keyMs = new BindingList<KeyMouseModel>();
                    for (int i = 0; i < keyList.Count; i++)
                    {
                        KeyMouseModel keyM = new KeyMouseModel();
                        keyM.DeviceName = keyList[i].Peo.DeviceName;
                        keyM.KeyData = keyList[i].Peo.KeyData;
                        keyM.ExtendedValue = keyList[i].Count.ToString();
                        keyMs.Add(keyM);
                    }
                    this.metroGrid_count.DataSource = keyMs;
                };
            }
        }

        private void metroGrid_kmData_DataSourceChanged(object sender, EventArgs e)
        {
            if(metroGrid_kmData.DataSource!=null)
            {
                //this.metroGrid_kmData.FirstDisplayedScrollingRowIndex = this.metroGrid_kmData.Rows.Count - 1;
            }
        }

        private void metroGrid_kmData_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //保持datagrid100行，数据太多datagrid性能会变差
            if(CSGlobal.GetInstance().KeyMs.Count>100)
            {
                CSGlobal.GetInstance().KeyMs.RemoveAt(0);
            }
            if (
                metroGrid_kmData.DataSource != null 
                && this.metroGrid_kmData.Rows.Count > 0 
                && !this.metroGrid_kmData.Focused 
                && metroTabControl_main.SelectedTab == metroTabPage_log
                )
            {
                this.metroGrid_kmData.FirstDisplayedScrollingRowIndex = this.metroGrid_kmData.Rows.Count - 1;
            }
        }
    }
}
