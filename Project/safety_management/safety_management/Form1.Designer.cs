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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            label4 = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label2 = new Label();
            chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label1 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            groupBox4 = new GroupBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            imageList1 = new ImageList(components);
            pictureBox2 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(chart1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(chart2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("나눔고딕", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(622, 525);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "현재 온습도";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("나눔고딕", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(441, 379);
            label4.Name = "label4";
            label4.Size = new Size(129, 43);
            label4.TabIndex = 2;
            label4.Text = "30(%)";
            // 
            // chart1
            // 
            chart1.BackColor = Color.LightSteelBlue;
            chart1.BorderlineColor = Color.Gray;
            chartArea3.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea3);
            chart1.Location = new Point(6, 37);
            chart1.Name = "chart1";
            series3.BorderWidth = 5;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = Color.Red;
            series3.Name = "Temperature";
            series3.YValuesPerPoint = 2;
            chart1.Series.Add(series3);
            chart1.Size = new Size(383, 225);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(224, 224, 224);
            label2.Font = new Font("나눔고딕", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label2.Location = new Point(404, 336);
            label2.Name = "label2";
            label2.Size = new Size(203, 32);
            label2.TabIndex = 1;
            label2.Text = "실시간 습도(%)";
            // 
            // chart2
            // 
            chart2.BackColor = Color.LightSteelBlue;
            chart2.BorderlineColor = Color.Gray;
            chartArea4.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea4);
            chart2.Location = new Point(6, 282);
            chart2.Name = "chart2";
            series4.BorderWidth = 5;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series4.Color = Color.Blue;
            series4.Name = "humidity";
            chart2.Series.Add(series4);
            chart2.Size = new Size(383, 225);
            chart2.TabIndex = 0;
            chart2.Text = "chart1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(224, 224, 224);
            label1.Font = new Font("나눔고딕", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(404, 82);
            label1.Name = "label1";
            label1.Size = new Size(194, 32);
            label1.TabIndex = 1;
            label1.Text = "실시간 온도(℃)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("나눔고딕", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(441, 129);
            label3.Name = "label3";
            label3.Size = new Size(118, 43);
            label3.TabIndex = 2;
            label3.Text = "30(℃)";
            label3.Click += label3_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Font = new Font("나눔고딕", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            groupBox2.Location = new Point(662, 249);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(310, 220);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "시스템 동작 여부";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(pictureBox1);
            groupBox4.Font = new Font("나눔고딕", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            groupBox4.Location = new Point(662, 12);
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
            // button1
            // 
            button1.Font = new Font("나눔고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(662, 483);
            button1.Name = "button1";
            button1.Size = new Size(406, 54);
            button1.TabIndex = 8;
            button1.Text = "기록 조회";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("나눔고딕", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 129);
            button2.Location = new Point(978, 263);
            button2.Name = "button2";
            button2.Size = new Size(90, 100);
            button2.TabIndex = 9;
            button2.Text = "동작 정지";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("나눔고딕", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 129);
            button3.Location = new Point(978, 369);
            button3.Name = "button3";
            button3.Size = new Size(90, 100);
            button3.TabIndex = 10;
            button3.Text = "동작 재개";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("나눔고딕", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 129);
            button4.Location = new Point(978, 26);
            button4.Name = "button4";
            button4.Size = new Size(90, 100);
            button4.TabIndex = 11;
            button4.Text = "화재 알림";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("나눔고딕", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 129);
            button5.Location = new Point(978, 132);
            button5.Name = "button5";
            button5.Size = new Size(90, 100);
            button5.TabIndex = 11;
            button5.Text = "동작 종료";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button4_Click;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1104, 569);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private Label label1;
        private Label label3;
        private Label label4;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
