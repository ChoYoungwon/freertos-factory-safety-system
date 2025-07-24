namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            imageList1 = new ImageList(components);
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(88, 12);
            button1.Name = "button1";
            button1.Size = new Size(220, 44);
            button1.TabIndex = 0;
            button1.Text = "기본 버튼";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(88, 75);
            button2.Name = "button2";
            button2.Size = new Size(220, 44);
            button2.TabIndex = 0;
            button2.Text = "Flat 테두리 버튼";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(88, 139);
            button3.Name = "button3";
            button3.Size = new Size(220, 44);
            button3.TabIndex = 0;
            button3.Text = "이미지가 있는 버튼";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.ImageIndex = 0;
            button4.ImageList = imageList1;
            button4.Location = new Point(88, 204);
            button4.Name = "button4";
            button4.Size = new Size(220, 44);
            button4.TabIndex = 0;
            button4.Text = "이미지 리스트 버튼";
            button4.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "hand.png");
            // 
            // button5
            // 
            button5.FlatAppearance.BorderColor = Color.Red;
            button5.FlatAppearance.BorderSize = 3;
            button5.FlatAppearance.MouseDownBackColor = Color.Yellow;
            button5.FlatAppearance.MouseOverBackColor = Color.Green;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(88, 267);
            button5.Name = "button5";
            button5.Size = new Size(220, 44);
            button5.TabIndex = 0;
            button5.Text = "배경색이 변하는 버튼";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.Enabled = false;
            button6.Location = new Point(88, 333);
            button6.Name = "button6";
            button6.Size = new Size(220, 44);
            button6.TabIndex = 0;
            button6.Text = "비활성화된 버튼";
            button6.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 405);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private ImageList imageList1;
    }
}