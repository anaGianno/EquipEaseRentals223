namespace Deliverable2
{
    partial class CreateBooking
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
            this.cboxEquipName = new System.Windows.Forms.ComboBox();
            this.cboxPickBranch = new System.Windows.Forms.ComboBox();
            this.lblEquipName = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblPickBranch = new System.Windows.Forms.Label();
            this.lblBooking = new System.Windows.Forms.Label();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.btnCreateBooking = new System.Windows.Forms.Button();
            this.btnRentalRecords = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblEquipID = new System.Windows.Forms.Label();
            this.cboxEquipID = new System.Windows.Forms.ComboBox();
            this.btnGetEquipID = new System.Windows.Forms.Button();
            this.btnRecent = new System.Windows.Forms.Button();
            this.lblSort = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboxEquipName
            // 
            this.cboxEquipName.FormattingEnabled = true;
            this.cboxEquipName.Location = new System.Drawing.Point(196, 125);
            this.cboxEquipName.Name = "cboxEquipName";
            this.cboxEquipName.Size = new System.Drawing.Size(165, 21);
            this.cboxEquipName.TabIndex = 0;
            // 
            // cboxPickBranch
            // 
            this.cboxPickBranch.FormattingEnabled = true;
            this.cboxPickBranch.Location = new System.Drawing.Point(196, 98);
            this.cboxPickBranch.Name = "cboxPickBranch";
            this.cboxPickBranch.Size = new System.Drawing.Size(165, 21);
            this.cboxPickBranch.TabIndex = 2;
            // 
            // lblEquipName
            // 
            this.lblEquipName.AutoSize = true;
            this.lblEquipName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipName.Location = new System.Drawing.Point(54, 126);
            this.lblEquipName.Name = "lblEquipName";
            this.lblEquipName.Size = new System.Drawing.Size(134, 20);
            this.lblEquipName.TabIndex = 3;
            this.lblEquipName.Text = "Equipment name:";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartTime.Location = new System.Drawing.Point(108, 180);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(82, 20);
            this.lblStartTime.TabIndex = 4;
            this.lblStartTime.Text = "Start time:";
            // 
            // lblPickBranch
            // 
            this.lblPickBranch.AutoSize = true;
            this.lblPickBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPickBranch.Location = new System.Drawing.Point(72, 99);
            this.lblPickBranch.Name = "lblPickBranch";
            this.lblPickBranch.Size = new System.Drawing.Size(118, 20);
            this.lblPickBranch.TabIndex = 5;
            this.lblPickBranch.Text = "Pick-up branch:";
            // 
            // lblBooking
            // 
            this.lblBooking.AutoSize = true;
            this.lblBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooking.Location = new System.Drawing.Point(44, 35);
            this.lblBooking.Name = "lblBooking";
            this.lblBooking.Size = new System.Drawing.Size(342, 42);
            this.lblBooking.TabIndex = 6;
            this.lblBooking.Text = "Booking Equipment";
            // 
            // txtStartTime
            // 
            this.txtStartTime.Location = new System.Drawing.Point(196, 179);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(165, 20);
            this.txtStartTime.TabIndex = 7;
            // 
            // btnCreateBooking
            // 
            this.btnCreateBooking.Location = new System.Drawing.Point(196, 260);
            this.btnCreateBooking.Name = "btnCreateBooking";
            this.btnCreateBooking.Size = new System.Drawing.Size(165, 23);
            this.btnCreateBooking.TabIndex = 8;
            this.btnCreateBooking.Text = "Create Booking";
            this.btnCreateBooking.UseVisualStyleBackColor = true;
            this.btnCreateBooking.Click += new System.EventHandler(this.btnCreateBooking_Click);
            // 
            // btnRentalRecords
            // 
            this.btnRentalRecords.Location = new System.Drawing.Point(196, 289);
            this.btnRentalRecords.Name = "btnRentalRecords";
            this.btnRentalRecords.Size = new System.Drawing.Size(165, 23);
            this.btnRentalRecords.TabIndex = 9;
            this.btnRentalRecords.Text = "Rental Records";
            this.btnRentalRecords.UseVisualStyleBackColor = true;
            this.btnRentalRecords.Click += new System.EventHandler(this.btnRentalRecords_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(196, 205);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(165, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(138, 205);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email:";
            // 
            // lblEquipID
            // 
            this.lblEquipID.AutoSize = true;
            this.lblEquipID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipID.Location = new System.Drawing.Point(79, 153);
            this.lblEquipID.Name = "lblEquipID";
            this.lblEquipID.Size = new System.Drawing.Size(111, 20);
            this.lblEquipID.TabIndex = 13;
            this.lblEquipID.Text = "Equipment ID:";
            // 
            // cboxEquipID
            // 
            this.cboxEquipID.FormattingEnabled = true;
            this.cboxEquipID.Location = new System.Drawing.Point(196, 152);
            this.cboxEquipID.Name = "cboxEquipID";
            this.cboxEquipID.Size = new System.Drawing.Size(165, 21);
            this.cboxEquipID.TabIndex = 12;
            // 
            // btnGetEquipID
            // 
            this.btnGetEquipID.Location = new System.Drawing.Point(196, 231);
            this.btnGetEquipID.Name = "btnGetEquipID";
            this.btnGetEquipID.Size = new System.Drawing.Size(165, 23);
            this.btnGetEquipID.TabIndex = 14;
            this.btnGetEquipID.Text = "Get equipment ID";
            this.btnGetEquipID.UseVisualStyleBackColor = true;
            this.btnGetEquipID.Click += new System.EventHandler(this.btnGetEquipID_Click);
            // 
            // btnRecent
            // 
            this.btnRecent.Location = new System.Drawing.Point(196, 363);
            this.btnRecent.Name = "btnRecent";
            this.btnRecent.Size = new System.Drawing.Size(165, 23);
            this.btnRecent.TabIndex = 15;
            this.btnRecent.Text = "Recently purchased ";
            this.btnRecent.UseVisualStyleBackColor = true;
            this.btnRecent.Click += new System.EventHandler(this.btnRecent_Click);
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSort.Location = new System.Drawing.Point(199, 344);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(162, 16);
            this.lblSort.TabIndex = 16;
            this.lblSort.Text = "Sort branch equipment by:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(196, 318);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(165, 23);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear all";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // CreateBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 409);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.btnRecent);
            this.Controls.Add(this.btnGetEquipID);
            this.Controls.Add(this.lblEquipID);
            this.Controls.Add(this.cboxEquipID);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnRentalRecords);
            this.Controls.Add(this.btnCreateBooking);
            this.Controls.Add(this.txtStartTime);
            this.Controls.Add(this.lblBooking);
            this.Controls.Add(this.lblPickBranch);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.lblEquipName);
            this.Controls.Add(this.cboxPickBranch);
            this.Controls.Add(this.cboxEquipName);
            this.Name = "CreateBooking";
            this.Text = "CreateBooking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxEquipName;
        private System.Windows.Forms.ComboBox cboxPickBranch;
        private System.Windows.Forms.Label lblEquipName;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblPickBranch;
        private System.Windows.Forms.Label lblBooking;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.Button btnCreateBooking;
        private System.Windows.Forms.Button btnRentalRecords;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblEquipID;
        private System.Windows.Forms.ComboBox cboxEquipID;
        private System.Windows.Forms.Button btnGetEquipID;
        private System.Windows.Forms.Button btnRecent;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.Button btnClear;
    }
}