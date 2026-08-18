namespace safety_management
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            lbl_humi = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label2 = new Label();
            chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label1 = new Label();
            lbl_temp = new Label();
            groupBox2 = new GroupBox();
            pictureBox2 = new PictureBox();
            groupBox4 = new GroupBox();
            pictureBox1 = new PictureBox();
            btn_stop = new Button();
            btn_restart = new Button();
            imageList1 = new ImageList(components);
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            tbx_comState = new TextBox();
            cbx_ports = new ComboBox();
            btn_connect = new Button();
            btn_close = new Button();
            label8 = new Label();
            txb_recieve = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbl_humi);
            groupBox1.Controls.Add(chart1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(chart2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lbl_temp);
            groupBox1.Font = new Font("나눔고딕", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            groupBox1.Location = new Point(327, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(353, 525);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "현재 온습도";
            // 
            // lbl_humi
            // 
            lbl_humi.AutoSize = true;
            lbl_humi.Font = new Font("나눔고딕", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lbl_humi.ForeColor = Color.Black;
            lbl_humi.Location = new Point(261, 392);
            lbl_humi.Name = "lbl_humi";
            lbl_humi.Size = new Size(67, 26);
            lbl_humi.TabIndex = 2;
            lbl_humi.Text = "0(%)";
            // 
            // chart1
            // 
            chart1.BackColor = Color.LightSteelBlue;
            chart1.BorderlineColor = Color.Gray;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            chart1.Location = new Point(6, 50);
            chart1.Name = "chart1";
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = Color.Red;
            series1.Name = "Temperature";
            series1.YValuesPerPoint = 2;
            chart1.Series.Add(series1);
            chart1.Size = new Size(249, 225);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(224, 224, 224);
            label2.Font = new Font("나눔고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label2.Location = new Point(261, 357);
            label2.Name = "label2";
            label2.Size = new Size(84, 23);
            label2.TabIndex = 1;
            label2.Text = "습도(%)";
            // 
            // chart2
            // 
            chart2.BackColor = Color.LightSteelBlue;
            chart2.BorderlineColor = Color.Gray;
            chartArea2.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea2);
            chart2.Location = new Point(6, 294);
            chart2.Name = "chart2";
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = Color.Blue;
            series2.Name = "humidity";
            chart2.Series.Add(series2);
            chart2.Size = new Size(249, 225);
            chart2.TabIndex = 0;
            chart2.Text = "chart1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(224, 224, 224);
            label1.Font = new Font("나눔고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(261, 120);
            label1.Name = "label1";
            label1.Size = new Size(78, 23);
            label1.TabIndex = 1;
            label1.Text = "온도(℃)";
            // 
            // lbl_temp
            // 
            lbl_temp.AutoSize = true;
            lbl_temp.Font = new Font("나눔고딕 ExtraBold", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lbl_temp.ForeColor = Color.Black;
            lbl_temp.Location = new Point(261, 155);
            lbl_temp.Name = "lbl_temp";
            lbl_temp.Size = new Size(60, 26);
            lbl_temp.TabIndex = 2;
            lbl_temp.Text = "0(℃)";
            lbl_temp.Click += label3_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Font = new Font("나눔고딕", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            groupBox2.Location = new Point(686, 249);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(310, 220);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "시스템 동작 여부";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(61, 35);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(197, 179);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(pictureBox1);
            groupBox4.Font = new Font("나눔고딕", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            groupBox4.Location = new Point(686, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(310, 220);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "화재 상태 여부";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(61, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 179);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btn_stop
            // 
            btn_stop.Font = new Font("나눔고딕", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btn_stop.Location = new Point(686, 475);
            btn_stop.Name = "btn_stop";
            btn_stop.Size = new Size(150, 62);
            btn_stop.TabIndex = 9;
            btn_stop.Text = "동작 정지";
            btn_stop.UseVisualStyleBackColor = true;
            btn_stop.Click += btn_stop_Click;
            // 
            // btn_restart
            // 
            btn_restart.Font = new Font("나눔고딕", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btn_restart.Location = new Point(846, 475);
            btn_restart.Name = "btn_restart";
            btn_restart.Size = new Size(150, 62);
            btn_restart.TabIndex = 10;
            btn_restart.Text = "동작 재개";
            btn_restart.UseVisualStyleBackColor = true;
            btn_restart.Click += btn_restart_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Prohibition.png");
            imageList1.Images.SetKeyName(1, "Fire.png");
            imageList1.Images.SetKeyName(2, "Normal.png");
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("나눔고딕", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label5.Location = new Point(97, 12);
            label5.Name = "label5";
            label5.Size = new Size(119, 32);
            label5.TabIndex = 12;
            label5.Text = "Port연결";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("나눔고딕", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label6.Location = new Point(40, 62);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 13;
            label6.Text = "포트 :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("나눔고딕", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label7.Location = new Point(3, 94);
            label7.Name = "label7";
            label7.Size = new Size(88, 20);
            label7.TabIndex = 13;
            label7.Text = "연결 상태 :";
            // 
            // tbx_comState
            // 
            tbx_comState.Location = new Point(97, 91);
            tbx_comState.Name = "tbx_comState";
            tbx_comState.Size = new Size(125, 27);
            tbx_comState.TabIndex = 14;
            // 
            // cbx_ports
            // 
            cbx_ports.FormattingEnabled = true;
            cbx_ports.Location = new Point(97, 54);
            cbx_ports.Name = "cbx_ports";
            cbx_ports.Size = new Size(125, 28);
            cbx_ports.TabIndex = 15;
            // 
            // btn_connect
            // 
            btn_connect.Location = new Point(233, 53);
            btn_connect.Name = "btn_connect";
            btn_connect.Size = new Size(75, 29);
            btn_connect.TabIndex = 16;
            btn_connect.Text = "연결";
            btn_connect.UseVisualStyleBackColor = true;
            btn_connect.Click += btn_connect_Click;
            // 
            // btn_close
            // 
            btn_close.Location = new Point(233, 91);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(75, 29);
            btn_close.TabIndex = 17;
            btn_close.Text = "해제";
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("나눔고딕", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label8.Location = new Point(3, 146);
            label8.Name = "label8";
            label8.Size = new Size(94, 20);
            label8.TabIndex = 13;
            label8.Text = "수신 데이터";
            // 
            // txb_recieve
            // 
            txb_recieve.Location = new Point(12, 169);
            txb_recieve.Multiline = true;
            txb_recieve.Name = "txb_recieve";
            txb_recieve.ScrollBars = ScrollBars.Vertical;
            txb_recieve.Size = new Size(296, 368);
            txb_recieve.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1031, 554);
            Controls.Add(txb_recieve);
            Controls.Add(btn_close);
            Controls.Add(btn_connect);
            Controls.Add(cbx_ports);
            Controls.Add(tbx_comState);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btn_restart);
            Controls.Add(btn_stop);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private Label label1;
        private Label lbl_temp;
        private Label lbl_humi;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private Button btn_stop;
        private Button btn_restart;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox tbx_comState;
        private ComboBox cbx_ports;
        private Button btn_connect;
        private Button btn_close;
        private Label label8;
        private TextBox txb_recieve;
    }
}
