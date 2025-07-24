namespace WinFormsApp1
{
    partial class Form4
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
            timer1 = new System.Windows.Forms.Timer(components);
            lblCurrentTime = new Label();
            btnStartStop = new Button();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // lblCurrentTime
            // 
            lblCurrentTime.AutoSize = true;
            lblCurrentTime.Font = new Font("맑은 고딕", 36F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblCurrentTime.Location = new Point(-1, 28);
            lblCurrentTime.Name = "lblCurrentTime";
            lblCurrentTime.Size = new Size(259, 81);
            lblCurrentTime.TabIndex = 0;
            lblCurrentTime.Text = "00:00:00";
            // 
            // btnStartStop
            // 
            btnStartStop.AccessibleRole = AccessibleRole.SplitButton;
            btnStartStop.Location = new Point(75, 122);
            btnStartStop.Name = "btnStartStop";
            btnStartStop.Size = new Size(94, 29);
            btnStartStop.TabIndex = 1;
            btnStartStop.Text = "시 작";
            btnStartStop.UseVisualStyleBackColor = true;
            btnStartStop.Click += btnStartStop_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(252, 165);
            Controls.Add(btnStartStop);
            Controls.Add(lblCurrentTime);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label lblCurrentTime;
        private Button btnStartStop;
    }
}