namespace WinForms_with_C_
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
            label1 = new Label();
            listView1 = new ListView();
            ID = new ColumnHeader();
            custid = new ColumnHeader();
            bookname = new ColumnHeader();
            price = new ColumnHeader();
            date = new ColumnHeader();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbx_id = new TextBox();
            tbx_custid = new TextBox();
            tbx_bookname = new TextBox();
            tbx_price = new TextBox();
            tbx_date = new TextBox();
            btn_show = new Button();
            btn_add = new Button();
            btn_modify = new Button();
            btn_delete = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("굴림", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(699, 34);
            label1.TabIndex = 0;
            label1.Text = "주문관리";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ID, custid, bookname, price, date });
            listView1.Location = new Point(12, 47);
            listView1.Name = "listView1";
            listView1.Size = new Size(675, 226);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 80;
            // 
            // custid
            // 
            custid.Text = "고객명";
            custid.Width = 80;
            // 
            // bookname
            // 
            bookname.Text = "도서명";
            bookname.Width = 120;
            // 
            // price
            // 
            price.Text = "가격";
            price.Width = 100;
            // 
            // date
            // 
            date.Text = "주문일";
            date.Width = 200;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 287);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 2;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(147, 287);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 2;
            label3.Text = "고객명";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(261, 287);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 2;
            label4.Text = "도서명";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(402, 287);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 2;
            label5.Text = "가격";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(518, 287);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 2;
            label6.Text = "날짜";
            // 
            // tbx_id
            // 
            tbx_id.Location = new Point(12, 310);
            tbx_id.Name = "tbx_id";
            tbx_id.Size = new Size(103, 27);
            tbx_id.TabIndex = 3;
            // 
            // tbx_custid
            // 
            tbx_custid.Location = new Point(132, 310);
            tbx_custid.Name = "tbx_custid";
            tbx_custid.Size = new Size(114, 27);
            tbx_custid.TabIndex = 3;
            // 
            // tbx_bookname
            // 
            tbx_bookname.Location = new Point(261, 310);
            tbx_bookname.Name = "tbx_bookname";
            tbx_bookname.Size = new Size(129, 27);
            tbx_bookname.TabIndex = 3;
            // 
            // tbx_price
            // 
            tbx_price.Location = new Point(402, 310);
            tbx_price.Name = "tbx_price";
            tbx_price.Size = new Size(99, 27);
            tbx_price.TabIndex = 3;
            // 
            // tbx_date
            // 
            tbx_date.Location = new Point(518, 310);
            tbx_date.Name = "tbx_date";
            tbx_date.Size = new Size(129, 27);
            tbx_date.TabIndex = 3;
            // 
            // btn_show
            // 
            btn_show.Location = new Point(12, 367);
            btn_show.Name = "btn_show";
            btn_show.Size = new Size(94, 29);
            btn_show.TabIndex = 4;
            btn_show.Text = "조회";
            btn_show.UseVisualStyleBackColor = true;
            btn_show.Click += btn_show_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(112, 367);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 5;
            btn_add.Text = "추가";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_modify
            // 
            btn_modify.Location = new Point(212, 367);
            btn_modify.Name = "btn_modify";
            btn_modify.Size = new Size(94, 29);
            btn_modify.TabIndex = 6;
            btn_modify.Text = "수정";
            btn_modify.UseVisualStyleBackColor = true;
            btn_modify.Click += btn_modify_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(312, 367);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 29);
            btn_delete.TabIndex = 7;
            btn_delete.Text = "삭제";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 408);
            Controls.Add(btn_delete);
            Controls.Add(btn_modify);
            Controls.Add(btn_add);
            Controls.Add(btn_show);
            Controls.Add(tbx_price);
            Controls.Add(tbx_date);
            Controls.Add(tbx_bookname);
            Controls.Add(tbx_custid);
            Controls.Add(tbx_id);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listView1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            FormClosing += Form2_FormClosing;
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listView1;
        private ColumnHeader ID;
        private ColumnHeader custid;
        private ColumnHeader bookname;
        private ColumnHeader price;
        private ColumnHeader date;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbx_id;
        private TextBox tbx_custid;
        private TextBox tbx_bookname;
        private TextBox tbx_price;
        private TextBox tbx_date;
        private Button btn_show;
        private Button btn_add;
        private Button btn_modify;
        private Button btn_delete;
    }
}