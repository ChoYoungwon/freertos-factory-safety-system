namespace AGauge2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            aGauge1 = new AGauge();
            button1 = new Button();
            button2 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            circularButton1 = new CircularButton();
            pictureBox1 = new PictureBox();
            btnTurn = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // aGauge1
            // 
            aGauge1.BaseArcColor = Color.Gray;
            aGauge1.BaseArcRadius = 80;
            aGauge1.BaseArcStart = 135;
            aGauge1.BaseArcSweep = 270;
            aGauge1.BaseArcWidth = 2;
            aGauge1.Center = new Point(100, 100);
            aGauge1.Location = new Point(24, 12);
            aGauge1.MaxValue = 100F;
            aGauge1.MinValue = -100F;
            aGauge1.Name = "aGauge1";
            aGauge1.NeedleColor1 = AGaugeNeedleColor.Gray;
            aGauge1.NeedleColor2 = Color.DimGray;
            aGauge1.NeedleRadius = 80;
            aGauge1.NeedleType = NeedleType.Advance;
            aGauge1.NeedleWidth = 2;
            aGauge1.ScaleLinesInterColor = Color.Black;
            aGauge1.ScaleLinesInterInnerRadius = 73;
            aGauge1.ScaleLinesInterOuterRadius = 80;
            aGauge1.ScaleLinesInterWidth = 1;
            aGauge1.ScaleLinesMajorColor = Color.Black;
            aGauge1.ScaleLinesMajorInnerRadius = 70;
            aGauge1.ScaleLinesMajorOuterRadius = 80;
            aGauge1.ScaleLinesMajorStepValue = 20F;
            aGauge1.ScaleLinesMajorWidth = 2;
            aGauge1.ScaleLinesMinorColor = Color.Gray;
            aGauge1.ScaleLinesMinorInnerRadius = 75;
            aGauge1.ScaleLinesMinorOuterRadius = 80;
            aGauge1.ScaleLinesMinorTicks = 9;
            aGauge1.ScaleLinesMinorWidth = 1;
            aGauge1.ScaleNumbersColor = Color.Black;
            aGauge1.ScaleNumbersFormat = null;
            aGauge1.ScaleNumbersRadius = 95;
            aGauge1.ScaleNumbersRotation = 0;
            aGauge1.ScaleNumbersStartScaleLine = 0;
            aGauge1.ScaleNumbersStepScaleLines = 1;
            aGauge1.Size = new Size(209, 185);
            aGauge1.TabIndex = 0;
            aGauge1.Text = "aGauge1";
            aGauge1.Value = 0F;
            // 
            // button1
            // 
            button1.Font = new Font("굴림", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button1.Location = new Point(265, 32);
            button1.Name = "button1";
            button1.Size = new Size(72, 56);
            button1.TabIndex = 1;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("굴림", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button2.Location = new Point(265, 112);
            button2.Name = "button2";
            button2.Size = new Size(72, 56);
            button2.TabIndex = 1;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // circularButton1
            // 
            circularButton1.BackColor = Color.Lime;
            circularButton1.FlatAppearance.BorderColor = Color.Lime;
            circularButton1.FlatStyle = FlatStyle.Flat;
            circularButton1.Location = new Point(390, 46);
            circularButton1.Name = "circularButton1";
            circularButton1.Size = new Size(137, 111);
            circularButton1.TabIndex = 2;
            circularButton1.Text = "greenButton";
            circularButton1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 203);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(207, 199);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnTurn
            // 
            btnTurn.Location = new Point(265, 294);
            btnTurn.Name = "btnTurn";
            btnTurn.Size = new Size(94, 29);
            btnTurn.TabIndex = 4;
            btnTurn.Text = "Turn";
            btnTurn.UseVisualStyleBackColor = true;
            btnTurn.Click += btnTurn_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 410);
            Controls.Add(btnTurn);
            Controls.Add(pictureBox1);
            Controls.Add(circularButton1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(aGauge1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private AGauge aGauge1;
        private Button button1;
        private Button button2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CircularButton circularButton1;
        private PictureBox pictureBox1;
        private Button btnTurn;
        private System.Windows.Forms.Timer timer1;
    }
}
