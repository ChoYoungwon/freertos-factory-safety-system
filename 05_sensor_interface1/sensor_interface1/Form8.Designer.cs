namespace sensor_interface1
{
    partial class Form8
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            label4 = new Label();
            tbx_interval = new TextBox();
            btn_timer = new Button();
            btn_stop = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 162);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 13;
            label4.Text = "반복 간격 :";
            // 
            // tbx_interval
            // 
            tbx_interval.Location = new Point(112, 159);
            tbx_interval.Name = "tbx_interval";
            tbx_interval.Size = new Size(110, 27);
            tbx_interval.TabIndex = 14;
            // 
            // btn_timer
            // 
            btn_timer.BackColor = SystemColors.ActiveBorder;
            btn_timer.Location = new Point(228, 158);
            btn_timer.Name = "btn_timer";
            btn_timer.Size = new Size(97, 29);
            btn_timer.TabIndex = 15;
            btn_timer.Text = "타이머 시작";
            btn_timer.UseVisualStyleBackColor = false;
            btn_timer.Click += btn_timer_Click;
            // 
            // btn_stop
            // 
            btn_stop.BackColor = SystemColors.ActiveBorder;
            btn_stop.Location = new Point(228, 204);
            btn_stop.Name = "btn_stop";
            btn_stop.Size = new Size(97, 29);
            btn_stop.TabIndex = 15;
            btn_stop.Text = "타이머 멈춤";
            btn_stop.UseVisualStyleBackColor = false;
            btn_stop.Click += btn_stop_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(352, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(391, 338);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 370);
            Controls.Add(pictureBox1);
            Controls.Add(btn_stop);
            Controls.Add(btn_timer);
            Controls.Add(tbx_interval);
            Controls.Add(label4);
            Name = "Form8";
            Text = "Form8";
            Controls.SetChildIndex(tbx_data, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(tbx_interval, 0);
            Controls.SetChildIndex(btn_timer, 0);
            Controls.SetChildIndex(btn_stop, 0);
            Controls.SetChildIndex(pictureBox1, 0);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox tbx_interval;
        private Button btn_timer;
        private Button btn_stop;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
    }
}