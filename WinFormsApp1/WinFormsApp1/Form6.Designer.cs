namespace WinFormsApp1
{
    partial class Form6
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
            display = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            ButtonPlus = new Button();
            ButtonDot = new Button();
            ButtonZero = new Button();
            ButtonAC = new Button();
            ButtonMinus = new Button();
            ButtonThree = new Button();
            ButtonTwo = new Button();
            ButtonOne = new Button();
            ButtonMultiply = new Button();
            ButtonSix = new Button();
            ButtonFive = new Button();
            ButtonFour = new Button();
            ButtonDivide = new Button();
            ButtonNine = new Button();
            ButtonEight = new Button();
            ButtonSeven = new Button();
            ButtonResult = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // display
            // 
            display.Dock = DockStyle.Top;
            display.Font = new Font("굴림", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 129);
            display.Location = new Point(0, 0);
            display.Name = "display";
            display.Size = new Size(392, 55);
            display.TabIndex = 0;
            display.Text = "0";
            display.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(ButtonPlus, 3, 3);
            tableLayoutPanel1.Controls.Add(ButtonDot, 2, 3);
            tableLayoutPanel1.Controls.Add(ButtonZero, 1, 3);
            tableLayoutPanel1.Controls.Add(ButtonAC, 0, 3);
            tableLayoutPanel1.Controls.Add(ButtonMinus, 3, 2);
            tableLayoutPanel1.Controls.Add(ButtonThree, 2, 2);
            tableLayoutPanel1.Controls.Add(ButtonTwo, 1, 2);
            tableLayoutPanel1.Controls.Add(ButtonOne, 0, 2);
            tableLayoutPanel1.Controls.Add(ButtonMultiply, 3, 1);
            tableLayoutPanel1.Controls.Add(ButtonSix, 2, 1);
            tableLayoutPanel1.Controls.Add(ButtonFive, 1, 1);
            tableLayoutPanel1.Controls.Add(ButtonFour, 0, 1);
            tableLayoutPanel1.Controls.Add(ButtonDivide, 3, 0);
            tableLayoutPanel1.Controls.Add(ButtonNine, 2, 0);
            tableLayoutPanel1.Controls.Add(ButtonEight, 1, 0);
            tableLayoutPanel1.Controls.Add(ButtonSeven, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 58);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(392, 392);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // ButtonPlus
            // 
            ButtonPlus.Font = new Font("굴림", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 129);
            ButtonPlus.Location = new Point(297, 297);
            ButtonPlus.Name = "ButtonPlus";
            ButtonPlus.Size = new Size(92, 92);
            ButtonPlus.TabIndex = 15;
            ButtonPlus.Text = "+";
            ButtonPlus.UseVisualStyleBackColor = true;
            ButtonPlus.Click += ButtonPlus_Click;
            // 
            // ButtonDot
            // 
            ButtonDot.Font = new Font("굴림", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 129);
            ButtonDot.Location = new Point(199, 297);
            ButtonDot.Name = "ButtonDot";
            ButtonDot.Size = new Size(92, 92);
            ButtonDot.TabIndex = 14;
            ButtonDot.Text = ".";
            ButtonDot.UseVisualStyleBackColor = true;
            ButtonDot.Click += ButtonDot_Click;
            // 
            // ButtonZero
            // 
            ButtonZero.Font = new Font("굴림", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 129);
            ButtonZero.Location = new Point(101, 297);
            ButtonZero.Name = "ButtonZero";
            ButtonZero.Size = new Size(92, 92);
            ButtonZero.TabIndex = 13;
            ButtonZero.Text = "0";
            ButtonZero.UseVisualStyleBackColor = true;
            ButtonZero.Click += ButtonZero_Click;
            // 
            // ButtonAC
            // 
            ButtonAC.Font = new Font("굴림", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 129);
            ButtonAC.Location = new Point(3, 297);
            ButtonAC.Name = "ButtonAC";
            ButtonAC.Size = new Size(92, 92);
            ButtonAC.TabIndex = 12;
            ButtonAC.Text = "AC";
            ButtonAC.UseVisualStyleBackColor = true;
            ButtonAC.Click += ButtonAC_Click;
            // 
            // ButtonMinus
            // 
            ButtonMinus.Font = new Font("굴림", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 129);
            ButtonMinus.Location = new Point(297, 199);
            ButtonMinus.Name = "ButtonMinus";
            ButtonMinus.Size = new Size(92, 92);
            ButtonMinus.TabIndex = 11;
            ButtonMinus.Text = "-";
            ButtonMinus.UseVisualStyleBackColor = true;
            ButtonMinus.Click += ButtonMinus_Click;
            // 
            // ButtonThree
            // 
            ButtonThree.Font = new Font("굴림", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 129);
            ButtonThree.Location = new Point(199, 199);
            ButtonThree.Name = "ButtonThree";
            ButtonThree.Size = new Size(92, 92);
            ButtonThree.TabIndex = 10;
            ButtonThree.Text = "3";
            ButtonThree.UseVisualStyleBackColor = true;
            ButtonThree.Click += ButtonThree_Click;
            // 
            // ButtonTwo
            // 
            ButtonTwo.Font = new Font("굴림", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 129);
            ButtonTwo.Location = new Point(101, 199);
            ButtonTwo.Name = "ButtonTwo";
            ButtonTwo.Size = new Size(92, 92);
            ButtonTwo.TabIndex = 9;
            ButtonTwo.Text = "2";
            ButtonTwo.UseVisualStyleBackColor = true;
            ButtonTwo.Click += ButtonTwo_Click;
            // 
            // ButtonOne
            // 
            ButtonOne.Font = new Font("굴림", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 129);
            ButtonOne.Location = new Point(3, 199);
            ButtonOne.Name = "ButtonOne";
            ButtonOne.Size = new Size(92, 92);
            ButtonOne.TabIndex = 8;
            ButtonOne.Text = "1";
            ButtonOne.UseVisualStyleBackColor = true;
            ButtonOne.Click += ButtonOne_Click;
            // 
            // ButtonMultiply
            // 
            ButtonMultiply.Font = new Font("굴림", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 129);
            ButtonMultiply.Location = new Point(297, 101);
            ButtonMultiply.Name = "ButtonMultiply";
            ButtonMultiply.Size = new Size(92, 92);
            ButtonMultiply.TabIndex = 7;
            ButtonMultiply.Text = "×";
            ButtonMultiply.UseVisualStyleBackColor = true;
            ButtonMultiply.Click += ButtonMultiply_Click;
            // 
            // ButtonSix
            // 
            ButtonSix.Font = new Font("굴림", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 129);
            ButtonSix.Location = new Point(199, 101);
            ButtonSix.Name = "ButtonSix";
            ButtonSix.Size = new Size(92, 92);
            ButtonSix.TabIndex = 6;
            ButtonSix.Text = "6";
            ButtonSix.UseVisualStyleBackColor = true;
            ButtonSix.Click += ButtonSix_Click;
            // 
            // ButtonFive
            // 
            ButtonFive.Font = new Font("굴림", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 129);
            ButtonFive.Location = new Point(101, 101);
            ButtonFive.Name = "ButtonFive";
            ButtonFive.Size = new Size(92, 92);
            ButtonFive.TabIndex = 5;
            ButtonFive.Text = "5";
            ButtonFive.UseVisualStyleBackColor = true;
            ButtonFive.Click += ButtonFive_Click;
            // 
            // ButtonFour
            // 
            ButtonFour.Font = new Font("굴림", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 129);
            ButtonFour.Location = new Point(3, 101);
            ButtonFour.Name = "ButtonFour";
            ButtonFour.Size = new Size(92, 92);
            ButtonFour.TabIndex = 4;
            ButtonFour.Text = "4";
            ButtonFour.UseVisualStyleBackColor = true;
            ButtonFour.Click += ButtonFour_Click;
            // 
            // ButtonDivide
            // 
            ButtonDivide.Font = new Font("굴림", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 129);
            ButtonDivide.Location = new Point(297, 3);
            ButtonDivide.Name = "ButtonDivide";
            ButtonDivide.Size = new Size(92, 92);
            ButtonDivide.TabIndex = 3;
            ButtonDivide.Text = "÷";
            ButtonDivide.UseVisualStyleBackColor = true;
            ButtonDivide.Click += ButtonDivide_Click;
            // 
            // ButtonNine
            // 
            ButtonNine.Font = new Font("굴림", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 129);
            ButtonNine.Location = new Point(199, 3);
            ButtonNine.Name = "ButtonNine";
            ButtonNine.Size = new Size(92, 92);
            ButtonNine.TabIndex = 2;
            ButtonNine.Text = "9";
            ButtonNine.UseVisualStyleBackColor = true;
            ButtonNine.Click += ButtonNine_Click;
            // 
            // ButtonEight
            // 
            ButtonEight.Font = new Font("굴림", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 129);
            ButtonEight.Location = new Point(101, 3);
            ButtonEight.Name = "ButtonEight";
            ButtonEight.Size = new Size(92, 92);
            ButtonEight.TabIndex = 1;
            ButtonEight.Text = "8";
            ButtonEight.UseVisualStyleBackColor = true;
            ButtonEight.Click += ButtonEight_Click;
            // 
            // ButtonSeven
            // 
            ButtonSeven.Font = new Font("굴림", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 129);
            ButtonSeven.Location = new Point(3, 3);
            ButtonSeven.Name = "ButtonSeven";
            ButtonSeven.Size = new Size(92, 92);
            ButtonSeven.TabIndex = 0;
            ButtonSeven.Text = "7";
            ButtonSeven.UseVisualStyleBackColor = true;
            ButtonSeven.Click += ButtonSeven_Click;
            // 
            // ButtonResult
            // 
            ButtonResult.Dock = DockStyle.Bottom;
            ButtonResult.Font = new Font("굴림", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 129);
            ButtonResult.Location = new Point(0, 453);
            ButtonResult.Name = "ButtonResult";
            ButtonResult.Size = new Size(392, 52);
            ButtonResult.TabIndex = 2;
            ButtonResult.Text = "=";
            ButtonResult.TextAlign = ContentAlignment.MiddleCenter;
            ButtonResult.Click += ButtonResult_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 505);
            Controls.Add(ButtonResult);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(display);
            Name = "Form6";
            Text = "Form6";
            Load += Form6_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label display;
        private TableLayoutPanel tableLayoutPanel1;
        private Button ButtonDivide;
        private Button ButtonNine;
        private Button ButtonEight;
        private Button ButtonSeven;
        private Button ButtonTwo;
        private Button ButtonOne;
        private Button ButtonMultiply;
        private Button ButtonSix;
        private Button ButtonFive;
        private Button ButtonFour;
        private Button ButtonPlus;
        private Button ButtonDot;
        private Button ButtonZero;
        private Button ButtonAC;
        private Button ButtonMinus;
        private Button ButtonThree;
        private Label ButtonResult;
    }
}