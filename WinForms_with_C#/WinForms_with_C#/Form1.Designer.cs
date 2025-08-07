namespace WinForms_with_C_
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
            btn_show = new Button();
            listView1 = new ListView();
            ID = new ColumnHeader();
            ColumName = new ColumnHeader();
            Address = new ColumnHeader();
            Phone = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbx_ID = new TextBox();
            tbx_name = new TextBox();
            tbx_address = new TextBox();
            tbx_phone = new TextBox();
            btn_insert = new Button();
            btn_delete = new Button();
            btn_modify = new Button();
            SuspendLayout();
            // 
            // btn_show
            // 
            btn_show.Location = new Point(12, 36);
            btn_show.Name = "btn_show";
            btn_show.Size = new Size(94, 29);
            btn_show.TabIndex = 1;
            btn_show.Text = "조회";
            btn_show.UseVisualStyleBackColor = true;
            btn_show.Click += btn_show_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ID, ColumName, Address, Phone });
            listView1.Location = new Point(12, 71);
            listView1.Name = "listView1";
            listView1.Size = new Size(359, 283);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // ID
            // 
            ID.Text = "ID";
            // 
            // ColumName
            // 
            ColumName.Text = "이름";
            // 
            // Address
            // 
            Address.Text = "주소";
            Address.Width = 100;
            // 
            // Phone
            // 
            Phone.Text = "연락처";
            Phone.Width = 100;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(392, 80);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 3;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(392, 123);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 3;
            label2.Text = "이름";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(392, 169);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 3;
            label3.Text = "주소";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(392, 220);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 3;
            label4.Text = "연락처";
            // 
            // tbx_ID
            // 
            tbx_ID.Location = new Point(464, 80);
            tbx_ID.Name = "tbx_ID";
            tbx_ID.Size = new Size(125, 27);
            tbx_ID.TabIndex = 4;
            // 
            // tbx_name
            // 
            tbx_name.Location = new Point(464, 120);
            tbx_name.Name = "tbx_name";
            tbx_name.Size = new Size(125, 27);
            tbx_name.TabIndex = 4;
            // 
            // tbx_address
            // 
            tbx_address.Location = new Point(464, 166);
            tbx_address.Name = "tbx_address";
            tbx_address.Size = new Size(125, 27);
            tbx_address.TabIndex = 4;
            // 
            // tbx_phone
            // 
            tbx_phone.Location = new Point(464, 217);
            tbx_phone.Name = "tbx_phone";
            tbx_phone.Size = new Size(125, 27);
            tbx_phone.TabIndex = 4;
            // 
            // btn_insert
            // 
            btn_insert.Location = new Point(392, 274);
            btn_insert.Name = "btn_insert";
            btn_insert.Size = new Size(94, 29);
            btn_insert.TabIndex = 5;
            btn_insert.Text = "삽입";
            btn_insert.UseVisualStyleBackColor = true;
            btn_insert.Click += btn_insert_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(392, 309);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(197, 29);
            btn_delete.TabIndex = 6;
            btn_delete.Text = "삭제";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_modify
            // 
            btn_modify.Location = new Point(495, 274);
            btn_modify.Name = "btn_modify";
            btn_modify.Size = new Size(94, 29);
            btn_modify.TabIndex = 7;
            btn_modify.Text = "수정";
            btn_modify.UseVisualStyleBackColor = true;
            btn_modify.Click += btn_modify_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 391);
            Controls.Add(btn_modify);
            Controls.Add(btn_delete);
            Controls.Add(btn_insert);
            Controls.Add(tbx_phone);
            Controls.Add(tbx_address);
            Controls.Add(tbx_name);
            Controls.Add(tbx_ID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listView1);
            Controls.Add(btn_show);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_show;
        private ListView listView1;
        private ColumnHeader ID;
        private ColumnHeader ColumName;
        private ColumnHeader Address;
        private ColumnHeader Phone;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbx_ID;
        private TextBox tbx_name;
        private TextBox tbx_address;
        private TextBox tbx_phone;
        private Button btn_insert;
        private Button btn_delete;
        private Button btn_modify;
    }
}
