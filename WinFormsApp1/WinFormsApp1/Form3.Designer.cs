namespace WinFormsApp1
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
            chkEmail = new CheckBox();
            chkSMS = new CheckBox();
            grpTopic = new GroupBox();
            checkBox7 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            button1 = new Button();
            grpMenu = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            lblMsg = new Label();
            lstDept = new ListBox();
            button2 = new Button();
            comboSimple = new ComboBox();
            comboDropDown = new ComboBox();
            comboDropDownList = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            grpTopic.SuspendLayout();
            grpMenu.SuspendLayout();
            SuspendLayout();
            // 
            // chkEmail
            // 
            chkEmail.AutoSize = true;
            chkEmail.Location = new Point(160, 68);
            chkEmail.Name = "chkEmail";
            chkEmail.Size = new Size(111, 24);
            chkEmail.TabIndex = 0;
            chkEmail.Text = "이메일 수신";
            chkEmail.UseVisualStyleBackColor = true;
            // 
            // chkSMS
            // 
            chkSMS.AutoSize = true;
            chkSMS.Location = new Point(160, 98);
            chkSMS.Name = "chkSMS";
            chkSMS.Size = new Size(96, 24);
            chkSMS.TabIndex = 0;
            chkSMS.Text = "SMS 수신";
            chkSMS.UseVisualStyleBackColor = true;
            // 
            // grpTopic
            // 
            grpTopic.Controls.Add(checkBox7);
            grpTopic.Controls.Add(checkBox6);
            grpTopic.Controls.Add(checkBox5);
            grpTopic.Controls.Add(checkBox4);
            grpTopic.Controls.Add(checkBox3);
            grpTopic.Location = new Point(12, 12);
            grpTopic.Name = "grpTopic";
            grpTopic.Size = new Size(131, 184);
            grpTopic.TabIndex = 1;
            grpTopic.TabStop = false;
            grpTopic.Text = "주제";
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(16, 146);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(61, 24);
            checkBox7.TabIndex = 0;
            checkBox7.Text = "게임";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(16, 116);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(61, 24);
            checkBox6.TabIndex = 0;
            checkBox6.Text = "음악";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(16, 86);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(61, 24);
            checkBox5.TabIndex = 0;
            checkBox5.Text = "패션";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(16, 56);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(61, 24);
            checkBox4.TabIndex = 0;
            checkBox4.Text = "운동";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(16, 26);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(61, 24);
            checkBox3.TabIndex = 0;
            checkBox3.Text = "영화";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(149, 128);
            button1.Name = "button1";
            button1.Size = new Size(131, 38);
            button1.TabIndex = 2;
            button1.Text = "선택 항목 보기";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // grpMenu
            // 
            grpMenu.Controls.Add(radioButton3);
            grpMenu.Controls.Add(radioButton2);
            grpMenu.Controls.Add(radioButton1);
            grpMenu.Location = new Point(302, 12);
            grpMenu.Name = "grpMenu";
            grpMenu.Size = new Size(96, 124);
            grpMenu.TabIndex = 3;
            grpMenu.TabStop = false;
            grpMenu.Text = "메뉴 선택";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(17, 86);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(60, 24);
            radioButton3.TabIndex = 4;
            radioButton3.TabStop = true;
            radioButton3.Text = "갈비";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.Click += radioButton3_Click;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(17, 56);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(60, 24);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "안심";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.Click += radioButton2_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(17, 26);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(60, 24);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "등심";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.Click += radioButton1_Click;
            // 
            // lblMsg
            // 
            lblMsg.AutoSize = true;
            lblMsg.Location = new Point(302, 146);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(74, 20);
            lblMsg.TabIndex = 4;
            lblMsg.Text = "메뉴 선택";
            lblMsg.Visible = false;
            // 
            // lstDept
            // 
            lstDept.FormattingEnabled = true;
            lstDept.Location = new Point(12, 211);
            lstDept.Name = "lstDept";
            lstDept.Size = new Size(131, 184);
            lstDept.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(149, 211);
            button2.Name = "button2";
            button2.Size = new Size(131, 38);
            button2.TabIndex = 2;
            button2.Text = "선택 항목 보기";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboSimple
            // 
            comboSimple.DropDownStyle = ComboBoxStyle.Simple;
            comboSimple.FormattingEnabled = true;
            comboSimple.Location = new Point(470, 242);
            comboSimple.Name = "comboSimple";
            comboSimple.Size = new Size(151, 140);
            comboSimple.TabIndex = 6;
            // 
            // comboDropDown
            // 
            comboDropDown.FormattingEnabled = true;
            comboDropDown.Location = new Point(302, 243);
            comboDropDown.Name = "comboDropDown";
            comboDropDown.Size = new Size(151, 28);
            comboDropDown.TabIndex = 6;
            // 
            // comboDropDownList
            // 
            comboDropDownList.DropDownStyle = ComboBoxStyle.DropDownList;
            comboDropDownList.FormattingEnabled = true;
            comboDropDownList.Location = new Point(302, 310);
            comboDropDownList.Name = "comboDropDownList";
            comboDropDownList.Size = new Size(151, 28);
            comboDropDownList.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(470, 219);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 4;
            label1.Text = "Simple";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(302, 220);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 4;
            label2.Text = "DropDown";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(302, 287);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 4;
            label3.Text = "DropDownList";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 470);
            Controls.Add(comboDropDownList);
            Controls.Add(comboDropDown);
            Controls.Add(comboSimple);
            Controls.Add(lstDept);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblMsg);
            Controls.Add(grpMenu);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(grpTopic);
            Controls.Add(chkSMS);
            Controls.Add(chkEmail);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            grpTopic.ResumeLayout(false);
            grpTopic.PerformLayout();
            grpMenu.ResumeLayout(false);
            grpMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkEmail;
        private CheckBox chkSMS;
        private GroupBox grpTopic;
        private CheckBox checkBox7;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private Button button1;
        private GroupBox grpMenu;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label lblMsg;
        private ListBox lstDept;
        private Button button2;
        private ComboBox comboSimple;
        private ComboBox comboDropDown;
        private ComboBox comboDropDownList;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}