﻿namespace PressureTraverseCurve
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.YW = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Q = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.WC = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.WL = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TWF = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.THF = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PHF = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.YG = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.GLR = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.OM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.API = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.step1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.to1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.from = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.printbtn = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic);
            this.button1.Location = new System.Drawing.Point(152, 820);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "      illustrate";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(599, 37);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1297, 878);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            this.chart1.Paint += new System.Windows.Forms.PaintEventHandler(this.chart1_Paint);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(152, 900);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(248, 30);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Visible = false;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.YW);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.Q);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.WC);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.WL);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.TWF);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.THF);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.PHF);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.YG);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.GLR);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.OM);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.API);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.DO);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(31, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 586);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // YW
            // 
            this.YW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YW.Location = new System.Drawing.Point(378, 545);
            this.YW.Name = "YW";
            this.YW.Size = new System.Drawing.Size(109, 27);
            this.YW.TabIndex = 25;
            this.YW.Text = "1.05";
            this.YW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 544);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(247, 27);
            this.label14.TabIndex = 24;
            this.label14.Text = "Specific gravity of water (gw):";
            // 
            // Q
            // 
            this.Q.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q.Location = new System.Drawing.Point(378, 500);
            this.Q.Name = "Q";
            this.Q.Size = new System.Drawing.Size(109, 27);
            this.Q.TabIndex = 23;
            this.Q.Text = "30";
            this.Q.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 499);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(184, 27);
            this.label13.TabIndex = 22;
            this.label13.Text = "Interfacial tension (s):";
            // 
            // WC
            // 
            this.WC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WC.Location = new System.Drawing.Point(378, 456);
            this.WC.Name = "WC";
            this.WC.Size = new System.Drawing.Size(109, 27);
            this.WC.TabIndex = 21;
            this.WC.Text = "10";
            this.WC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 455);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 27);
            this.label12.TabIndex = 20;
            this.label12.Text = "Water cut (WC):";
            // 
            // WL
            // 
            this.WL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WL.Location = new System.Drawing.Point(380, 414);
            this.WL.Name = "WL";
            this.WL.Size = new System.Drawing.Size(109, 27);
            this.WL.TabIndex = 19;
            this.WL.Text = "758";
            this.WL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 413);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(233, 27);
            this.label11.TabIndex = 18;
            this.label11.Text = "Liquid production rate (qL):";
            // 
            // TWF
            // 
            this.TWF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TWF.Location = new System.Drawing.Point(380, 370);
            this.TWF.Name = "TWF";
            this.TWF.Size = new System.Drawing.Size(109, 27);
            this.TWF.TabIndex = 17;
            this.TWF.Text = "180";
            this.TWF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 369);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(341, 27);
            this.label10.TabIndex = 16;
            this.label10.Text = "Flowing temperature at tubing shoe (twf):";
            // 
            // THF
            // 
            this.THF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.THF.Location = new System.Drawing.Point(380, 327);
            this.THF.Name = "THF";
            this.THF.Size = new System.Drawing.Size(109, 27);
            this.THF.TabIndex = 15;
            this.THF.Text = "80";
            this.THF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(320, 27);
            this.label9.TabIndex = 14;
            this.label9.Text = "Flowing tubing head temperature (thf):";
            // 
            // PHF
            // 
            this.PHF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PHF.Location = new System.Drawing.Point(380, 284);
            this.PHF.Name = "PHF";
            this.PHF.Size = new System.Drawing.Size(109, 27);
            this.PHF.TabIndex = 13;
            this.PHF.Text = "200";
            this.PHF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(293, 27);
            this.label8.TabIndex = 12;
            this.label8.Text = "Flowing tubing head pressure (phf):";
            // 
            // YG
            // 
            this.YG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YG.Location = new System.Drawing.Point(380, 241);
            this.YG.Name = "YG";
            this.YG.Size = new System.Drawing.Size(109, 27);
            this.YG.TabIndex = 11;
            this.YG.Text = "0.7";
            this.YG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 27);
            this.label7.TabIndex = 10;
            this.label7.Text = "Gas specific gravity (yg):";
            // 
            // GLR
            // 
            this.GLR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GLR.Location = new System.Drawing.Point(380, 199);
            this.GLR.Name = "GLR";
            this.GLR.Size = new System.Drawing.Size(109, 27);
            this.GLR.TabIndex = 9;
            this.GLR.Text = "75";
            this.GLR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 27);
            this.label6.TabIndex = 8;
            this.label6.Text = "Production GLR (GLR):";
            // 
            // OM
            // 
            this.OM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OM.Location = new System.Drawing.Point(380, 157);
            this.OM.Name = "OM";
            this.OM.Size = new System.Drawing.Size(109, 27);
            this.OM.TabIndex = 7;
            this.OM.Text = "5";
            this.OM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "Oil viscosity (cp):";
            // 
            // API
            // 
            this.API.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.API.Location = new System.Drawing.Point(380, 109);
            this.API.Name = "API";
            this.API.Size = new System.Drawing.Size(109, 27);
            this.API.TabIndex = 5;
            this.API.Text = "40";
            this.API.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Oil gravity (API):";
            // 
            // TID
            // 
            this.TID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TID.Location = new System.Drawing.Point(380, 62);
            this.TID.Name = "TID";
            this.TID.Size = new System.Drawing.Size(109, 27);
            this.TID.TabIndex = 3;
            this.TID.Text = "1.995";
            this.TID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tubing inner diameter (dti):";
            // 
            // DO
            // 
            this.DO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DO.Location = new System.Drawing.Point(380, 18);
            this.DO.Name = "DO";
            this.DO.Size = new System.Drawing.Size(109, 27);
            this.DO.TabIndex = 1;
            this.DO.Text = "9700";
            this.DO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Depth";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(14, 40);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 25);
            this.label17.TabIndex = 37;
            this.label17.Text = "Step";
            // 
            // step1
            // 
            this.step1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.step1.Location = new System.Drawing.Point(78, 41);
            this.step1.Name = "step1";
            this.step1.Size = new System.Drawing.Size(93, 27);
            this.step1.TabIndex = 36;
            this.step1.Text = "100";
            this.step1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(179, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 18);
            this.label16.TabIndex = 35;
            this.label16.Text = "to";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // to1
            // 
            this.to1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to1.Location = new System.Drawing.Point(208, 11);
            this.to1.Name = "to1";
            this.to1.Size = new System.Drawing.Size(93, 27);
            this.to1.TabIndex = 34;
            this.to1.Text = "200";
            this.to1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 25);
            this.label15.TabIndex = 33;
            this.label15.Text = "From";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // from
            // 
            this.from.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from.Location = new System.Drawing.Point(78, 8);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(93, 27);
            this.from.TabIndex = 32;
            this.from.Text = "100";
            this.from.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Britannic Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label18.Location = new System.Drawing.Point(22, 37);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(509, 52);
            this.label18.TabIndex = 38;
            this.label18.Text = "Pressure Travers Curve";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.step1);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.to1);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.from);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Location = new System.Drawing.Point(123, 718);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 85);
            this.panel2.TabIndex = 40;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(326, 830);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // printbtn
            // 
            this.printbtn.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printbtn.Location = new System.Drawing.Point(1692, 921);
            this.printbtn.Name = "printbtn";
            this.printbtn.Size = new System.Drawing.Size(204, 52);
            this.printbtn.TabIndex = 44;
            this.printbtn.Text = "Print";
            this.printbtn.UseVisualStyleBackColor = true;
            this.printbtn.Visible = false;
            this.printbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 28);
            this.menuStrip1.TabIndex = 45;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem1});
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // printToolStripMenuItem1
            // 
            this.printToolStripMenuItem1.Name = "printToolStripMenuItem1";
            this.printToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.printToolStripMenuItem1.Text = "Print";
            this.printToolStripMenuItem1.Click += new System.EventHandler(this.printToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1924, 1010);
            this.Controls.Add(this.printbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pressure Traverse Curve";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox DO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox THF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PHF;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox YG;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox GLR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox OM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox API;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TWF;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox WL;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Q;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox WC;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox YW;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox step1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox to1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox from;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button printbtn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem1;
    }
}

