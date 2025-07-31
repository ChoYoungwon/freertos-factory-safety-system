namespace sensor_interface1
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
            label5 = new Label();
            tbx_color = new TextBox();
            btn_changeLed = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(329, 74);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 7;
            label5.Text = "LED색상 : ";
            // 
            // tbx_color
            // 
            tbx_color.Location = new Point(413, 74);
            tbx_color.Name = "tbx_color";
            tbx_color.Size = new Size(125, 27);
            tbx_color.TabIndex = 8;
            // 
            // btn_changeLed
            // 
            btn_changeLed.BackColor = SystemColors.ActiveBorder;
            btn_changeLed.Location = new Point(544, 72);
            btn_changeLed.Name = "btn_changeLed";
            btn_changeLed.Size = new Size(78, 29);
            btn_changeLed.TabIndex = 9;
            btn_changeLed.Text = "바꾸기";
            btn_changeLed.UseVisualStyleBackColor = false;
            btn_changeLed.Click += btn_changeLed_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 315);
            Controls.Add(btn_changeLed);
            Controls.Add(tbx_color);
            Controls.Add(label5);
            Name = "Form4";
            Text = "Form4";
            FormClosing += Form4_FormClosing;
            Load += Form4_Load;
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(tbx_color, 0);
            Controls.SetChildIndex(btn_changeLed, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox tbx_color;
        private Button btn_changeLed;
    }
}