namespace sensor_interface1
{
    partial class Form3
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
            button2 = new Button();
            btn_connect = new Button();
            tbx_comState = new TextBox();
            cbx_ports = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbx_data = new TextBox();
            btn_send = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.Location = new Point(228, 60);
            button2.Name = "button2";
            button2.Size = new Size(77, 29);
            button2.TabIndex = 11;
            button2.Text = "해제";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btn_connect
            // 
            btn_connect.BackColor = SystemColors.ActiveBorder;
            btn_connect.Location = new Point(228, 19);
            btn_connect.Name = "btn_connect";
            btn_connect.Size = new Size(77, 29);
            btn_connect.TabIndex = 12;
            btn_connect.Text = "연결";
            btn_connect.UseVisualStyleBackColor = false;
            btn_connect.Click += btn_connect_Click;
            // 
            // tbx_comState
            // 
            tbx_comState.Location = new Point(112, 61);
            tbx_comState.Name = "tbx_comState";
            tbx_comState.Size = new Size(110, 27);
            tbx_comState.TabIndex = 10;
            // 
            // cbx_ports
            // 
            cbx_ports.FormattingEnabled = true;
            cbx_ports.Location = new Point(112, 20);
            cbx_ports.Name = "cbx_ports";
            cbx_ports.Size = new Size(110, 28);
            cbx_ports.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 68);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 8;
            label3.Text = "연결 상태 : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 23);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 7;
            label2.Text = "포트 : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 110);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 8;
            label1.Text = "텍스트 : ";
            // 
            // tbx_data
            // 
            tbx_data.Location = new Point(112, 107);
            tbx_data.Name = "tbx_data";
            tbx_data.Size = new Size(110, 27);
            tbx_data.TabIndex = 10;
            // 
            // btn_send
            // 
            btn_send.BackColor = SystemColors.ActiveBorder;
            btn_send.Location = new Point(228, 106);
            btn_send.Name = "btn_send";
            btn_send.Size = new Size(77, 29);
            btn_send.TabIndex = 11;
            btn_send.Text = "보내기";
            btn_send.UseVisualStyleBackColor = false;
            btn_send.Click += btn_send_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 281);
            Controls.Add(btn_send);
            Controls.Add(button2);
            Controls.Add(btn_connect);
            Controls.Add(tbx_data);
            Controls.Add(tbx_comState);
            Controls.Add(cbx_ports);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Form3";
            Text = "Form3";
            FormClosing += Form3_FormClosing;
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button btn_connect;
        private TextBox tbx_comState;
        private ComboBox cbx_ports;
        private Label label3;
        private Label label2;
        private Label label1;
        protected TextBox tbx_data;
        private Button btn_send;
    }
}