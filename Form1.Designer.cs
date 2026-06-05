namespace Graph_Project
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.UpdateButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.EqLabel = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.X_bounds = new System.Windows.Forms.TextBox();
            this.Y_bounds = new System.Windows.Forms.TextBox();
            this.XboLabel = new System.Windows.Forms.Label();
            this.YboLabel = new System.Windows.Forms.Label();
            this.XYcoords = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpdateButton.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.UpdateButton.Location = new System.Drawing.Point(277, 389);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(149, 66);
            this.UpdateButton.TabIndex = 0;
            this.UpdateButton.Text = "Go!";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Lavender;
            this.textBox1.Location = new System.Drawing.Point(277, 353);
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(511, 30);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "y = x";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // EqLabel
            // 
            this.EqLabel.AutoSize = true;
            this.EqLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.EqLabel.Location = new System.Drawing.Point(49, 353);
            this.EqLabel.Name = "EqLabel";
            this.EqLabel.Size = new System.Drawing.Size(213, 24);
            this.EqLabel.TabIndex = 2;
            this.EqLabel.Text = "Enter Equation (x,y):";
            this.EqLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisX.Interval = 10D;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.ScaleBreakStyle.Enabled = true;
            chartArea1.AxisX.ScaleBreakStyle.LineWidth = 2;
            chartArea1.AxisX.ScaleBreakStyle.StartFromZero = System.Windows.Forms.DataVisualization.Charting.StartFromZero.No;
            chartArea1.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisX.Title = "X";
            chartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Near;
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisY.Title = "Y";
            chartArea1.AxisY.TitleAlignment = System.Drawing.StringAlignment.Near;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 80F;
            chartArea1.InnerPlotPosition.Width = 85F;
            chartArea1.InnerPlotPosition.X = 15F;
            chartArea1.InnerPlotPosition.Y = 5F;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 90F;
            chartArea1.Position.Width = 80F;
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(15, 12);
            this.chart1.Name = "chart1";
            series1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(760, 335);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "Graph";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            this.chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Chart_MouseMove);
            // 
            // X_bounds
            // 
            this.X_bounds.BackColor = System.Drawing.SystemColors.InfoText;
            this.X_bounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X_bounds.ForeColor = System.Drawing.Color.Lavender;
            this.X_bounds.Location = new System.Drawing.Point(171, 380);
            this.X_bounds.Name = "X_bounds";
            this.X_bounds.Size = new System.Drawing.Size(100, 30);
            this.X_bounds.TabIndex = 4;
            this.X_bounds.Text = "(-10,10)";
            this.X_bounds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Y_bounds
            // 
            this.Y_bounds.BackColor = System.Drawing.SystemColors.InfoText;
            this.Y_bounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Y_bounds.ForeColor = System.Drawing.Color.Lavender;
            this.Y_bounds.Location = new System.Drawing.Point(171, 416);
            this.Y_bounds.Name = "Y_bounds";
            this.Y_bounds.Size = new System.Drawing.Size(100, 30);
            this.Y_bounds.TabIndex = 5;
            this.Y_bounds.Text = "(-10,10)";
            this.Y_bounds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Y_bounds.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // XboLabel
            // 
            this.XboLabel.AutoSize = true;
            this.XboLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XboLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.XboLabel.Location = new System.Drawing.Point(17, 384);
            this.XboLabel.Name = "XboLabel";
            this.XboLabel.Size = new System.Drawing.Size(135, 24);
            this.XboLabel.TabIndex = 6;
            this.XboLabel.Text = "x (min,max):";
            this.XboLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // YboLabel
            // 
            this.YboLabel.AutoSize = true;
            this.YboLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YboLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.YboLabel.Location = new System.Drawing.Point(17, 417);
            this.YboLabel.Name = "YboLabel";
            this.YboLabel.Size = new System.Drawing.Size(136, 24);
            this.YboLabel.TabIndex = 7;
            this.YboLabel.Text = "y (min,max):";
            this.YboLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // XYcoords
            // 
            this.XYcoords.BackColor = System.Drawing.Color.Red;
            this.XYcoords.ForeColor = System.Drawing.Color.RoyalBlue;
            this.XYcoords.IsBalloon = true;
            this.XYcoords.OwnerDraw = true;
            this.XYcoords.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.YboLabel);
            this.Controls.Add(this.XboLabel);
            this.Controls.Add(this.Y_bounds);
            this.Controls.Add(this.X_bounds);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.EqLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.UpdateButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Graphing Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label EqLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox X_bounds;
        private System.Windows.Forms.TextBox Y_bounds;
        private System.Windows.Forms.Label XboLabel;
        private System.Windows.Forms.Label YboLabel;
        private System.Windows.Forms.ToolTip XYcoords;
    }
}

