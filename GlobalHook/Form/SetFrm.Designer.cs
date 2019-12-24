namespace GlobalHook
{
    partial class SetFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_No = new System.Windows.Forms.Button();
            this.bt_Ok = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_FileName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chk_Mouse = new System.Windows.Forms.CheckBox();
            this.chk_Key = new System.Windows.Forms.CheckBox();
            this.tb_Time = new System.Windows.Forms.TextBox();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.tb_SavePath = new System.Windows.Forms.TextBox();
            this.lbl_SavePath = new System.Windows.Forms.Label();
            this.rad_ManualSave = new System.Windows.Forms.RadioButton();
            this.rad_AutoSave = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chk_Hide = new System.Windows.Forms.CheckBox();
            this.chk_Prompt = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Key = new System.Windows.Forms.Label();
            this.tb_SetKey = new System.Windows.Forms.TextBox();
            this.lbl_SetKey = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rad_No = new System.Windows.Forms.RadioButton();
            this.rad_Yes = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chk_HideRun = new System.Windows.Forms.CheckBox();
            this.chk_BootRun = new System.Windows.Forms.CheckBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.bt_No);
            this.panel1.Controls.Add(this.bt_Ok);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 403);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 48);
            this.panel1.TabIndex = 0;
            // 
            // bt_No
            // 
            this.bt_No.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_No.Location = new System.Drawing.Point(435, 9);
            this.bt_No.Margin = new System.Windows.Forms.Padding(4);
            this.bt_No.Name = "bt_No";
            this.bt_No.Size = new System.Drawing.Size(100, 29);
            this.bt_No.TabIndex = 1;
            this.bt_No.Text = "取消";
            this.bt_No.UseVisualStyleBackColor = true;
            this.bt_No.Click += new System.EventHandler(this.bt_No_Click);
            // 
            // bt_Ok
            // 
            this.bt_Ok.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_Ok.Location = new System.Drawing.Point(569, 9);
            this.bt_Ok.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Ok.Name = "bt_Ok";
            this.bt_Ok.Size = new System.Drawing.Size(100, 29);
            this.bt_Ok.TabIndex = 0;
            this.bt_Ok.Text = "确定";
            this.bt_Ok.UseVisualStyleBackColor = true;
            this.bt_Ok.Click += new System.EventHandler(this.bt_Ok_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(682, 403);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(682, 403);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_FileName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.chk_Mouse);
            this.groupBox1.Controls.Add(this.chk_Key);
            this.groupBox1.Controls.Add(this.tb_Time);
            this.groupBox1.Controls.Add(this.lbl_Time);
            this.groupBox1.Controls.Add(this.tb_SavePath);
            this.groupBox1.Controls.Add(this.lbl_SavePath);
            this.groupBox1.Controls.Add(this.rad_ManualSave);
            this.groupBox1.Controls.Add(this.rad_AutoSave);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(333, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "保存选项";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "文件名：";
            // 
            // tb_FileName
            // 
            this.tb_FileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tb_FileName.Enabled = false;
            this.tb_FileName.Location = new System.Drawing.Point(136, 48);
            this.tb_FileName.Margin = new System.Windows.Forms.Padding(4);
            this.tb_FileName.Name = "tb_FileName";
            this.tb_FileName.Size = new System.Drawing.Size(132, 25);
            this.tb_FileName.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 152);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "保存项：";
            // 
            // chk_Mouse
            // 
            this.chk_Mouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.chk_Mouse.AutoSize = true;
            this.chk_Mouse.Enabled = false;
            this.chk_Mouse.Location = new System.Drawing.Point(225, 152);
            this.chk_Mouse.Margin = new System.Windows.Forms.Padding(4);
            this.chk_Mouse.Name = "chk_Mouse";
            this.chk_Mouse.Size = new System.Drawing.Size(59, 19);
            this.chk_Mouse.TabIndex = 7;
            this.chk_Mouse.Text = "鼠标";
            this.chk_Mouse.UseVisualStyleBackColor = true;
            // 
            // chk_Key
            // 
            this.chk_Key.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.chk_Key.AutoSize = true;
            this.chk_Key.Enabled = false;
            this.chk_Key.Location = new System.Drawing.Point(136, 151);
            this.chk_Key.Margin = new System.Windows.Forms.Padding(4);
            this.chk_Key.Name = "chk_Key";
            this.chk_Key.Size = new System.Drawing.Size(59, 19);
            this.chk_Key.TabIndex = 6;
            this.chk_Key.Text = "键盘";
            this.chk_Key.UseVisualStyleBackColor = true;
            // 
            // tb_Time
            // 
            this.tb_Time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tb_Time.Enabled = false;
            this.tb_Time.Location = new System.Drawing.Point(136, 115);
            this.tb_Time.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Time.Name = "tb_Time";
            this.tb_Time.Size = new System.Drawing.Size(132, 25);
            this.tb_Time.TabIndex = 5;
            // 
            // lbl_Time
            // 
            this.lbl_Time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Location = new System.Drawing.Point(4, 119);
            this.lbl_Time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(128, 15);
            this.lbl_Time.TabIndex = 4;
            this.lbl_Time.Text = "保存间隔(毫秒)：";
            // 
            // tb_SavePath
            // 
            this.tb_SavePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tb_SavePath.Enabled = false;
            this.tb_SavePath.Location = new System.Drawing.Point(136, 81);
            this.tb_SavePath.Margin = new System.Windows.Forms.Padding(4);
            this.tb_SavePath.Name = "tb_SavePath";
            this.tb_SavePath.Size = new System.Drawing.Size(191, 25);
            this.tb_SavePath.TabIndex = 3;
            this.tb_SavePath.Click += new System.EventHandler(this.tb_SavePath_Click);
            // 
            // lbl_SavePath
            // 
            this.lbl_SavePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_SavePath.AutoSize = true;
            this.lbl_SavePath.Location = new System.Drawing.Point(32, 85);
            this.lbl_SavePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SavePath.Name = "lbl_SavePath";
            this.lbl_SavePath.Size = new System.Drawing.Size(82, 15);
            this.lbl_SavePath.TabIndex = 2;
            this.lbl_SavePath.Text = "保存目录：";
            // 
            // rad_ManualSave
            // 
            this.rad_ManualSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rad_ManualSave.AutoSize = true;
            this.rad_ManualSave.Checked = true;
            this.rad_ManualSave.Location = new System.Drawing.Point(196, 25);
            this.rad_ManualSave.Margin = new System.Windows.Forms.Padding(4);
            this.rad_ManualSave.Name = "rad_ManualSave";
            this.rad_ManualSave.Size = new System.Drawing.Size(88, 19);
            this.rad_ManualSave.TabIndex = 1;
            this.rad_ManualSave.TabStop = true;
            this.rad_ManualSave.Text = "手动保存";
            this.rad_ManualSave.UseVisualStyleBackColor = true;
            this.rad_ManualSave.CheckedChanged += new System.EventHandler(this.rad_ManualSave_CheckedChanged);
            // 
            // rad_AutoSave
            // 
            this.rad_AutoSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rad_AutoSave.AutoSize = true;
            this.rad_AutoSave.Location = new System.Drawing.Point(34, 25);
            this.rad_AutoSave.Margin = new System.Windows.Forms.Padding(4);
            this.rad_AutoSave.Name = "rad_AutoSave";
            this.rad_AutoSave.Size = new System.Drawing.Size(88, 19);
            this.rad_AutoSave.TabIndex = 0;
            this.rad_AutoSave.Text = "自动保存";
            this.rad_AutoSave.UseVisualStyleBackColor = true;
            this.rad_AutoSave.CheckedChanged += new System.EventHandler(this.rad_AutoSave_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chk_Hide);
            this.groupBox2.Controls.Add(this.chk_Prompt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lbl_Key);
            this.groupBox2.Controls.Add(this.tb_SetKey);
            this.groupBox2.Controls.Add(this.lbl_SetKey);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(345, 205);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(333, 194);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "隐藏和关闭";
            // 
            // chk_Hide
            // 
            this.chk_Hide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.chk_Hide.AutoSize = true;
            this.chk_Hide.Checked = true;
            this.chk_Hide.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Hide.Location = new System.Drawing.Point(32, 56);
            this.chk_Hide.Margin = new System.Windows.Forms.Padding(4);
            this.chk_Hide.Name = "chk_Hide";
            this.chk_Hide.Size = new System.Drawing.Size(284, 19);
            this.chk_Hide.TabIndex = 7;
            this.chk_Hide.Text = "隐藏窗口时隐藏任务栏通知栏所有图标";
            this.chk_Hide.UseVisualStyleBackColor = true;
            // 
            // chk_Prompt
            // 
            this.chk_Prompt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.chk_Prompt.AutoSize = true;
            this.chk_Prompt.Checked = true;
            this.chk_Prompt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Prompt.Location = new System.Drawing.Point(32, 84);
            this.chk_Prompt.Margin = new System.Windows.Forms.Padding(4);
            this.chk_Prompt.Name = "chk_Prompt";
            this.chk_Prompt.Size = new System.Drawing.Size(209, 19);
            this.chk_Prompt.TabIndex = 6;
            this.chk_Prompt.Text = "关闭主面板时显示关闭提示";
            this.chk_Prompt.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(8, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "按F1查看帮助";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl_Key
            // 
            this.lbl_Key.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_Key.AutoSize = true;
            this.lbl_Key.Location = new System.Drawing.Point(178, 28);
            this.lbl_Key.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Key.Name = "lbl_Key";
            this.lbl_Key.Size = new System.Drawing.Size(47, 15);
            this.lbl_Key.TabIndex = 4;
            this.lbl_Key.Text = "Alt+A";
            this.lbl_Key.DoubleClick += new System.EventHandler(this.lbl_Key_DoubleClick);
            // 
            // tb_SetKey
            // 
            this.tb_SetKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tb_SetKey.Enabled = false;
            this.tb_SetKey.Location = new System.Drawing.Point(172, 22);
            this.tb_SetKey.Margin = new System.Windows.Forms.Padding(4);
            this.tb_SetKey.Name = "tb_SetKey";
            this.tb_SetKey.Size = new System.Drawing.Size(155, 25);
            this.tb_SetKey.TabIndex = 3;
            // 
            // lbl_SetKey
            // 
            this.lbl_SetKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_SetKey.AutoSize = true;
            this.lbl_SetKey.Location = new System.Drawing.Point(4, 28);
            this.lbl_SetKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SetKey.Name = "lbl_SetKey";
            this.lbl_SetKey.Size = new System.Drawing.Size(157, 15);
            this.lbl_SetKey.TabIndex = 2;
            this.lbl_SetKey.Text = "双击设置隐藏快捷键：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rad_No);
            this.groupBox3.Controls.Add(this.rad_Yes);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(4, 205);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(333, 194);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "保存后是否清除输出面板";
            // 
            // rad_No
            // 
            this.rad_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rad_No.AutoSize = true;
            this.rad_No.Location = new System.Drawing.Point(152, 24);
            this.rad_No.Margin = new System.Windows.Forms.Padding(4);
            this.rad_No.Name = "rad_No";
            this.rad_No.Size = new System.Drawing.Size(43, 19);
            this.rad_No.TabIndex = 1;
            this.rad_No.Text = "否";
            this.rad_No.UseVisualStyleBackColor = true;
            // 
            // rad_Yes
            // 
            this.rad_Yes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rad_Yes.AutoSize = true;
            this.rad_Yes.Checked = true;
            this.rad_Yes.Location = new System.Drawing.Point(34, 25);
            this.rad_Yes.Margin = new System.Windows.Forms.Padding(4);
            this.rad_Yes.Name = "rad_Yes";
            this.rad_Yes.Size = new System.Drawing.Size(43, 19);
            this.rad_Yes.TabIndex = 0;
            this.rad_Yes.TabStop = true;
            this.rad_Yes.Text = "是";
            this.rad_Yes.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chk_HideRun);
            this.groupBox4.Controls.Add(this.chk_BootRun);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(344, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(335, 195);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "运行";
            // 
            // chk_HideRun
            // 
            this.chk_HideRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.chk_HideRun.AutoSize = true;
            this.chk_HideRun.Location = new System.Drawing.Point(33, 55);
            this.chk_HideRun.Margin = new System.Windows.Forms.Padding(4);
            this.chk_HideRun.Name = "chk_HideRun";
            this.chk_HideRun.Size = new System.Drawing.Size(134, 19);
            this.chk_HideRun.TabIndex = 12;
            this.chk_HideRun.Text = "启动时隐藏运行";
            this.chk_HideRun.UseVisualStyleBackColor = true;
            // 
            // chk_BootRun
            // 
            this.chk_BootRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.chk_BootRun.AutoSize = true;
            this.chk_BootRun.Location = new System.Drawing.Point(33, 27);
            this.chk_BootRun.Margin = new System.Windows.Forms.Padding(4);
            this.chk_BootRun.Name = "chk_BootRun";
            this.chk_BootRun.Size = new System.Drawing.Size(89, 19);
            this.chk_BootRun.TabIndex = 11;
            this.chk_BootRun.Text = "开机启动";
            this.chk_BootRun.UseVisualStyleBackColor = true;
            this.chk_BootRun.CheckedChanged += new System.EventHandler(this.chk_BootRun_CheckedChanged);
            // 
            // SetFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 451);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SetFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SetFrm_FormClosing);
            this.Load += new System.EventHandler(this.SetFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_No;
        private System.Windows.Forms.Button bt_Ok;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_Key;
        private System.Windows.Forms.TextBox tb_SetKey;
        private System.Windows.Forms.Label lbl_SetKey;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_SavePath;
        private System.Windows.Forms.Label lbl_SavePath;
        private System.Windows.Forms.RadioButton rad_ManualSave;
        private System.Windows.Forms.RadioButton rad_AutoSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_Time;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rad_No;
        private System.Windows.Forms.RadioButton rad_Yes;
        public System.Windows.Forms.CheckBox chk_Mouse;
        public System.Windows.Forms.CheckBox chk_Key;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_FileName;
        private System.Windows.Forms.CheckBox chk_Prompt;
        private System.Windows.Forms.CheckBox chk_Hide;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.CheckBox chk_HideRun;
        public System.Windows.Forms.CheckBox chk_BootRun;
    }
}