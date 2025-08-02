namespace sensor_interface1
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
            btnOn = new Button();
            btnOFF = new Button();
            button1 = new Button();
            btn_LCD = new Button();
            btnRGB = new Button();
            btn_joystic = new Button();
            btnPhotoresistor = new Button();
            btnMotor = new Button();
            SuspendLayout();
            // 
            // btnOn
            // 
            btnOn.Location = new Point(12, 12);
            btnOn.Name = "btnOn";
            btnOn.Size = new Size(67, 38);
            btnOn.TabIndex = 0;
            btnOn.Text = "ON";
            btnOn.UseVisualStyleBackColor = true;
            btnOn.Click += btnOn_Click;
            // 
            // btnOFF
            // 
            btnOFF.Location = new Point(85, 12);
            btnOFF.Name = "btnOFF";
            btnOFF.Size = new Size(63, 38);
            btnOFF.TabIndex = 0;
            btnOFF.Text = "OFF";
            btnOFF.UseVisualStyleBackColor = true;
            btnOFF.Click += btnOFF_Click;
            // 
            // button1
            // 
            button1.Font = new Font("굴림", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button1.Location = new Point(12, 66);
            button1.Name = "button1";
            button1.Size = new Size(289, 44);
            button1.TabIndex = 1;
            button1.Text = "Port연결";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_LCD
            // 
            btn_LCD.Font = new Font("굴림", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btn_LCD.Location = new Point(12, 134);
            btn_LCD.Name = "btn_LCD";
            btn_LCD.Size = new Size(289, 44);
            btn_LCD.TabIndex = 1;
            btn_LCD.Text = "LCD";
            btn_LCD.UseVisualStyleBackColor = true;
            btn_LCD.Click += btn_LCD_Click;
            // 
            // btnRGB
            // 
            btnRGB.Font = new Font("굴림", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnRGB.Location = new Point(12, 197);
            btnRGB.Name = "btnRGB";
            btnRGB.Size = new Size(289, 44);
            btnRGB.TabIndex = 1;
            btnRGB.Text = "RGB 모듈 제어";
            btnRGB.UseVisualStyleBackColor = true;
            btnRGB.Click += btnRGB_Click;
            // 
            // btn_joystic
            // 
            btn_joystic.Font = new Font("굴림", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btn_joystic.Location = new Point(12, 270);
            btn_joystic.Name = "btn_joystic";
            btn_joystic.Size = new Size(289, 44);
            btn_joystic.TabIndex = 1;
            btn_joystic.Text = "조이스틱 GUI 컨트롤";
            btn_joystic.UseVisualStyleBackColor = true;
            btn_joystic.Click += btn_joystic_Click;
            // 
            // btnPhotoresistor
            // 
            btnPhotoresistor.Font = new Font("굴림", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnPhotoresistor.Location = new Point(317, 66);
            btnPhotoresistor.Name = "btnPhotoresistor";
            btnPhotoresistor.Size = new Size(289, 44);
            btnPhotoresistor.TabIndex = 1;
            btnPhotoresistor.Text = "조도 센서 표현";
            btnPhotoresistor.UseVisualStyleBackColor = true;
            btnPhotoresistor.Click += btnPhotoresistor_Click;
            // 
            // btnMotor
            // 
            btnMotor.Font = new Font("굴림", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnMotor.Location = new Point(317, 134);
            btnMotor.Name = "btnMotor";
            btnMotor.Size = new Size(289, 44);
            btnMotor.TabIndex = 1;
            btnMotor.Text = "모터 제어";
            btnMotor.UseVisualStyleBackColor = true;
            btnMotor.Click += btnMotor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 345);
            Controls.Add(btn_joystic);
            Controls.Add(btnRGB);
            Controls.Add(btn_LCD);
            Controls.Add(btnMotor);
            Controls.Add(btnPhotoresistor);
            Controls.Add(button1);
            Controls.Add(btnOFF);
            Controls.Add(btnOn);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnOn;
        private Button btnOFF;
        private Button button1;
        private Button btn_LCD;
        private Button btnRGB;
        private Button btn_joystic;
        private Button btnPhotoresistor;
        private Button btnMotor;
    }
}
