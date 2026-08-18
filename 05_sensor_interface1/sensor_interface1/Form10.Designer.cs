namespace sensor_interface1
{
    partial class Form10
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
            aGauge1 = new AGauge();
            btnStart = new Button();
            SuspendLayout();
            // 
            // aGauge1
            // 
            aGauge1.BaseArcColor = Color.Gray;
            aGauge1.BaseArcRadius = 80;
            aGauge1.BaseArcStart = 135;
            aGauge1.BaseArcSweep = 270;
            aGauge1.BaseArcWidth = 2;
            aGauge1.Center = new Point(100, 100);
            aGauge1.Location = new Point(345, 73);
            aGauge1.MaxValue = 400F;
            aGauge1.MinValue = -100F;
            aGauge1.Name = "aGauge1";
            aGauge1.NeedleColor1 = AGaugeNeedleColor.Gray;
            aGauge1.NeedleColor2 = Color.DimGray;
            aGauge1.NeedleRadius = 80;
            aGauge1.NeedleType = NeedleType.Advance;
            aGauge1.NeedleWidth = 2;
            aGauge1.ScaleLinesInterColor = Color.Black;
            aGauge1.ScaleLinesInterInnerRadius = 73;
            aGauge1.ScaleLinesInterOuterRadius = 80;
            aGauge1.ScaleLinesInterWidth = 1;
            aGauge1.ScaleLinesMajorColor = Color.Black;
            aGauge1.ScaleLinesMajorInnerRadius = 70;
            aGauge1.ScaleLinesMajorOuterRadius = 80;
            aGauge1.ScaleLinesMajorStepValue = 50F;
            aGauge1.ScaleLinesMajorWidth = 2;
            aGauge1.ScaleLinesMinorColor = Color.Gray;
            aGauge1.ScaleLinesMinorInnerRadius = 75;
            aGauge1.ScaleLinesMinorOuterRadius = 80;
            aGauge1.ScaleLinesMinorTicks = 9;
            aGauge1.ScaleLinesMinorWidth = 1;
            aGauge1.ScaleNumbersColor = Color.Black;
            aGauge1.ScaleNumbersFormat = null;
            aGauge1.ScaleNumbersRadius = 95;
            aGauge1.ScaleNumbersRotation = 0;
            aGauge1.ScaleNumbersStartScaleLine = 0;
            aGauge1.ScaleNumbersStepScaleLines = 1;
            aGauge1.Size = new Size(212, 197);
            aGauge1.TabIndex = 7;
            aGauge1.Text = "aGauge1";
            aGauge1.Value = 0F;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(587, 143);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 29);
            btnStart.TabIndex = 8;
            btnStart.Text = "수신시작";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 299);
            Controls.Add(btnStart);
            Controls.Add(aGauge1);
            Name = "Form10";
            Text = "Form10";
            Controls.SetChildIndex(tbx_receiveData, 0);
            Controls.SetChildIndex(aGauge1, 0);
            Controls.SetChildIndex(btnStart, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AGauge aGauge1;
        private Button btnStart;
    }
}