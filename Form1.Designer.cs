namespace LED_Controller
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BOX_BAUDRATE = new System.Windows.Forms.ComboBox();
            this.BUTTON_CONNECT = new System.Windows.Forms.Button();
            this.BUTTON_DISCONNECT = new System.Windows.Forms.Button();
            this.BOX_COMPORTS = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BUTTON_SETWHITE = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BUTTON_BRIGHTNESSDEC = new System.Windows.Forms.Button();
            this.BUTTON_BRIGHTNESSINC = new System.Windows.Forms.Button();
            this.BUTTON_LEDOFF = new System.Windows.Forms.Button();
            this.BUTTON_LEDON = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel_lowerleft = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BUTTON_FADE = new System.Windows.Forms.Button();
            this.BUTTON_STROBE = new System.Windows.Forms.Button();
            this.BUTTON_FLASH = new System.Windows.Forms.Button();
            this.BUTTON_SMOOTH = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BUTTON_R5 = new System.Windows.Forms.Button();
            this.BUTTON_G5 = new System.Windows.Forms.Button();
            this.BUTTON_B4 = new System.Windows.Forms.Button();
            this.BUTTON_R = new System.Windows.Forms.Button();
            this.BUTTON_R1 = new System.Windows.Forms.Button();
            this.BUTTON_GREEN = new System.Windows.Forms.Button();
            this.BUTTON_G1 = new System.Windows.Forms.Button();
            this.BUTTON_R2 = new System.Windows.Forms.Button();
            this.BUTTON_G3 = new System.Windows.Forms.Button();
            this.BUTTON_R3 = new System.Windows.Forms.Button();
            this.BUTTON_G4 = new System.Windows.Forms.Button();
            this.BUTTON_B3 = new System.Windows.Forms.Button();
            this.BUTTON_B2 = new System.Windows.Forms.Button();
            this.BUTTON_B1 = new System.Windows.Forms.Button();
            this.BUTTON_B = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TEXTBOX_CONSOLE = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel_lowerleft.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(749, 607);
            this.splitContainer1.SplitterDistance = 132;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 112);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(289, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 47);
            this.label8.TabIndex = 8;
            this.label8.Text = "MENU";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.BOX_BAUDRATE);
            this.panel3.Controls.Add(this.BUTTON_CONNECT);
            this.panel3.Controls.Add(this.BUTTON_DISCONNECT);
            this.panel3.Controls.Add(this.BOX_COMPORTS);
            this.panel3.Location = new System.Drawing.Point(9, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(222, 100);
            this.panel3.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "BAUD RATE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM PORT:";
            // 
            // BOX_BAUDRATE
            // 
            this.BOX_BAUDRATE.FormattingEnabled = true;
            this.BOX_BAUDRATE.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.BOX_BAUDRATE.Location = new System.Drawing.Point(91, 36);
            this.BOX_BAUDRATE.Name = "BOX_BAUDRATE";
            this.BOX_BAUDRATE.Size = new System.Drawing.Size(121, 21);
            this.BOX_BAUDRATE.TabIndex = 2;
            this.BOX_BAUDRATE.SelectedIndex = 0;
            // 
            // BUTTON_CONNECT
            // 
            this.BUTTON_CONNECT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.BUTTON_CONNECT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BUTTON_CONNECT.Location = new System.Drawing.Point(131, 63);
            this.BUTTON_CONNECT.Name = "BUTTON_CONNECT";
            this.BUTTON_CONNECT.Size = new System.Drawing.Size(75, 23);
            this.BUTTON_CONNECT.TabIndex = 4;
            this.BUTTON_CONNECT.Text = "CONNECT";
            this.BUTTON_CONNECT.UseVisualStyleBackColor = false;
            this.BUTTON_CONNECT.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // BUTTON_DISCONNECT
            // 
            this.BUTTON_DISCONNECT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.BUTTON_DISCONNECT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BUTTON_DISCONNECT.Location = new System.Drawing.Point(34, 63);
            this.BUTTON_DISCONNECT.Name = "BUTTON_DISCONNECT";
            this.BUTTON_DISCONNECT.Size = new System.Drawing.Size(91, 23);
            this.BUTTON_DISCONNECT.TabIndex = 5;
            this.BUTTON_DISCONNECT.Text = "DISCONNECT";
            this.BUTTON_DISCONNECT.UseVisualStyleBackColor = false;
            this.BUTTON_DISCONNECT.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // BOX_COMPORTS
            // 
            this.BOX_COMPORTS.DisplayMember = "BOX_COMPORTS";
            this.BOX_COMPORTS.FormattingEnabled = true;
            this.BOX_COMPORTS.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6"});
            this.BOX_COMPORTS.SelectedIndex = 3;
            this.BOX_COMPORTS.Location = new System.Drawing.Point(91, 9);
            this.BOX_COMPORTS.Name = "BOX_COMPORTS";
            this.BOX_COMPORTS.Size = new System.Drawing.Size(121, 21);
            this.BOX_COMPORTS.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.BUTTON_SETWHITE);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.BUTTON_BRIGHTNESSDEC);
            this.panel2.Controls.Add(this.BUTTON_BRIGHTNESSINC);
            this.panel2.Controls.Add(this.BUTTON_LEDOFF);
            this.panel2.Controls.Add(this.BUTTON_LEDON);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(476, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 100);
            this.panel2.TabIndex = 6;
            // 
            // BUTTON_SETWHITE
            // 
            this.BUTTON_SETWHITE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.BUTTON_SETWHITE.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BUTTON_SETWHITE.Location = new System.Drawing.Point(91, 63);
            this.BUTTON_SETWHITE.Name = "BUTTON_SETWHITE";
            this.BUTTON_SETWHITE.Size = new System.Drawing.Size(75, 23);
            this.BUTTON_SETWHITE.TabIndex = 7;
            this.BUTTON_SETWHITE.Text = "WHITE";
            this.BUTTON_SETWHITE.UseVisualStyleBackColor = false;
            this.BUTTON_SETWHITE.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "SET:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "BRIGHTNESS:";
            // 
            // BUTTON_BRIGHTNESSDEC
            // 
            this.BUTTON_BRIGHTNESSDEC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.BUTTON_BRIGHTNESSDEC.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BUTTON_BRIGHTNESSDEC.Location = new System.Drawing.Point(91, 34);
            this.BUTTON_BRIGHTNESSDEC.Name = "BUTTON_BRIGHTNESSDEC";
            this.BUTTON_BRIGHTNESSDEC.Size = new System.Drawing.Size(75, 23);
            this.BUTTON_BRIGHTNESSDEC.TabIndex = 4;
            this.BUTTON_BRIGHTNESSDEC.Text = "-";
            this.BUTTON_BRIGHTNESSDEC.UseVisualStyleBackColor = false;
            this.BUTTON_BRIGHTNESSDEC.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // BUTTON_BRIGHTNESSINC
            // 
            this.BUTTON_BRIGHTNESSINC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.BUTTON_BRIGHTNESSINC.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BUTTON_BRIGHTNESSINC.Location = new System.Drawing.Point(172, 34);
            this.BUTTON_BRIGHTNESSINC.Name = "BUTTON_BRIGHTNESSINC";
            this.BUTTON_BRIGHTNESSINC.Size = new System.Drawing.Size(75, 23);
            this.BUTTON_BRIGHTNESSINC.TabIndex = 3;
            this.BUTTON_BRIGHTNESSINC.Text = "+";
            this.BUTTON_BRIGHTNESSINC.UseVisualStyleBackColor = false;
            this.BUTTON_BRIGHTNESSINC.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // BUTTON_LEDOFF
            // 
            this.BUTTON_LEDOFF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.BUTTON_LEDOFF.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BUTTON_LEDOFF.Location = new System.Drawing.Point(91, 5);
            this.BUTTON_LEDOFF.Name = "BUTTON_LEDOFF";
            this.BUTTON_LEDOFF.Size = new System.Drawing.Size(75, 23);
            this.BUTTON_LEDOFF.TabIndex = 2;
            this.BUTTON_LEDOFF.Text = "OFF";
            this.BUTTON_LEDOFF.UseVisualStyleBackColor = false;
            this.BUTTON_LEDOFF.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // BUTTON_LEDON
            // 
            this.BUTTON_LEDON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.BUTTON_LEDON.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BUTTON_LEDON.Location = new System.Drawing.Point(172, 5);
            this.BUTTON_LEDON.Name = "BUTTON_LEDON";
            this.BUTTON_LEDON.Size = new System.Drawing.Size(75, 23);
            this.BUTTON_LEDON.TabIndex = 1;
            this.BUTTON_LEDON.Text = "ON";
            this.BUTTON_LEDON.UseVisualStyleBackColor = false;
            this.BUTTON_LEDON.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "LED:";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer2.Panel1.Controls.Add(this.panel_lowerleft);
            this.splitContainer2.Panel1.ForeColor = System.Drawing.Color.Transparent;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panel4);
            this.splitContainer2.Size = new System.Drawing.Size(749, 471);
            this.splitContainer2.SplitterDistance = 395;
            this.splitContainer2.TabIndex = 0;
            // 
            // panel_lowerleft
            // 
            this.panel_lowerleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.panel_lowerleft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_lowerleft.Controls.Add(this.tableLayoutPanel2);
            this.panel_lowerleft.Controls.Add(this.label4);
            this.panel_lowerleft.Controls.Add(this.label5);
            this.panel_lowerleft.Controls.Add(this.tableLayoutPanel1);
            this.panel_lowerleft.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_lowerleft.Location = new System.Drawing.Point(12, 3);
            this.panel_lowerleft.Name = "panel_lowerleft";
            this.panel_lowerleft.Size = new System.Drawing.Size(380, 446);
            this.panel_lowerleft.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.BUTTON_FADE, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.BUTTON_STROBE, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BUTTON_FLASH, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BUTTON_SMOOTH, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 340);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(364, 92);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // BUTTON_FADE
            // 
            this.BUTTON_FADE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.BUTTON_FADE.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BUTTON_FADE.Location = new System.Drawing.Point(185, 3);
            this.BUTTON_FADE.Name = "BUTTON_FADE";
            this.BUTTON_FADE.Size = new System.Drawing.Size(85, 86);
            this.BUTTON_FADE.TabIndex = 2;
            this.BUTTON_FADE.TabStop = false;
            this.BUTTON_FADE.Text = "FADE";
            this.BUTTON_FADE.UseVisualStyleBackColor = false;
            this.BUTTON_FADE.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // BUTTON_STROBE
            // 
            this.BUTTON_STROBE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.BUTTON_STROBE.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BUTTON_STROBE.Location = new System.Drawing.Point(94, 3);
            this.BUTTON_STROBE.Name = "BUTTON_STROBE";
            this.BUTTON_STROBE.Size = new System.Drawing.Size(85, 86);
            this.BUTTON_STROBE.TabIndex = 1;
            this.BUTTON_STROBE.Text = "STROBE";
            this.BUTTON_STROBE.UseVisualStyleBackColor = false;
            this.BUTTON_STROBE.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // BUTTON_FLASH
            // 
            this.BUTTON_FLASH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.BUTTON_FLASH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BUTTON_FLASH.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BUTTON_FLASH.FlatAppearance.BorderSize = 5;
            this.BUTTON_FLASH.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BUTTON_FLASH.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON_FLASH.ForeColor = System.Drawing.Color.White;
            this.BUTTON_FLASH.Location = new System.Drawing.Point(3, 3);
            this.BUTTON_FLASH.Name = "BUTTON_FLASH";
            this.BUTTON_FLASH.Size = new System.Drawing.Size(85, 86);
            this.BUTTON_FLASH.TabIndex = 0;
            this.BUTTON_FLASH.Text = "FLASH";
            this.BUTTON_FLASH.UseVisualStyleBackColor = false;
            this.BUTTON_FLASH.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // BUTTON_SMOOTH
            // 
            this.BUTTON_SMOOTH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.BUTTON_SMOOTH.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BUTTON_SMOOTH.Location = new System.Drawing.Point(276, 3);
            this.BUTTON_SMOOTH.Name = "BUTTON_SMOOTH";
            this.BUTTON_SMOOTH.Size = new System.Drawing.Size(85, 86);
            this.BUTTON_SMOOTH.TabIndex = 3;
            this.BUTTON_SMOOTH.Text = "SMOOTH";
            this.BUTTON_SMOOTH.UseVisualStyleBackColor = false;
            this.BUTTON_SMOOTH.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(142, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "COLOR CONTROL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(148, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "MISC CONTROL";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.BUTTON_R5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.BUTTON_G5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.BUTTON_B4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.BUTTON_R, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BUTTON_R1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BUTTON_GREEN, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BUTTON_G1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.BUTTON_R2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.BUTTON_G3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.BUTTON_R3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.BUTTON_G4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.BUTTON_B3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.BUTTON_B2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.BUTTON_B1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.BUTTON_B, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(364, 243);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // BUTTON_R5
            // 
            this.BUTTON_R5.BackColor = System.Drawing.Color.Yellow;
            this.BUTTON_R5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUTTON_R5.ForeColor = System.Drawing.Color.Yellow;
            this.BUTTON_R5.Location = new System.Drawing.Point(3, 195);
            this.BUTTON_R5.Name = "BUTTON_R5";
            this.BUTTON_R5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BUTTON_R5.Size = new System.Drawing.Size(115, 41);
            this.BUTTON_R5.TabIndex = 15;
            this.BUTTON_R5.Tag = "RED4";
            this.BUTTON_R5.Text = "RED4";
            this.BUTTON_R5.UseVisualStyleBackColor = false;
            this.BUTTON_R5.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // BUTTON_G5
            // 
            this.BUTTON_G5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BUTTON_G5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUTTON_G5.Location = new System.Drawing.Point(124, 195);
            this.BUTTON_G5.Name = "BUTTON_G5";
            this.BUTTON_G5.Size = new System.Drawing.Size(115, 41);
            this.BUTTON_G5.TabIndex = 14;
            this.BUTTON_G5.Text = "GREEN4";
            this.BUTTON_G5.UseVisualStyleBackColor = false;
            this.BUTTON_G5.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // BUTTON_B4
            // 
            this.BUTTON_B4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BUTTON_B4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUTTON_B4.Location = new System.Drawing.Point(245, 195);
            this.BUTTON_B4.Name = "BUTTON_B4";
            this.BUTTON_B4.Size = new System.Drawing.Size(115, 41);
            this.BUTTON_B4.TabIndex = 13;
            this.BUTTON_B4.Text = "BLUE4";
            this.BUTTON_B4.UseVisualStyleBackColor = false;
            this.BUTTON_B4.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // BUTTON_R
            // 
            this.BUTTON_R.BackColor = System.Drawing.Color.Red;
            this.BUTTON_R.FlatAppearance.BorderSize = 0;
            this.BUTTON_R.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUTTON_R.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON_R.ForeColor = System.Drawing.Color.Red;
            this.BUTTON_R.Location = new System.Drawing.Point(3, 3);
            this.BUTTON_R.Name = "BUTTON_R";
            this.BUTTON_R.Size = new System.Drawing.Size(115, 41);
            this.BUTTON_R.TabIndex = 1;
            this.BUTTON_R.Tag = "RED";
            this.BUTTON_R.Text = "RED";
            this.BUTTON_R.UseVisualStyleBackColor = false;
            this.BUTTON_R.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // BUTTON_R1
            // 
            this.BUTTON_R1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BUTTON_R1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUTTON_R1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BUTTON_R1.Location = new System.Drawing.Point(3, 51);
            this.BUTTON_R1.Name = "BUTTON_R1";
            this.BUTTON_R1.Size = new System.Drawing.Size(115, 41);
            this.BUTTON_R1.TabIndex = 4;
            this.BUTTON_R1.Tag = "RED1";
            this.BUTTON_R1.Text = "RED1";
            this.BUTTON_R1.UseVisualStyleBackColor = false;
            this.BUTTON_R1.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // BUTTON_GREEN
            // 
            this.BUTTON_GREEN.BackColor = System.Drawing.Color.Lime;
            this.BUTTON_GREEN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUTTON_GREEN.Location = new System.Drawing.Point(124, 3);
            this.BUTTON_GREEN.Name = "BUTTON_GREEN";
            this.BUTTON_GREEN.Size = new System.Drawing.Size(115, 41);
            this.BUTTON_GREEN.TabIndex = 3;
            this.BUTTON_GREEN.Text = "GREEN";
            this.BUTTON_GREEN.UseVisualStyleBackColor = false;
            this.BUTTON_GREEN.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // BUTTON_G1
            // 
            this.BUTTON_G1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BUTTON_G1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUTTON_G1.Location = new System.Drawing.Point(124, 51);
            this.BUTTON_G1.Name = "BUTTON_G1";
            this.BUTTON_G1.Size = new System.Drawing.Size(115, 41);
            this.BUTTON_G1.TabIndex = 2;
            this.BUTTON_G1.Text = "GREEN1";
            this.BUTTON_G1.UseVisualStyleBackColor = false;
            this.BUTTON_G1.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // BUTTON_R2
            // 
            this.BUTTON_R2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BUTTON_R2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUTTON_R2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BUTTON_R2.Location = new System.Drawing.Point(3, 99);
            this.BUTTON_R2.Name = "BUTTON_R2";
            this.BUTTON_R2.Size = new System.Drawing.Size(115, 41);
            this.BUTTON_R2.TabIndex = 5;
            this.BUTTON_R2.Tag = "RED2";
            this.BUTTON_R2.Text = "RED2";
            this.BUTTON_R2.UseVisualStyleBackColor = false;
            this.BUTTON_R2.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // BUTTON_G3
            // 
            this.BUTTON_G3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BUTTON_G3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUTTON_G3.Location = new System.Drawing.Point(124, 99);
            this.BUTTON_G3.Name = "BUTTON_G3";
            this.BUTTON_G3.Size = new System.Drawing.Size(115, 41);
            this.BUTTON_G3.TabIndex = 6;
            this.BUTTON_G3.Text = "GREEN2";
            this.BUTTON_G3.UseVisualStyleBackColor = false;
            this.BUTTON_G3.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // BUTTON_R3
            // 
            this.BUTTON_R3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BUTTON_R3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUTTON_R3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BUTTON_R3.Location = new System.Drawing.Point(3, 147);
            this.BUTTON_R3.Name = "BUTTON_R3";
            this.BUTTON_R3.Size = new System.Drawing.Size(115, 41);
            this.BUTTON_R3.TabIndex = 7;
            this.BUTTON_R3.Tag = "RED3";
            this.BUTTON_R3.Text = "RED3";
            this.BUTTON_R3.UseVisualStyleBackColor = false;
            this.BUTTON_R3.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // BUTTON_G4
            // 
            this.BUTTON_G4.BackColor = System.Drawing.Color.Teal;
            this.BUTTON_G4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUTTON_G4.Location = new System.Drawing.Point(124, 147);
            this.BUTTON_G4.Name = "BUTTON_G4";
            this.BUTTON_G4.Size = new System.Drawing.Size(115, 41);
            this.BUTTON_G4.TabIndex = 9;
            this.BUTTON_G4.Text = "GREEN3";
            this.BUTTON_G4.UseVisualStyleBackColor = false;
            this.BUTTON_G4.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // BUTTON_B3
            // 
            this.BUTTON_B3.BackColor = System.Drawing.Color.Magenta;
            this.BUTTON_B3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUTTON_B3.Location = new System.Drawing.Point(245, 147);
            this.BUTTON_B3.Name = "BUTTON_B3";
            this.BUTTON_B3.Size = new System.Drawing.Size(115, 41);
            this.BUTTON_B3.TabIndex = 8;
            this.BUTTON_B3.Text = "BLUE3";
            this.BUTTON_B3.UseVisualStyleBackColor = false;
            this.BUTTON_B3.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // BUTTON_B2
            // 
            this.BUTTON_B2.BackColor = System.Drawing.Color.Purple;
            this.BUTTON_B2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUTTON_B2.Location = new System.Drawing.Point(245, 99);
            this.BUTTON_B2.Name = "BUTTON_B2";
            this.BUTTON_B2.Size = new System.Drawing.Size(115, 41);
            this.BUTTON_B2.TabIndex = 10;
            this.BUTTON_B2.Text = "BLUE2";
            this.BUTTON_B2.UseVisualStyleBackColor = false;
            this.BUTTON_B2.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // BUTTON_B1
            // 
            this.BUTTON_B1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BUTTON_B1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUTTON_B1.Location = new System.Drawing.Point(245, 51);
            this.BUTTON_B1.Name = "BUTTON_B1";
            this.BUTTON_B1.Size = new System.Drawing.Size(115, 41);
            this.BUTTON_B1.TabIndex = 11;
            this.BUTTON_B1.Text = "BLUE1";
            this.BUTTON_B1.UseVisualStyleBackColor = false;
            this.BUTTON_B1.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // BUTTON_B
            // 
            this.BUTTON_B.BackColor = System.Drawing.Color.Blue;
            this.BUTTON_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUTTON_B.Location = new System.Drawing.Point(245, 3);
            this.BUTTON_B.Name = "BUTTON_B";
            this.BUTTON_B.Size = new System.Drawing.Size(115, 41);
            this.BUTTON_B.TabIndex = 12;
            this.BUTTON_B.Text = "BLUE";
            this.BUTTON_B.UseVisualStyleBackColor = false;
            this.BUTTON_B.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.TEXTBOX_CONSOLE);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(335, 456);
            this.panel4.TabIndex = 1;
            // 
            // TEXTBOX_CONSOLE
            // 
            this.TEXTBOX_CONSOLE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.TEXTBOX_CONSOLE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TEXTBOX_CONSOLE.Cursor = System.Windows.Forms.Cursors.No;
            this.TEXTBOX_CONSOLE.ForeColor = System.Drawing.Color.White;
            this.TEXTBOX_CONSOLE.Location = new System.Drawing.Point(-2, -1);
            this.TEXTBOX_CONSOLE.Multiline = true;
            this.TEXTBOX_CONSOLE.Name = "TEXTBOX_CONSOLE";
            this.TEXTBOX_CONSOLE.ReadOnly = true;
            this.TEXTBOX_CONSOLE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TEXTBOX_CONSOLE.Size = new System.Drawing.Size(346, 452);
            this.TEXTBOX_CONSOLE.TabIndex = 0;
            this.TEXTBOX_CONSOLE.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(749, 607);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Form1";
            this.Text = "LED ";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel_lowerleft.ResumeLayout(false);
            this.panel_lowerleft.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox BOX_COMPORTS;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BUTTON_CONNECT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox BOX_BAUDRATE;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button BUTTON_DISCONNECT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BUTTON_LEDOFF;
        private System.Windows.Forms.Button BUTTON_LEDON;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel_lowerleft;
        private System.Windows.Forms.Button BUTTON_SMOOTH;
        private System.Windows.Forms.Button BUTTON_FADE;
        private System.Windows.Forms.Button BUTTON_STROBE;
        private System.Windows.Forms.Button BUTTON_FLASH;
        private System.Windows.Forms.Button BUTTON_R5;
        private System.Windows.Forms.Button BUTTON_G5;
        private System.Windows.Forms.Button BUTTON_B4;
        private System.Windows.Forms.Button BUTTON_R;
        private System.Windows.Forms.Button BUTTON_R1;
        private System.Windows.Forms.Button BUTTON_GREEN;
        private System.Windows.Forms.Button BUTTON_G1;
        private System.Windows.Forms.Button BUTTON_R2;
        private System.Windows.Forms.Button BUTTON_G3;
        private System.Windows.Forms.Button BUTTON_R3;
        private System.Windows.Forms.Button BUTTON_G4;
        private System.Windows.Forms.Button BUTTON_B3;
        private System.Windows.Forms.Button BUTTON_B2;
        private System.Windows.Forms.Button BUTTON_B1;
        private System.Windows.Forms.Button BUTTON_B;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BUTTON_BRIGHTNESSDEC;
        private System.Windows.Forms.Button BUTTON_BRIGHTNESSINC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BUTTON_SETWHITE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox TEXTBOX_CONSOLE;
    }
}

