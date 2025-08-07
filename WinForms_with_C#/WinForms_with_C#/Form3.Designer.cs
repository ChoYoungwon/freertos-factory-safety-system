namespace WinForms_with_C_
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            tbx_phone = new TextBox();
            tbx_name = new TextBox();
            tbx_password = new TextBox();
            tbx_ID = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("굴림", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(376, 53);
            label1.TabIndex = 0;
            label1.Text = "회원가입";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 68);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 106);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 2;
            label3.Text = "PassWord";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 146);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 2;
            label4.Text = "name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 187);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 2;
            label5.Text = "Birth";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 229);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 2;
            label6.Text = "phone";
            // 
            // button1
            // 
            button1.Location = new Point(74, 276);
            button1.Name = "button1";
            button1.Size = new Size(100, 50);
            button1.TabIndex = 3;
            button1.Text = "회원가입";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(194, 276);
            button2.Name = "button2";
            button2.Size = new Size(100, 50);
            button2.TabIndex = 4;
            button2.Text = "초기화";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tbx_phone
            // 
            tbx_phone.Location = new Point(169, 226);
            tbx_phone.Name = "tbx_phone";
            tbx_phone.Size = new Size(125, 27);
            tbx_phone.TabIndex = 5;
            // 
            // tbx_name
            // 
            tbx_name.Location = new Point(169, 146);
            tbx_name.Name = "tbx_name";
            tbx_name.Size = new Size(125, 27);
            tbx_name.TabIndex = 6;
            // 
            // tbx_password
            // 
            tbx_password.Location = new Point(169, 106);
            tbx_password.Name = "tbx_password";
            tbx_password.Size = new Size(125, 27);
            tbx_password.TabIndex = 7;
            // 
            // tbx_ID
            // 
            tbx_ID.Location = new Point(169, 68);
            tbx_ID.Name = "tbx_ID";
            tbx_ID.Size = new Size(125, 27);
            tbx_ID.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(169, 187);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(125, 27);
            dateTimePicker1.TabIndex = 9;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 376);
            Controls.Add(dateTimePicker1);
            Controls.Add(tbx_ID);
            Controls.Add(tbx_password);
            Controls.Add(tbx_name);
            Controls.Add(tbx_phone);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            FormClosing += Form3_FormClosing;
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button button2;
        private TextBox tbx_phone;
        private TextBox tbx_name;
        private TextBox tbx_password;
        private TextBox tbx_ID;
        private DateTimePicker dateTimePicker1;
    }
}