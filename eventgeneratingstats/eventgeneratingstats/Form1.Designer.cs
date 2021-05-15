namespace eventgeneratingstats
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btCalculate = new System.Windows.Forms.Button();
            this.nudProb1 = new System.Windows.Forms.NumericUpDown();
            this.nudProb2 = new System.Windows.Forms.NumericUpDown();
            this.nudProb3 = new System.Windows.Forms.NumericUpDown();
            this.nudProb4 = new System.Windows.Forms.NumericUpDown();
            this.nudNumber = new System.Windows.Forms.NumericUpDown();
            this.labelWarning = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prob 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prob 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prob 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prob 4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Prob 5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Number of experiments: ";
            // 
            // chart1
            // 
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chart1.BackImageTransparentColor = System.Drawing.Color.White;
            this.chart1.BackSecondaryColor = System.Drawing.Color.White;
            this.chart1.BorderlineWidth = 0;
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX.Maximum = 6D;
            chartArea3.AxisY.MajorGrid.Enabled = false;
            chartArea3.AxisY.Maximum = 1D;
            chartArea3.BorderColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(180, 12);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.IsValueShownAsLabel = true;
            series3.IsXValueIndexed = true;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(608, 426);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            // 
            // btCalculate
            // 
            this.btCalculate.Location = new System.Drawing.Point(29, 341);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(118, 48);
            this.btCalculate.TabIndex = 13;
            this.btCalculate.Text = "Calculate";
            this.btCalculate.UseVisualStyleBackColor = true;
            this.btCalculate.Click += new System.EventHandler(this.btCalculate_Click);
            // 
            // nudProb1
            // 
            this.nudProb1.DecimalPlaces = 2;
            this.nudProb1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudProb1.Location = new System.Drawing.Point(56, 31);
            this.nudProb1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudProb1.Name = "nudProb1";
            this.nudProb1.Size = new System.Drawing.Size(57, 20);
            this.nudProb1.TabIndex = 14;
            this.nudProb1.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // nudProb2
            // 
            this.nudProb2.DecimalPlaces = 2;
            this.nudProb2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudProb2.Location = new System.Drawing.Point(56, 60);
            this.nudProb2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudProb2.Name = "nudProb2";
            this.nudProb2.Size = new System.Drawing.Size(57, 20);
            this.nudProb2.TabIndex = 15;
            this.nudProb2.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // nudProb3
            // 
            this.nudProb3.DecimalPlaces = 2;
            this.nudProb3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudProb3.Location = new System.Drawing.Point(56, 91);
            this.nudProb3.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudProb3.Name = "nudProb3";
            this.nudProb3.Size = new System.Drawing.Size(57, 20);
            this.nudProb3.TabIndex = 16;
            this.nudProb3.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // nudProb4
            // 
            this.nudProb4.DecimalPlaces = 2;
            this.nudProb4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudProb4.Location = new System.Drawing.Point(56, 121);
            this.nudProb4.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudProb4.Name = "nudProb4";
            this.nudProb4.Size = new System.Drawing.Size(57, 20);
            this.nudProb4.TabIndex = 17;
            this.nudProb4.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // nudNumber
            // 
            this.nudNumber.Location = new System.Drawing.Point(15, 253);
            this.nudNumber.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudNumber.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new System.Drawing.Size(118, 20);
            this.nudNumber.TabIndex = 19;
            this.nudNumber.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // labelWarning
            // 
            this.labelWarning.AutoSize = true;
            this.labelWarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelWarning.Location = new System.Drawing.Point(41, 399);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(106, 39);
            this.labelWarning.TabIndex = 20;
            this.labelWarning.Text = "Wrong input, sum of\r\nfirst four values must \r\nbe less than 1.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 20);
            this.button1.TabIndex = 21;
            this.button1.Text = "auto";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelWarning);
            this.Controls.Add(this.nudNumber);
            this.Controls.Add(this.nudProb4);
            this.Controls.Add(this.nudProb3);
            this.Controls.Add(this.nudProb2);
            this.Controls.Add(this.nudProb1);
            this.Controls.Add(this.btCalculate);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btCalculate;
        private System.Windows.Forms.NumericUpDown nudProb1;
        private System.Windows.Forms.NumericUpDown nudProb2;
        private System.Windows.Forms.NumericUpDown nudProb3;
        private System.Windows.Forms.NumericUpDown nudProb4;
        private System.Windows.Forms.NumericUpDown nudNumber;
        private System.Windows.Forms.Label labelWarning;
        private System.Windows.Forms.Button button1;
    }
}

