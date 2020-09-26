using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Controls;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Threading;

namespace KeyRecord.UIControl
{
    public partial class HeatMapUC : PictureBox
    {
        #region 字段和属性

        private static readonly Random _rand = new Random();

        /// <summary>
        /// The points on the map.
        /// </summary>
        private readonly List<Point> _heatPoints = new List<Point>();

        private float _brushStop = 0.5F; //笔刷变化点 0~1
        private int _heatPointRadius = 15;//半径 1~
        private byte _intensity = 0x5f; //中心浓度 0~255
        private string _paletteFileName;//调色板文件名

        public float BrushStop
        {
            get
            {
                return _brushStop;
            }

            set
            {
                _brushStop = value;
            }
        }

        public int HeatPointRadius
        {
            get
            {
                return _heatPointRadius;
            }

            set
            {
                _heatPointRadius = value;
            }
        }

        public byte Intensity
        {
            get
            {
                return _intensity;
            }

            set
            {
                _intensity = value;
            }
        }

        public string PaletteFileName
        {
            get
            {
                return _paletteFileName;
            }

            set
            {
                _paletteFileName = value;
            }
        }

        #endregion

        #region 构造函数

        public HeatMapUC()
        {
            InitializeComponent();
        }

        #endregion

        #region 绘制函数

        private void drawMask()
        {
            try
            {
                // Create new memory bitmap the same size as the picture box.
                // Set its format to 32bit argb to support transparency.
                Bitmap bmp = new Bitmap(this.Width, this.Height,
                    PixelFormat.Format32bppArgb);

                // Draws the heat points on the bitmap.
                doDrawMask(bmp, _heatPoints);

                // Put the bitmap to the PictureBox.
                this.Image = bmp;
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("绘制灰度图异常({0})！",ex.ToString()));
            }
        }

        private void doDrawMask(Bitmap bmp, List<Point> heatPoints)
        {
            // Create new graphics surface from the bitmap.
            Graphics surface = Graphics.FromImage(bmp);

            ColorBlend colors = getColorBlend();

            // Draw mask heat points on the surface.
            foreach (Point heatPoint in heatPoints)
            {
                drawHeatPoint(surface, heatPoint, colors, HeatPointRadius);
            }
        }

        private void drawHeatPoint(Graphics surface, Point heatPoint,
            ColorBlend colors, int radius)
        {
            // Create the ellipse path.
            var ellipsePath = new GraphicsPath();
            ellipsePath.AddEllipse(heatPoint.X - radius, heatPoint.Y - radius,
                radius * 2, radius * 2);

            // Create the brush.
            PathGradientBrush brush = new PathGradientBrush(ellipsePath);
            ColorBlend gradientSpecifications = colors;
            brush.InterpolationColors = gradientSpecifications;

            // Use the brush to fill the ellipse.
            surface.FillEllipse(brush, heatPoint.X - radius,
                heatPoint.Y - radius, radius * 2, radius * 2);
        }

        private ColorBlend getColorBlend()
        {
            ColorBlend colors = new ColorBlend(3);

            // Set brush stops.
            colors.Positions = new float[3] { 0, BrushStop, 1 };

            // The intensity value adjusts alpha of gradient colors.
            colors.Colors = new Color[3]
            {
                Color.FromArgb(0, Color.White),
                // The following colors can be any color - Only the alpha  value is used.
                Color.FromArgb(Intensity, Color.Black),
                Color.FromArgb(Intensity, Color.Black)
            };
            return colors;
        }

        #endregion

        #region 着色函数

        private Bitmap doColorize(Bitmap originalMask, int[] palette)
        {
            int org_width = originalMask.Width;
            int org_heigth = originalMask.Height;
            Bitmap oriMask = new Bitmap(originalMask);
            // Create an empty bitmap for output.
            Bitmap output = new Bitmap(org_width, org_heigth,
                PixelFormat.Format32bppArgb);
            for (int x = 0; x < org_width; x++)
            {
                for (int y = 0; y < org_heigth; y++)
                {

                    // Calucate the pixel of output image according to the original pixel and palette.
                    output.SetPixel(x, y, Color.FromArgb(
                        palette[(byte)~(((uint)(oriMask.GetPixel(x, y).ToArgb())) >> 24)]));

                }
            }
            return output;
        }

        
        private void colorize()
        {
            // Cancel the operation if the palette is not specified.
            if (PaletteFileName.Length == 0)
            {
                return;
            }

            try
            {
                BackgroundWorker bgWorker = new BackgroundWorker();
                bgWorker.DoWork += (sender, e) =>
                {
                    // Loads the palette.
                    int[] palette = loadPalette();
                    // Colorize the original bitmap.
                    e.Result = doColorize((Bitmap)this.Image, palette);
                };
                bgWorker.RunWorkerCompleted += (sender, e) =>
                {
                    this.Image = (Bitmap)e.Result;
                    this.Refresh();
                };
                if (bgWorker.IsBusy)
                    return;
                bgWorker.RunWorkerAsync();

                //var coloredMap = doColorize((Bitmap)this.Image, palette);

                //this.Image = coloredMap;
                //this.Refresh();
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("色彩化异常({0})！", ex.ToString()));
            }
        }

        /// <summary>
        /// Loads the palette from the file.
        /// </summary>
        /// <returns></returns>
        private int[] loadPalette()
        {
            int[] palette = new int[256];
            Bitmap paletteImage = (Bitmap)Bitmap.FromFile(PaletteFileName);
            for (int i = 0; i < palette.Length - 1; i++)
            {
                palette[i] = paletteImage.GetPixel(i, 0).ToArgb();
            }
            // Set the last color to 0x00000000 to make sure areas 
            // with no heat point remain original.
            palette[palette.Length - 1] = 0;
            return palette;
        }

        #endregion

        #region 方法

        public void SetHeatPoint(int iX,int iY)
        {
            if (iX> this.Width || iY> this.Height)
            {
                return;
            }
            _heatPoints.Add(new Point(iX, iY));

            //drawMask();
        }

        public void DrawMask()
        {
            drawMask();
        }

        public void Colorize()
        {
            colorize();
        }

        public List<Point> GetHeatPoint()
        {
            return new List<Point>(_heatPoints.ToArray());
        }

        #endregion

    }
}
