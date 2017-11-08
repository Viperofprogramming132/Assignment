namespace SoftwareEngineeringAssignment
{
    partial class frmTimetable
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
            this.mclTimeTable = new System.Windows.Forms.MonthCalendar();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblCurrentStaffMember = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.cmbStartTime = new System.Windows.Forms.ComboBox();
            this.cmbEndTime = new System.Windows.Forms.ComboBox();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mclTimeTable
            // 
            this.mclTimeTable.Location = new System.Drawing.Point(13, 13);
            this.mclTimeTable.Name = "mclTimeTable";
            this.mclTimeTable.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(253, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search Staff";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblCurrentStaffMember
            // 
            this.lblCurrentStaffMember.AutoSize = true;
            this.lblCurrentStaffMember.Location = new System.Drawing.Point(334, 18);
            this.lblCurrentStaffMember.Name = "lblCurrentStaffMember";
            this.lblCurrentStaffMember.Size = new System.Drawing.Size(89, 13);
            this.lblCurrentStaffMember.TabIndex = 2;
            this.lblCurrentStaffMember.Text = "lblCurrentMember";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(252, 39);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(55, 13);
            this.lblStartTime.TabIndex = 3;
            this.lblStartTime.Text = "Start Time";
            // 
            // cmbStartTime
            // 
            this.cmbStartTime.FormattingEnabled = true;
            this.cmbStartTime.Location = new System.Drawing.Point(255, 56);
            this.cmbStartTime.Name = "cmbStartTime";
            this.cmbStartTime.Size = new System.Drawing.Size(121, 21);
            this.cmbStartTime.TabIndex = 4;
            // 
            // cmbEndTime
            // 
            this.cmbEndTime.FormattingEnabled = true;
            this.cmbEndTime.Location = new System.Drawing.Point(255, 99);
            this.cmbEndTime.Name = "cmbEndTime";
            this.cmbEndTime.Size = new System.Drawing.Size(121, 21);
            this.cmbEndTime.TabIndex = 6;
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(252, 82);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(52, 13);
            this.lblEndTime.TabIndex = 5;
            this.lblEndTime.Text = "End Time";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(255, 126);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmTimetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 394);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cmbEndTime);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.cmbStartTime);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.lblCurrentStaffMember);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.mclTimeTable);
            this.Name = "frmTimetable";
            this.Text = "frmTimetable";
            this.VisibleChanged += new System.EventHandler(this.frmTimetable_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mclTimeTable;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblCurrentStaffMember;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.ComboBox cmbStartTime;
        private System.Windows.Forms.ComboBox cmbEndTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Button btnSubmit;
    }
}