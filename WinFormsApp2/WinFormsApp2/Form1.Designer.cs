namespace WinFormsApp2
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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chartA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartB = new System.Windows.Forms.DataVisualization.Charting.Chart();
            btnAddY = new Button();
            btnAddXY = new Button();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            button1 = new Button();
            button2 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)chartA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            SuspendLayout();
            // 
            // chartA
            // 
            chartArea1.Name = "ChartArea1";
            chartA.ChartAreas.Add(chartArea1);
            chartA.Location = new Point(25, 12);
            chartA.Name = "chartA";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            chartA.Series.Add(series1);
            chartA.Size = new Size(333, 213);
            chartA.TabIndex = 0;
            chartA.Text = "chart1";
            // 
            // chartB
            // 
            chartArea2.Name = "ChartArea1";
            chartB.ChartAreas.Add(chartArea2);
            chartB.Location = new Point(401, 12);
            chartB.Name = "chartB";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            chartB.Series.Add(series2);
            chartB.Size = new Size(311, 213);
            chartB.TabIndex = 0;
            chartB.Text = "chart1";
            // 
            // btnAddY
            // 
            btnAddY.Location = new Point(133, 231);
            btnAddY.Name = "btnAddY";
            btnAddY.Size = new Size(94, 29);
            btnAddY.TabIndex = 1;
            btnAddY.Text = "btnAddY";
            btnAddY.UseVisualStyleBackColor = true;
            btnAddY.Click += btnAddY_Click;
            // 
            // btnAddXY
            // 
            btnAddXY.Location = new Point(513, 231);
            btnAddXY.Name = "btnAddXY";
            btnAddXY.Size = new Size(94, 29);
            btnAddXY.TabIndex = 1;
            btnAddXY.Text = "btnAddXY";
            btnAddXY.UseVisualStyleBackColor = true;
            btnAddXY.Click += btnAddXY_Click;
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea3);
            chart1.Location = new Point(25, 281);
            chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series3.Name = "Series1";
            series3.YValuesPerPoint = 2;
            chart1.Series.Add(series3);
            chart1.Size = new Size(333, 220);
            chart1.TabIndex = 2;
            chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea4.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea4);
            legend1.Name = "Legend1";
            chart2.Legends.Add(legend1);
            chart2.Location = new Point(401, 281);
            chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            chart2.Series.Add(series4);
            chart2.Size = new Size(300, 220);
            chart2.TabIndex = 2;
            chart2.Text = "chart1";
            // 
            // button1
            // 
            button1.Location = new Point(133, 507);
            button1.Name = "button1";
            button1.Size = new Size(115, 29);
            button1.TabIndex = 1;
            button1.Text = "start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(513, 507);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "start";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 554);
            Controls.Add(chart2);
            Controls.Add(chart1);
            Controls.Add(btnAddXY);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnAddY);
            Controls.Add(chartB);
            Controls.Add(chartA);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)chartA).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartB).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartB;
        private Button btnAddY;
        private Button btnAddXY;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private Button button1;
        private Button button2;
        private System.Windows.Forms.Timer timer1;
    }
}
