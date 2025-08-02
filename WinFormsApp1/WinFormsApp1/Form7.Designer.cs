namespace WinFormsApp1
{
    partial class Form7
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
            txtStudentID = new TextBox();
            txtStudentName = new TextBox();
            cmbAmount = new ComboBox();
            cmbGrade = new ComboBox();
            btnSave = new Button();
            btnClear = new Button();
            dtDate = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 61);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "Student ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 104);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 0;
            label2.Text = "Student Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 148);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 0;
            label3.Text = "Grade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 214);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 0;
            label4.Text = "Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 254);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 0;
            label5.Text = "Amount";
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(144, 58);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(91, 27);
            txtStudentID.TabIndex = 1;
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(144, 101);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(161, 27);
            txtStudentName.TabIndex = 1;
            // 
            // cmbAmount
            // 
            cmbAmount.FormattingEnabled = true;
            cmbAmount.Location = new Point(144, 254);
            cmbAmount.Name = "cmbAmount";
            cmbAmount.Size = new Size(122, 28);
            cmbAmount.TabIndex = 2;
            // 
            // cmbGrade
            // 
            cmbGrade.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGrade.FormattingEnabled = true;
            cmbGrade.Location = new Point(144, 145);
            cmbGrade.Name = "cmbGrade";
            cmbGrade.Size = new Size(91, 28);
            cmbGrade.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(86, 317);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(186, 317);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dtDate
            // 
            dtDate.CustomFormat = "MM/dd/yyyy";
            dtDate.Format = DateTimePickerFormat.Custom;
            dtDate.Location = new Point(144, 214);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(122, 27);
            dtDate.TabIndex = 4;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 391);
            Controls.Add(dtDate);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(cmbGrade);
            Controls.Add(cmbAmount);
            Controls.Add(txtStudentName);
            Controls.Add(txtStudentID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form7";
            Text = "Form7";
            Load += Form7_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtStudentID;
        private TextBox txtStudentName;
        private ComboBox cmbAmount;
        private ComboBox cmbGrade;
        private Button btnSave;
        private Button btnClear;
        private DateTimePicker dtDate;
    }
}