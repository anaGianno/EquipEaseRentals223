namespace Deliverable2
{
    partial class RentalRecords
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
            this.listBoxDisplay = new System.Windows.Forms.ListBox();
            this.lblRecords = new System.Windows.Forms.Label();
            this.rbtnFilterUp = new System.Windows.Forms.RadioButton();
            this.lblFilter = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.rbtnFilterAll = new System.Windows.Forms.RadioButton();
            this.rbtnFilterPast = new System.Windows.Forms.RadioButton();
            this.rbtnFilterOn = new System.Windows.Forms.RadioButton();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnSummary = new System.Windows.Forms.Button();
            this.btnChart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxDisplay
            // 
            this.listBoxDisplay.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDisplay.FormattingEnabled = true;
            this.listBoxDisplay.ItemHeight = 14;
            this.listBoxDisplay.Location = new System.Drawing.Point(12, 88);
            this.listBoxDisplay.Name = "listBoxDisplay";
            this.listBoxDisplay.Size = new System.Drawing.Size(1247, 550);
            this.listBoxDisplay.TabIndex = 0;
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(369, 10);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(370, 55);
            this.lblRecords.TabIndex = 1;
            this.lblRecords.Text = "Rental Records";
            // 
            // rbtnFilterUp
            // 
            this.rbtnFilterUp.AutoSize = true;
            this.rbtnFilterUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFilterUp.Location = new System.Drawing.Point(12, 58);
            this.rbtnFilterUp.Name = "rbtnFilterUp";
            this.rbtnFilterUp.Size = new System.Drawing.Size(151, 24);
            this.rbtnFilterUp.TabIndex = 2;
            this.rbtnFilterUp.Text = "Upcoming rentals";
            this.rbtnFilterUp.UseVisualStyleBackColor = true;
            this.rbtnFilterUp.CheckedChanged += new System.EventHandler(this.rbtnFilterUp_CheckedChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(8, 1);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(57, 24);
            this.lblFilter.TabIndex = 3;
            this.lblFilter.Text = "Filter";
            // 
            // rbtnFilterAll
            // 
            this.rbtnFilterAll.AutoSize = true;
            this.rbtnFilterAll.Checked = true;
            this.rbtnFilterAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFilterAll.Location = new System.Drawing.Point(12, 28);
            this.rbtnFilterAll.Name = "rbtnFilterAll";
            this.rbtnFilterAll.Size = new System.Drawing.Size(96, 24);
            this.rbtnFilterAll.TabIndex = 4;
            this.rbtnFilterAll.TabStop = true;
            this.rbtnFilterAll.Text = "All rentals";
            this.rbtnFilterAll.UseVisualStyleBackColor = true;
            this.rbtnFilterAll.CheckedChanged += new System.EventHandler(this.rbtnFilterAll_CheckedChanged);
            // 
            // rbtnFilterPast
            // 
            this.rbtnFilterPast.AutoSize = true;
            this.rbtnFilterPast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFilterPast.Location = new System.Drawing.Point(171, 28);
            this.rbtnFilterPast.Name = "rbtnFilterPast";
            this.rbtnFilterPast.Size = new System.Drawing.Size(118, 24);
            this.rbtnFilterPast.TabIndex = 5;
            this.rbtnFilterPast.Text = "Past Rentals";
            this.rbtnFilterPast.UseVisualStyleBackColor = true;
            this.rbtnFilterPast.CheckedChanged += new System.EventHandler(this.rbtnFilterPast_CheckedChanged);
            // 
            // rbtnFilterOn
            // 
            this.rbtnFilterOn.AutoSize = true;
            this.rbtnFilterOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFilterOn.Location = new System.Drawing.Point(171, 58);
            this.rbtnFilterOn.Name = "rbtnFilterOn";
            this.rbtnFilterOn.Size = new System.Drawing.Size(146, 24);
            this.rbtnFilterOn.TabIndex = 6;
            this.rbtnFilterOn.Text = "Ongoing Rentals";
            this.rbtnFilterOn.UseVisualStyleBackColor = true;
            this.rbtnFilterOn.CheckedChanged += new System.EventHandler(this.rbtnFilterOn_CheckedChanged);
            // 
            // btnBooking
            // 
            this.btnBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.Location = new System.Drawing.Point(943, 10);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(155, 33);
            this.btnBooking.TabIndex = 7;
            this.btnBooking.Text = "Book Equipment";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(1104, 10);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(155, 33);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(943, 49);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(155, 33);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "Return Equipment";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnSummary
            // 
            this.btnSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSummary.Location = new System.Drawing.Point(1104, 49);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(155, 33);
            this.btnSummary.TabIndex = 10;
            this.btnSummary.Text = "Summary Report";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // btnChart
            // 
            this.btnChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChart.Location = new System.Drawing.Point(782, 49);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(155, 33);
            this.btnChart.TabIndex = 11;
            this.btnChart.Text = "Chart";
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // RentalRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 653);
            this.Controls.Add(this.btnChart);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.rbtnFilterOn);
            this.Controls.Add(this.rbtnFilterPast);
            this.Controls.Add(this.rbtnFilterAll);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.rbtnFilterUp);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.listBoxDisplay);
            this.Name = "RentalRecords";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDisplay;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.RadioButton rbtnFilterUp;
        private System.Windows.Forms.Label lblFilter;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton rbtnFilterAll;
        private System.Windows.Forms.RadioButton rbtnFilterPast;
        private System.Windows.Forms.RadioButton rbtnFilterOn;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.Button btnChart;
    }
}

