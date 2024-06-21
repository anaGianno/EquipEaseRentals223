namespace Deliverable2
{
    partial class ChartForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnRentalRecords = new System.Windows.Forms.Button();
            this.chartRental = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblRentalChart = new System.Windows.Forms.Label();
            this.cboxChart = new System.Windows.Forms.ComboBox();
            this.lblChartType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartRental)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRentalRecords
            // 
            this.btnRentalRecords.Location = new System.Drawing.Point(698, 415);
            this.btnRentalRecords.Name = "btnRentalRecords";
            this.btnRentalRecords.Size = new System.Drawing.Size(90, 23);
            this.btnRentalRecords.TabIndex = 0;
            this.btnRentalRecords.Text = "Rental Records";
            this.btnRentalRecords.UseVisualStyleBackColor = true;
            this.btnRentalRecords.Click += new System.EventHandler(this.btnRentalRecords_Click);
            // 
            // chartRental
            // 
            chartArea3.Name = "ChartArea1";
            this.chartRental.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartRental.Legends.Add(legend3);
            this.chartRental.Location = new System.Drawing.Point(44, 79);
            this.chartRental.Name = "chartRental";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartRental.Series.Add(series3);
            this.chartRental.Size = new System.Drawing.Size(713, 330);
            this.chartRental.TabIndex = 1;
            this.chartRental.Text = "chartRental";
            // 
            // lblRentalChart
            // 
            this.lblRentalChart.AutoSize = true;
            this.lblRentalChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalChart.Location = new System.Drawing.Point(250, 25);
            this.lblRentalChart.Name = "lblRentalChart";
            this.lblRentalChart.Size = new System.Drawing.Size(227, 42);
            this.lblRentalChart.TabIndex = 18;
            this.lblRentalChart.Text = "Rental Chart";
            // 
            // cboxChart
            // 
            this.cboxChart.FormattingEnabled = true;
            this.cboxChart.Items.AddRange(new object[] {
            "Line",
            "Bar",
            "Point",
            "Column",
            "Pie",
            "Bubble"});
            this.cboxChart.Location = new System.Drawing.Point(585, 45);
            this.cboxChart.Name = "cboxChart";
            this.cboxChart.Size = new System.Drawing.Size(121, 21);
            this.cboxChart.TabIndex = 19;
            this.cboxChart.Text = "Select a chart type";
            this.cboxChart.SelectedIndexChanged += new System.EventHandler(this.cboxChart_SelectedIndexChanged);
            // 
            // lblChartType
            // 
            this.lblChartType.AutoSize = true;
            this.lblChartType.Location = new System.Drawing.Point(526, 49);
            this.lblChartType.Name = "lblChartType";
            this.lblChartType.Size = new System.Drawing.Size(53, 13);
            this.lblChartType.TabIndex = 20;
            this.lblChartType.Text = "Cart Type";
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblChartType);
            this.Controls.Add(this.cboxChart);
            this.Controls.Add(this.lblRentalChart);
            this.Controls.Add(this.chartRental);
            this.Controls.Add(this.btnRentalRecords);
            this.Name = "ChartForm";
            this.Text = "ChartForm";
            ((System.ComponentModel.ISupportInitialize)(this.chartRental)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRentalRecords;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRental;
        private System.Windows.Forms.Label lblRentalChart;
        private System.Windows.Forms.ComboBox cboxChart;
        private System.Windows.Forms.Label lblChartType;
    }
}