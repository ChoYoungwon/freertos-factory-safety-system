namespace sensor_interface1
{
    partial class Form6
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
            label6 = new Label();
            lbl_bright = new PictureBox();
            trackBar1 = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)lbl_bright).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(351, 115);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 10;
            label6.Text = "밝기 :";
            // 
            // lbl_bright
            // 
            lbl_bright.Location = new Point(413, 115);
            lbl_bright.Name = "lbl_bright";
            lbl_bright.Size = new Size(125, 27);
            lbl_bright.TabIndex = 11;
            lbl_bright.TabStop = false;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(544, 114);
            trackBar1.Maximum = 255;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(106, 56);
            trackBar1.TabIndex = 12;
            trackBar1.Scroll += trackBar1_Scroll;
            trackBar1.ValueChanged += trackBar1_ValueChanged;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 332);
            Controls.Add(trackBar1);
            Controls.Add(lbl_bright);
            Controls.Add(label6);
            Name = "Form6";
            Text = "Form6";
            FormClosing += Form6_FormClosing;
            Load += Form6_Load;
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(lbl_bright, 0);
            Controls.SetChildIndex(trackBar1, 0);
            ((System.ComponentModel.ISupportInitialize)lbl_bright).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private PictureBox lbl_bright;
        private TrackBar trackBar1;
    }
}