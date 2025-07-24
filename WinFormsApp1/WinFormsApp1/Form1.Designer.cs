namespace WinFormsApp1
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            DataGridView = new Button();
            btnCalculator = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 31);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 1;
            label1.Text = "입력1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(66, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(126, 27);
            textBox1.TabIndex = 2;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 87);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 3;
            label2.Text = "입력2";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(66, 77);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(126, 45);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(218, 21);
            button1.Name = "button1";
            button1.Size = new Size(180, 40);
            button1.TabIndex = 4;
            button1.Text = "Button Control";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(218, 77);
            button2.Name = "button2";
            button2.Size = new Size(180, 40);
            button2.TabIndex = 4;
            button2.Text = "CheckBox Control";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 140);
            button3.Name = "button3";
            button3.Size = new Size(386, 40);
            button3.TabIndex = 4;
            button3.Text = "Timer Control";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // DataGridView
            // 
            DataGridView.Location = new Point(12, 194);
            DataGridView.Name = "DataGridView";
            DataGridView.Size = new Size(386, 40);
            DataGridView.TabIndex = 4;
            DataGridView.Text = "DataGridView";
            DataGridView.UseVisualStyleBackColor = true;
            DataGridView.Click += DataGridView_Click;
            // 
            // btnCalculator
            // 
            btnCalculator.Location = new Point(12, 252);
            btnCalculator.Name = "btnCalculator";
            btnCalculator.Size = new Size(386, 40);
            btnCalculator.TabIndex = 4;
            btnCalculator.Text = "Calculator";
            btnCalculator.UseVisualStyleBackColor = true;
            btnCalculator.Click += btnCalculator_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 418);
            Controls.Add(btnCalculator);
            Controls.Add(DataGridView);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button DataGridView;
        private Button btnCalculator;
    }
}
