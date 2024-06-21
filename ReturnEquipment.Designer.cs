namespace Deliverable2
{
    partial class ReturnEquipment
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
            this.lblBranchReturn = new System.Windows.Forms.Label();
            this.btnRentalRecords = new System.Windows.Forms.Button();
            this.txtReturnTime = new System.Windows.Forms.TextBox();
            this.lblReturn = new System.Windows.Forms.Label();
            this.lblReturnTime = new System.Windows.Forms.Label();
            this.lblRentalID = new System.Windows.Forms.Label();
            this.lblEquipID = new System.Windows.Forms.Label();
            this.cboxBranchReturn = new System.Windows.Forms.ComboBox();
            this.cboxRentalID = new System.Windows.Forms.ComboBox();
            this.cboxEquipID = new System.Windows.Forms.ComboBox();
            this.btnGetBranch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnGetRentalID = new System.Windows.Forms.Button();
            this.btnRecordReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBranchReturn
            // 
            this.lblBranchReturn.AutoSize = true;
            this.lblBranchReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBranchReturn.Location = new System.Drawing.Point(38, 148);
            this.lblBranchReturn.Name = "lblBranchReturn";
            this.lblBranchReturn.Size = new System.Drawing.Size(146, 20);
            this.lblBranchReturn.TabIndex = 21;
            this.lblBranchReturn.Text = "Branch to return to:";
            // 
            // btnRentalRecords
            // 
            this.btnRentalRecords.Location = new System.Drawing.Point(190, 317);
            this.btnRentalRecords.Name = "btnRentalRecords";
            this.btnRentalRecords.Size = new System.Drawing.Size(165, 23);
            this.btnRentalRecords.TabIndex = 20;
            this.btnRentalRecords.Text = "Rental Records";
            this.btnRentalRecords.UseVisualStyleBackColor = true;
            this.btnRentalRecords.Click += new System.EventHandler(this.btnRentalRecords_Click);
            // 
            // txtReturnTime
            // 
            this.txtReturnTime.Location = new System.Drawing.Point(190, 175);
            this.txtReturnTime.Name = "txtReturnTime";
            this.txtReturnTime.Size = new System.Drawing.Size(165, 20);
            this.txtReturnTime.TabIndex = 18;
            // 
            // lblReturn
            // 
            this.lblReturn.AutoSize = true;
            this.lblReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturn.Location = new System.Drawing.Point(57, 27);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(318, 42);
            this.lblReturn.TabIndex = 17;
            this.lblReturn.Text = "Return Equipment";
            // 
            // lblReturnTime
            // 
            this.lblReturnTime.AutoSize = true;
            this.lblReturnTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnTime.Location = new System.Drawing.Point(88, 175);
            this.lblReturnTime.Name = "lblReturnTime";
            this.lblReturnTime.Size = new System.Drawing.Size(96, 20);
            this.lblReturnTime.TabIndex = 16;
            this.lblReturnTime.Text = "Return time:";
            // 
            // lblRentalID
            // 
            this.lblRentalID.AutoSize = true;
            this.lblRentalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalID.Location = new System.Drawing.Point(102, 122);
            this.lblRentalID.Name = "lblRentalID";
            this.lblRentalID.Size = new System.Drawing.Size(81, 20);
            this.lblRentalID.TabIndex = 15;
            this.lblRentalID.Text = "Rental ID:";
            // 
            // lblEquipID
            // 
            this.lblEquipID.AutoSize = true;
            this.lblEquipID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipID.Location = new System.Drawing.Point(73, 95);
            this.lblEquipID.Name = "lblEquipID";
            this.lblEquipID.Size = new System.Drawing.Size(111, 20);
            this.lblEquipID.TabIndex = 14;
            this.lblEquipID.Text = "Equipment ID:";
            // 
            // cboxBranchReturn
            // 
            this.cboxBranchReturn.FormattingEnabled = true;
            this.cboxBranchReturn.Location = new System.Drawing.Point(190, 148);
            this.cboxBranchReturn.Name = "cboxBranchReturn";
            this.cboxBranchReturn.Size = new System.Drawing.Size(165, 21);
            this.cboxBranchReturn.TabIndex = 12;
            // 
            // cboxRentalID
            // 
            this.cboxRentalID.FormattingEnabled = true;
            this.cboxRentalID.Location = new System.Drawing.Point(190, 121);
            this.cboxRentalID.Name = "cboxRentalID";
            this.cboxRentalID.Size = new System.Drawing.Size(165, 21);
            this.cboxRentalID.TabIndex = 22;
            // 
            // cboxEquipID
            // 
            this.cboxEquipID.FormattingEnabled = true;
            this.cboxEquipID.Location = new System.Drawing.Point(190, 94);
            this.cboxEquipID.Name = "cboxEquipID";
            this.cboxEquipID.Size = new System.Drawing.Size(165, 21);
            this.cboxEquipID.TabIndex = 23;
            // 
            // btnGetBranch
            // 
            this.btnGetBranch.Location = new System.Drawing.Point(190, 230);
            this.btnGetBranch.Name = "btnGetBranch";
            this.btnGetBranch.Size = new System.Drawing.Size(165, 23);
            this.btnGetBranch.TabIndex = 24;
            this.btnGetBranch.Text = "Get branch";
            this.btnGetBranch.UseVisualStyleBackColor = true;
            this.btnGetBranch.Click += new System.EventHandler(this.btnGetBranch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(190, 288);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(165, 23);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "Clear all";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnGetRentalID
            // 
            this.btnGetRentalID.Location = new System.Drawing.Point(190, 201);
            this.btnGetRentalID.Name = "btnGetRentalID";
            this.btnGetRentalID.Size = new System.Drawing.Size(165, 23);
            this.btnGetRentalID.TabIndex = 27;
            this.btnGetRentalID.Text = "Get rental ID";
            this.btnGetRentalID.UseVisualStyleBackColor = true;
            this.btnGetRentalID.Click += new System.EventHandler(this.btnGetRentalID_Click);
            // 
            // btnRecordReturn
            // 
            this.btnRecordReturn.Location = new System.Drawing.Point(190, 259);
            this.btnRecordReturn.Name = "btnRecordReturn";
            this.btnRecordReturn.Size = new System.Drawing.Size(165, 23);
            this.btnRecordReturn.TabIndex = 28;
            this.btnRecordReturn.Text = "Record return";
            this.btnRecordReturn.UseVisualStyleBackColor = true;
            this.btnRecordReturn.Click += new System.EventHandler(this.btnRecordReturn_Click_1);
            // 
            // ReturnEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 354);
            this.Controls.Add(this.btnRecordReturn);
            this.Controls.Add(this.btnGetRentalID);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGetBranch);
            this.Controls.Add(this.cboxEquipID);
            this.Controls.Add(this.cboxRentalID);
            this.Controls.Add(this.lblBranchReturn);
            this.Controls.Add(this.btnRentalRecords);
            this.Controls.Add(this.txtReturnTime);
            this.Controls.Add(this.lblReturn);
            this.Controls.Add(this.lblReturnTime);
            this.Controls.Add(this.lblRentalID);
            this.Controls.Add(this.lblEquipID);
            this.Controls.Add(this.cboxBranchReturn);
            this.Name = "ReturnEquipment";
            this.Text = "ReturnEquipment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBranchReturn;
        private System.Windows.Forms.Button btnRentalRecords;
        private System.Windows.Forms.TextBox txtReturnTime;
        private System.Windows.Forms.Label lblReturn;
        private System.Windows.Forms.Label lblReturnTime;
        private System.Windows.Forms.Label lblRentalID;
        private System.Windows.Forms.Label lblEquipID;
        private System.Windows.Forms.ComboBox cboxBranchReturn;
        private System.Windows.Forms.ComboBox cboxRentalID;
        private System.Windows.Forms.ComboBox cboxEquipID;
        private System.Windows.Forms.Button btnGetBranch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnGetRentalID;
        private System.Windows.Forms.Button btnRecordReturn;
    }
}