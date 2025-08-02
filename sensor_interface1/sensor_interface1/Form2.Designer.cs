namespace sensor_interface1
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cbx_ports = new ComboBox();
            tbx_comState = new TextBox();
            tbx_receiveData = new TextBox();
            btn_connect = new Button();
            button2 = new Button();
            bindingSource1 = new BindingSource(components);
            bindingSource2 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("굴림", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(86, 18);
            label1.Name = "label1";
            label1.Size = new Size(154, 34);
            label1.TabIndex = 0;
            label1.Text = "Port연결";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 77);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 1;
            label2.Text = "포트 : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 115);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 2;
            label3.Text = "연결 상태 : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 171);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 2;
            label4.Text = "수신된 데이터";
            // 
            // cbx_ports
            // 
            cbx_ports.FormattingEnabled = true;
            cbx_ports.Location = new Point(113, 74);
            cbx_ports.Name = "cbx_ports";
            cbx_ports.Size = new Size(110, 28);
            cbx_ports.TabIndex = 3;
            // 
            // tbx_comState
            // 
            tbx_comState.Location = new Point(113, 115);
            tbx_comState.Name = "tbx_comState";
            tbx_comState.Size = new Size(110, 27);
            tbx_comState.TabIndex = 4;
            // 
            // tbx_receiveData
            // 
            tbx_receiveData.Location = new Point(20, 194);
            tbx_receiveData.Multiline = true;
            tbx_receiveData.Name = "tbx_receiveData";
            tbx_receiveData.Size = new Size(286, 94);
            tbx_receiveData.TabIndex = 5;
            // 
            // btn_connect
            // 
            btn_connect.BackColor = SystemColors.ActiveBorder;
            btn_connect.Location = new Point(229, 73);
            btn_connect.Name = "btn_connect";
            btn_connect.Size = new Size(77, 29);
            btn_connect.TabIndex = 6;
            btn_connect.Text = "연결";
            btn_connect.UseVisualStyleBackColor = false;
            btn_connect.Click += btn_connect_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.Location = new Point(229, 114);
            button2.Name = "button2";
            button2.Size = new Size(77, 29);
            button2.TabIndex = 6;
            button2.Text = "해제";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 318);
            Controls.Add(button2);
            Controls.Add(btn_connect);
            Controls.Add(tbx_receiveData);
            Controls.Add(tbx_comState);
            Controls.Add(cbx_ports);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            FormClosing += Form2_FormClosing;
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cbx_ports;
        private TextBox tbx_comState;
        protected TextBox tbx_receiveData;
        private Button btn_connect;
        private Button button2;
        private BindingSource bindingSource1;
        private BindingSource bindingSource2;
    }
}