using KeyRecord.Model;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyRecord.UserForm
{

    public partial class ClickHeatMapFrm : MetroForm
    {

        public delegate void DoApiCallDelegate();
        public ClickHeatMapFrm()
        {
            InitializeComponent();
            //DoubleBuffered = true;
            //WindowState = FormWindowState.Maximized;
            heatMapUC1.PaletteFileName = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "Resources\\Palettes\\ColorPalette1.png";
            heatMapUC1.BackgroundImage = GetScreens();
            heatMapUC1.Size = heatMapUC1.BackgroundImage.Size;
            //this.TransparencyKey = BackColor;
            //this.Opacity = 0.5;
            heatMapUC1.HeatPointRadius = 30; //热点半径
            heatMapUC1.Intensity = (byte)95; //单点中心浓度
            heatMapUC1.BrushStop = 0.65F; //笔刷变换点
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DoApiCallDelegate del = BulidThermalMap;//绑定委托方法
            AsyncCallback callBack = BulidThermalMapColorize;//建立异步回调方法
            del.BeginInvoke(BulidThermalMapColorize, del);//异步执行委托方法
        }

        private void BulidThermalMap()
        {
            var today = DateTime.Now.Date;
            using (var context = new WareHouse_localEntities())
            {
                var L2EQuery = context.KeyMice.Where(
                    s => s.ExecuteDate >= today && s.DeviceName == "鼠标"
                    );
                var mouse_list = L2EQuery.ToList();
                foreach (var i in mouse_list)
                {
                    if (IsHandleCreated)
                    {
                        this.Invoke(new MethodInvoker(delegate
                        {
                            this.heatMapUC1.SetHeatPoint(Convert.ToInt32(i.LocationX), Convert.ToInt32(i.LocationY));
                        }));
                    }
                }
            }
            this.Invoke(new MethodInvoker(delegate
            {
                heatMapUC1.DrawMask();
            }));
        }

        private void SaveBitmap()
        {

            Bitmap bmp = new Bitmap(metroPanel1.Width, metroPanel1.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            metroPanel1.DrawToBitmap(bmp, new Rectangle(0, 0, metroPanel1.Width, metroPanel1.Height));
            bmp.Save("led.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
        }

        private void BulidThermalMapColorize(IAsyncResult result)
        {
            if (IsHandleCreated)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    heatMapUC1.Colorize();
                }));
            }
        }

        /// <summary>
        /// 全屏截图，不包含任务栏
        /// </summary>
        /// <returns></returns>
        public Bitmap GetScreen()
        {
            //获取整个屏幕图像,不包括任务栏
            Rectangle ScreenArea = Screen.GetWorkingArea(this);
            Bitmap bmp = new Bitmap(ScreenArea.Width, ScreenArea.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(0, 0, 0, 0, new Size(ScreenArea.Width, ScreenArea.Height));
            }
            return bmp;
        }

        /// <summary>
        /// 全屏截图，包含任务栏
        /// </summary>
        /// <returns></returns>
        public Bitmap GetScreens()
        {
            Bitmap bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(new Point(0, 0), new Point(0, 0), Screen.AllScreens[0].Bounds.Size);
            }
            return bmp;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "另存为";
                sfd.Filter = "图片(*.bmp)|*.bmp|所有文件(*.*)|*.*";
                sfd.FilterIndex = 1;//设置默认文件类型显示顺序 
                sfd.RestoreDirectory = true; //点了保存按钮进入
                sfd.FileName = DateTime.Now.ToFileTimeUtc().ToString();
                if (sfd.ShowDialog(this) == DialogResult.OK)
                {
                    //Bitmap bmp = new Bitmap(metroPanel1.Width, metroPanel1.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                    //metroPanel1.DrawToBitmap(bmp, new Rectangle(0, 0, metroPanel1.Width, metroPanel1.Height));

                    heatMapUC1.Image.Save(sfd.FileName);
                    //bmp.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                }
            }
        }
    }
}

