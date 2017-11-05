namespace SoftwareEngineeringAssignment
{
    partial class frmAddPerscription
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
            this.cmbDrugID = new System.Windows.Forms.ComboBox();
            this.cmbDrugName = new System.Windows.Forms.ComboBox();
            this.txtDrugDescription = new System.Windows.Forms.RichTextBox();
            this.lblDrugID = new System.Windows.Forms.Label();
            this.lblDrugName = new System.Windows.Forms.Label();
            this.lblDrugDescription = new System.Windows.Forms.Label();
            this.txtNhsNum = new System.Windows.Forms.TextBox();
            this.lblNhsNum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.lblDoB = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnSearchPatients = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.mclStartDate = new System.Windows.Forms.MonthCalendar();
            this.mclEndDate = new System.Windows.Forms.MonthCalendar();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.RichTextBox();
            this.lblReason = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbDrugID
            // 
            this.cmbDrugID.FormattingEnabled = true;
            this.cmbDrugID.Location = new System.Drawing.Point(359, 27);
            this.cmbDrugID.Name = "cmbDrugID";
            this.cmbDrugID.Size = new System.Drawing.Size(121, 21);
            this.cmbDrugID.TabIndex = 0;
            this.cmbDrugID.SelectedValueChanged += new System.EventHandler(this.cmbDrugID_SelectedValueChanged);
            // 
            // cmbDrugName
            // 
            this.cmbDrugName.FormattingEnabled = true;
            this.cmbDrugName.Location = new System.Drawing.Point(359, 67);
            this.cmbDrugName.Name = "cmbDrugName";
            this.cmbDrugName.Size = new System.Drawing.Size(390, 21);
            this.cmbDrugName.TabIndex = 1;
            this.cmbDrugName.SelectedValueChanged += new System.EventHandler(this.cmbDrugName_SelectedValueChanged);
            // 
            // txtDrugDescription
            // 
            this.txtDrugDescription.Enabled = false;
            this.txtDrugDescription.Location = new System.Drawing.Point(359, 107);
            this.txtDrugDescription.Name = "txtDrugDescription";
            this.txtDrugDescription.Size = new System.Drawing.Size(390, 183);
            this.txtDrugDescription.TabIndex = 2;
            this.txtDrugDescription.Text = "";
            // 
            // lblDrugID
            // 
            this.lblDrugID.AutoSize = true;
            this.lblDrugID.Location = new System.Drawing.Point(356, 9);
            this.lblDrugID.Name = "lblDrugID";
            this.lblDrugID.Size = new System.Drawing.Size(44, 13);
            this.lblDrugID.TabIndex = 3;
            this.lblDrugID.Text = "Drug ID";
            // 
            // lblDrugName
            // 
            this.lblDrugName.AutoSize = true;
            this.lblDrugName.Location = new System.Drawing.Point(356, 51);
            this.lblDrugName.Name = "lblDrugName";
            this.lblDrugName.Size = new System.Drawing.Size(61, 13);
            this.lblDrugName.TabIndex = 4;
            this.lblDrugName.Text = "Drug Name";
            // 
            // lblDrugDescription
            // 
            this.lblDrugDescription.AutoSize = true;
            this.lblDrugDescription.Location = new System.Drawing.Point(356, 91);
            this.lblDrugDescription.Name = "lblDrugDescription";
            this.lblDrugDescription.Size = new System.Drawing.Size(86, 13);
            this.lblDrugDescription.TabIndex = 5;
            this.lblDrugDescription.Text = "Drug Description";
            // 
            // txtNhsNum
            // 
            this.txtNhsNum.Enabled = false;
            this.txtNhsNum.Location = new System.Drawing.Point(108, 9);
            this.txtNhsNum.Name = "txtNhsNum";
            this.txtNhsNum.Size = new System.Drawing.Size(100, 20);
            this.txtNhsNum.TabIndex = 32;
            // 
            // lblNhsNum
            // 
            this.lblNhsNum.AutoSize = true;
            this.lblNhsNum.Location = new System.Drawing.Point(12, 9);
            this.lblNhsNum.Name = "lblNhsNum";
            this.lblNhsNum.Size = new System.Drawing.Size(70, 13);
            this.lblNhsNum.TabIndex = 31;
            this.lblNhsNum.Text = "NHS Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Month";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Day";
            // 
            // cmbYear
            // 
            this.cmbYear.Enabled = false;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(176, 111);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(53, 21);
            this.cmbYear.TabIndex = 27;
            // 
            // cmbMonth
            // 
            this.cmbMonth.Enabled = false;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(130, 111);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(40, 21);
            this.cmbMonth.TabIndex = 26;
            // 
            // cmbDay
            // 
            this.cmbDay.Enabled = false;
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Location = new System.Drawing.Point(84, 111);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(40, 21);
            this.cmbDay.TabIndex = 25;
            // 
            // lblDoB
            // 
            this.lblDoB.AutoSize = true;
            this.lblDoB.Location = new System.Drawing.Point(12, 114);
            this.lblDoB.Name = "lblDoB";
            this.lblDoB.Size = new System.Drawing.Size(66, 13);
            this.lblDoB.TabIndex = 24;
            this.lblDoB.Text = "Date of Birth";
            // 
            // txtLastName
            // 
            this.txtLastName.Enabled = false;
            this.txtLastName.Location = new System.Drawing.Point(109, 61);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 23;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(13, 61);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 22;
            this.lblLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Enabled = false;
            this.txtFirstName.Location = new System.Drawing.Point(109, 35);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 21;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(13, 35);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 20;
            this.lblFirstName.Text = "First Name";
            // 
            // btnSearchPatients
            // 
            this.btnSearchPatients.Location = new System.Drawing.Point(244, 9);
            this.btnSearchPatients.Name = "btnSearchPatients";
            this.btnSearchPatients.Size = new System.Drawing.Size(75, 37);
            this.btnSearchPatients.TabIndex = 33;
            this.btnSearchPatients.Text = "Search For Patients";
            this.btnSearchPatients.UseVisualStyleBackColor = true;
            this.btnSearchPatients.Click += new System.EventHandler(this.btnSearchPatients_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(674, 427);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 37);
            this.btnSubmit.TabIndex = 34;
            this.btnSubmit.Text = "Submit Perscription";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // mclStartDate
            // 
            this.mclStartDate.Location = new System.Drawing.Point(12, 302);
            this.mclStartDate.Name = "mclStartDate";
            this.mclStartDate.TabIndex = 35;
            // 
            // mclEndDate
            // 
            this.mclEndDate.Location = new System.Drawing.Point(253, 302);
            this.mclEndDate.Name = "mclEndDate";
            this.mclEndDate.TabIndex = 36;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(17, 280);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(55, 13);
            this.lblStartDate.TabIndex = 37;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(250, 280);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(52, 13);
            this.lblEndDate.TabIndex = 38;
            this.lblEndDate.Text = "End Date";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(10, 160);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(343, 117);
            this.txtReason.TabIndex = 39;
            this.txtReason.Text = "";
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(12, 144);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(120, 13);
            this.lblReason.TabIndex = 40;
            this.lblReason.Text = "Reason For Perscription";
            // 
            // frmAddPerscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 477);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.mclEndDate);
            this.Controls.Add(this.mclStartDate);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnSearchPatients);
            this.Controls.Add(this.txtNhsNum);
            this.Controls.Add(this.lblNhsNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.cmbDay);
            this.Controls.Add(this.lblDoB);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblDrugDescription);
            this.Controls.Add(this.lblDrugName);
            this.Controls.Add(this.lblDrugID);
            this.Controls.Add(this.txtDrugDescription);
            this.Controls.Add(this.cmbDrugName);
            this.Controls.Add(this.cmbDrugID);
            this.Name = "frmAddPerscription";
            this.Text = "Add Perscription";
            this.Load += new System.EventHandler(this.frmAddPerscription_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDrugID;
        private System.Windows.Forms.ComboBox cmbDrugName;
        private System.Windows.Forms.RichTextBox txtDrugDescription;
        private System.Windows.Forms.Label lblDrugID;
        private System.Windows.Forms.Label lblDrugName;
        private System.Windows.Forms.Label lblDrugDescription;
        private System.Windows.Forms.TextBox txtNhsNum;
        private System.Windows.Forms.Label lblNhsNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ComboBox cmbDay;
        private System.Windows.Forms.Label lblDoB;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnSearchPatients;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.MonthCalendar mclStartDate;
        private System.Windows.Forms.MonthCalendar mclEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.RichTextBox txtReason;
        private System.Windows.Forms.Label lblReason;
    }
}