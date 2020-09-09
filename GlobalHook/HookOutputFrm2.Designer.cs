namespace GlobalHook
{
    partial class HookOutputFrm2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HookOutputFrm2));
            this.metroContextMenu_grid = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.ToolStripMenuItem_open = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_info = new System.Windows.Forms.ToolStripMenuItem();
            this.metroTabControl_main = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage_log = new MetroFramework.Controls.MetroTabPage();
            this.metroGrid_kmData = new MetroFramework.Controls.MetroGrid();
            this.CategoryIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KeyData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.说明 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProgramIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExecuteDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroContextMenu_grid.SuspendLayout();
            this.metroTabControl_main.SuspendLayout();
            this.metroTabPage_log.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid_kmData)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.metroTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroContextMenu_grid
            // 
            this.metroContextMenu_grid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroContextMenu_grid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.metroContextMenu_grid.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.metroContextMenu_grid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_open,
            this.ToolStripMenuItem_info});
            this.metroContextMenu_grid.Name = "metroContextMenu1";
            this.metroContextMenu_grid.Size = new System.Drawing.Size(154, 52);
            this.metroContextMenu_grid.Text = "帮助(H)";
            // 
            // ToolStripMenuItem_open
            // 
            this.ToolStripMenuItem_open.Name = "ToolStripMenuItem_open";
            this.ToolStripMenuItem_open.Size = new System.Drawing.Size(153, 24);
            this.ToolStripMenuItem_open.Text = "打开文件夹";
            this.ToolStripMenuItem_open.Click += new System.EventHandler(this.ToolStripMenuItem_open_Click);
            // 
            // ToolStripMenuItem_info
            // 
            this.ToolStripMenuItem_info.Name = "ToolStripMenuItem_info";
            this.ToolStripMenuItem_info.Size = new System.Drawing.Size(153, 24);
            this.ToolStripMenuItem_info.Text = "关于";
            // 
            // metroTabControl_main
            // 
            this.metroTabControl_main.Controls.Add(this.metroTabPage_log);
            this.metroTabControl_main.Controls.Add(this.metroTabPage2);
            this.metroTabControl_main.Controls.Add(this.metroTabPage3);
            this.metroTabControl_main.Controls.Add(this.metroTabPage4);
            this.metroTabControl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl_main.Location = new System.Drawing.Point(27, 69);
            this.metroTabControl_main.Margin = new System.Windows.Forms.Padding(4);
            this.metroTabControl_main.Name = "metroTabControl_main";
            this.metroTabControl_main.SelectedIndex = 2;
            this.metroTabControl_main.Size = new System.Drawing.Size(906, 448);
            this.metroTabControl_main.TabIndex = 1;
            this.metroTabControl_main.UseSelectable = true;
            // 
            // metroTabPage_log
            // 
            this.metroTabPage_log.Controls.Add(this.metroGrid_kmData);
            this.metroTabPage_log.Controls.Add(this.metroPanel1);
            this.metroTabPage_log.HorizontalScrollbarBarColor = true;
            this.metroTabPage_log.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage_log.HorizontalScrollbarSize = 10;
            this.metroTabPage_log.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage_log.Margin = new System.Windows.Forms.Padding(4);
            this.metroTabPage_log.Name = "metroTabPage_log";
            this.metroTabPage_log.Padding = new System.Windows.Forms.Padding(23, 27, 23, 27);
            this.metroTabPage_log.Size = new System.Drawing.Size(898, 406);
            this.metroTabPage_log.TabIndex = 0;
            this.metroTabPage_log.Text = "日志";
            this.metroTabPage_log.VerticalScrollbarBarColor = true;
            this.metroTabPage_log.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage_log.VerticalScrollbarSize = 10;
            // 
            // metroGrid_kmData
            // 
            this.metroGrid_kmData.AllowUserToAddRows = false;
            this.metroGrid_kmData.AllowUserToDeleteRows = false;
            this.metroGrid_kmData.AllowUserToOrderColumns = true;
            this.metroGrid_kmData.AllowUserToResizeRows = false;
            this.metroGrid_kmData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid_kmData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid_kmData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid_kmData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid_kmData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid_kmData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid_kmData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryIcon,
            this.DeviceName,
            this.KeyData,
            this.LocationX,
            this.LocationY,
            this.说明,
            this.Title,
            this.ProgramIcon,
            this.ClassName,
            this.ProcessPath,
            this.ExecuteDate});
            this.metroGrid_kmData.ContextMenuStrip = this.metroContextMenu_grid;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid_kmData.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid_kmData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGrid_kmData.EnableHeadersVisualStyles = false;
            this.metroGrid_kmData.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid_kmData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid_kmData.Location = new System.Drawing.Point(23, 59);
            this.metroGrid_kmData.MultiSelect = false;
            this.metroGrid_kmData.Name = "metroGrid_kmData";
            this.metroGrid_kmData.ReadOnly = true;
            this.metroGrid_kmData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid_kmData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid_kmData.RowHeadersVisible = false;
            this.metroGrid_kmData.RowHeadersWidth = 51;
            this.metroGrid_kmData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid_kmData.RowTemplate.Height = 27;
            this.metroGrid_kmData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid_kmData.Size = new System.Drawing.Size(852, 320);
            this.metroGrid_kmData.TabIndex = 2;
            // 
            // CategoryIcon
            // 
            this.CategoryIcon.DataPropertyName = "CategoryIcon";
            this.CategoryIcon.HeaderText = "";
            this.CategoryIcon.MinimumWidth = 6;
            this.CategoryIcon.Name = "CategoryIcon";
            this.CategoryIcon.ReadOnly = true;
            this.CategoryIcon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoryIcon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CategoryIcon.Width = 50;
            // 
            // DeviceName
            // 
            this.DeviceName.DataPropertyName = "DeviceName";
            this.DeviceName.HeaderText = "设备";
            this.DeviceName.MinimumWidth = 6;
            this.DeviceName.Name = "DeviceName";
            this.DeviceName.ReadOnly = true;
            this.DeviceName.Width = 60;
            // 
            // KeyData
            // 
            this.KeyData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KeyData.DataPropertyName = "KeyData";
            this.KeyData.FillWeight = 60F;
            this.KeyData.HeaderText = "键值";
            this.KeyData.MinimumWidth = 60;
            this.KeyData.Name = "KeyData";
            this.KeyData.ReadOnly = true;
            // 
            // LocationX
            // 
            this.LocationX.DataPropertyName = "LocationX";
            this.LocationX.HeaderText = "X坐标";
            this.LocationX.MinimumWidth = 6;
            this.LocationX.Name = "LocationX";
            this.LocationX.ReadOnly = true;
            this.LocationX.Width = 70;
            // 
            // LocationY
            // 
            this.LocationY.DataPropertyName = "LocationY";
            this.LocationY.HeaderText = "Y坐标";
            this.LocationY.MinimumWidth = 6;
            this.LocationY.Name = "LocationY";
            this.LocationY.ReadOnly = true;
            this.LocationY.Width = 70;
            // 
            // 说明
            // 
            this.说明.DataPropertyName = "keyType";
            this.说明.HeaderText = "说明";
            this.说明.MinimumWidth = 6;
            this.说明.Name = "说明";
            this.说明.ReadOnly = true;
            this.说明.Width = 125;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Title.DataPropertyName = "Title";
            this.Title.FillWeight = 90F;
            this.Title.HeaderText = "窗口";
            this.Title.MinimumWidth = 60;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // ProgramIcon
            // 
            this.ProgramIcon.DataPropertyName = "ProgramIcon";
            this.ProgramIcon.HeaderText = "图标";
            this.ProgramIcon.MinimumWidth = 6;
            this.ProgramIcon.Name = "ProgramIcon";
            this.ProgramIcon.ReadOnly = true;
            this.ProgramIcon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProgramIcon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ProgramIcon.Width = 60;
            // 
            // ClassName
            // 
            this.ClassName.DataPropertyName = "ClassName";
            this.ClassName.HeaderText = "所属类名";
            this.ClassName.MinimumWidth = 6;
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            this.ClassName.Visible = false;
            this.ClassName.Width = 125;
            // 
            // ProcessPath
            // 
            this.ProcessPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProcessPath.DataPropertyName = "ProcessPath";
            this.ProcessPath.HeaderText = "路径";
            this.ProcessPath.MinimumWidth = 60;
            this.ProcessPath.Name = "ProcessPath";
            this.ProcessPath.ReadOnly = true;
            // 
            // ExecuteDate
            // 
            this.ExecuteDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ExecuteDate.DataPropertyName = "ExecuteDate";
            this.ExecuteDate.FillWeight = 60F;
            this.ExecuteDate.HeaderText = "时间";
            this.ExecuteDate.MinimumWidth = 60;
            this.ExecuteDate.Name = "ExecuteDate";
            this.ExecuteDate.ReadOnly = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroButton3);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 27);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(852, 32);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(3, 6);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(75, 23);
            this.metroButton3.TabIndex = 2;
            this.metroButton3.Text = "停止";
            this.metroButton3.UseSelectable = true;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.AutoScroll = true;
            this.metroTabPage3.HorizontalScrollbar = true;
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(898, 406);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "录制";
            this.metroTabPage3.VerticalScrollbar = true;
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.AutoScroll = true;
            this.metroTabPage2.HorizontalScrollbar = true;
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(898, 406);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "分析";
            this.metroTabPage2.VerticalScrollbar = true;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.AutoScroll = true;
            this.metroTabPage4.Controls.Add(this.metroButton1);
            this.metroTabPage4.Controls.Add(this.metroButton2);
            this.metroTabPage4.HorizontalScrollbar = true;
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(898, 406);
            this.metroTabPage4.TabIndex = 3;
            this.metroTabPage4.Text = "选项";
            this.metroTabPage4.VerticalScrollbar = true;
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(21, 31);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "metroButton1";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(145, 31);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 3;
            this.metroButton2.Text = "metroButton1";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroToggle1
            // 
            this.metroToggle1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroToggle1.AutoSize = true;
            this.metroToggle1.Location = new System.Drawing.Point(768, 10);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(80, 19);
            this.metroToggle1.TabIndex = 4;
            this.metroToggle1.Text = "Off";
            this.metroToggle1.UseSelectable = true;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "keyboardc.png");
            this.imageList.Images.SetKeyName(1, "mousec.png");
            this.imageList.Images.SetKeyName(2, "win.ico");
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "CategoryIcon";
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 95;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DeviceName";
            this.dataGridViewTextBoxColumn1.HeaderText = "DeviceName";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 94;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "KeyData";
            this.dataGridViewTextBoxColumn2.FillWeight = 80F;
            this.dataGridViewTextBoxColumn2.HeaderText = "KeyData";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 60;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LocationX";
            this.dataGridViewTextBoxColumn3.HeaderText = "LocationX";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 95;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "LocationY";
            this.dataGridViewTextBoxColumn4.HeaderText = "LocationY";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 94;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn5.FillWeight = 90F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Title";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 60;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ClassName";
            this.dataGridViewTextBoxColumn6.FillWeight = 90F;
            this.dataGridViewTextBoxColumn6.HeaderText = "ClassName";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 60;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.DataPropertyName = "ProgramIcon";
            this.dataGridViewImageColumn2.HeaderText = "ProgramIcon";
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn2.Width = 95;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ProcessPath";
            this.dataGridViewTextBoxColumn7.HeaderText = "ProcessPath";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 60;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ExecuteDate";
            this.dataGridViewTextBoxColumn8.FillWeight = 80F;
            this.dataGridViewTextBoxColumn8.HeaderText = "ExecuteDate";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 60;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ExecuteDate";
            this.dataGridViewTextBoxColumn9.FillWeight = 60F;
            this.dataGridViewTextBoxColumn9.HeaderText = "时间";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 60;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // HookOutputFrm2
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::GlobalHook.Properties.Resources.system3;
            this.BackImagePadding = new System.Windows.Forms.Padding(250, 10, 0, 0);
            this.BackMaxSize = 50;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.metroTabControl_main);
            this.Controls.Add(this.metroToggle1);
            this.KeyPreview = true;
            this.Name = "HookOutputFrm2";
            this.Padding = new System.Windows.Forms.Padding(27, 69, 27, 23);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.StyleManager = this.metroStyleManager1;
            this.Text = "DEMO";
            this.Load += new System.EventHandler(this.HookOutputFrm2_Load);
            this.metroContextMenu_grid.ResumeLayout(false);
            this.metroTabControl_main.ResumeLayout(false);
            this.metroTabPage_log.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid_kmData)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroContextMenu metroContextMenu_grid;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_open;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_info;
        private MetroFramework.Controls.MetroTabControl metroTabControl_main;
        private MetroFramework.Controls.MetroTabPage metroTabPage_log;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private MetroFramework.Controls.MetroGrid metroGrid_kmData;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.ImageList imageList;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroToggle metroToggle1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewImageColumn CategoryIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeyData;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationX;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationY;
        private System.Windows.Forms.DataGridViewTextBoxColumn 说明;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewImageColumn ProgramIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExecuteDate;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton metroButton3;
    }
}