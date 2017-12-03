namespace SoftwareEngineeringAssignment
{
    partial class frmViewTest
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
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblDoB = new System.Windows.Forms.Label();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printTestHistory = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblTestReason = new System.Windows.Forms.Label();
            this.txtTestReason = new System.Windows.Forms.RichTextBox();
            this.txtTestResult = new System.Windows.Forms.RichTextBox();
            this.lblTestResult = new System.Windows.Forms.Label();
            this.mclDateOfTest = new System.Windows.Forms.MonthCalendar();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 31);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(54, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Patient ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(100, 28);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(12, 71);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(100, 68);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(12, 110);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(100, 110);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 5;
            // 
            // lblDoB
            // 
            this.lblDoB.AutoSize = true;
            this.lblDoB.Location = new System.Drawing.Point(12, 185);
            this.lblDoB.Name = "lblDoB";
            this.lblDoB.Size = new System.Drawing.Size(65, 13);
            this.lblDoB.TabIndex = 8;
            this.lblDoB.Text = "Date Of Bith";
            // 
            // cmbDay
            // 
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Location = new System.Drawing.Point(100, 185);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(34, 21);
            this.cmbDay.TabIndex = 9;
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(140, 185);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(43, 21);
            this.cmbMonth.TabIndex = 10;
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(189, 185);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(44, 21);
            this.cmbYear.TabIndex = 11;
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(97, 169);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(26, 13);
            this.lblDay.TabIndex = 12;
            this.lblDay.Text = "Day";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(137, 169);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(37, 13);
            this.lblMonth.TabIndex = 13;
            this.lblMonth.Text = "Month";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(186, 169);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 14;
            this.lblYear.Text = "Year";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(466, 295);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 41);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search For Patient";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(466, 371);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 16;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printTestHistory
            // 
            this.printTestHistory.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printTestHistory_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(466, 342);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 17;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click_1);
            // 
            // lblTestReason
            // 
            this.lblTestReason.AutoSize = true;
            this.lblTestReason.Location = new System.Drawing.Point(278, 18);
            this.lblTestReason.Name = "lblTestReason";
            this.lblTestReason.Size = new System.Drawing.Size(68, 13);
            this.lblTestReason.TabIndex = 23;
            this.lblTestReason.Text = "Test Reason";
            // 
            // txtTestReason
            // 
            this.txtTestReason.Location = new System.Drawing.Point(278, 45);
            this.txtTestReason.Name = "txtTestReason";
            this.txtTestReason.Size = new System.Drawing.Size(263, 67);
            this.txtTestReason.TabIndex = 22;
            this.txtTestReason.Text = "";
            // 
            // txtTestResult
            // 
            this.txtTestResult.Location = new System.Drawing.Point(278, 148);
            this.txtTestResult.Name = "txtTestResult";
            this.txtTestResult.Size = new System.Drawing.Size(263, 76);
            this.txtTestResult.TabIndex = 21;
            this.txtTestResult.Text = "";
            // 
            // lblTestResult
            // 
            this.lblTestResult.AutoSize = true;
            this.lblTestResult.Location = new System.Drawing.Point(275, 121);
            this.lblTestResult.Name = "lblTestResult";
            this.lblTestResult.Size = new System.Drawing.Size(61, 13);
            this.lblTestResult.TabIndex = 20;
            this.lblTestResult.Text = "Test Result";
            // 
            // mclDateOfTest
            // 
            this.mclDateOfTest.Location = new System.Drawing.Point(15, 218);
            this.mclDateOfTest.Name = "mclDateOfTest";
            this.mclDateOfTest.TabIndex = 24;
            // 
            // btnBack
            // 
            this.btnBack.Enabled = false;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnBack.Location = new System.Drawing.Point(374, 354);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 40);
            this.btnBack.TabIndex = 33;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnForward
            // 
            this.btnForward.Enabled = false;
            this.btnForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnForward.Location = new System.Drawing.Point(420, 354);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(40, 40);
            this.btnForward.TabIndex = 32;
            this.btnForward.Text = ">";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(374, 295);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 53);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "Update Test";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmViewTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 406);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.mclDateOfTest);
            this.Controls.Add(this.lblTestReason);
            this.Controls.Add(this.txtTestReason);
            this.Controls.Add(this.txtTestResult);
            this.Controls.Add(this.lblTestResult);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.cmbDay);
            this.Controls.Add(this.lblDoB);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Name = "frmViewTest";
            this.Text = "frmViewTest";
            this.VisibleChanged += new System.EventHandler(this.frmViewTest_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblDoB;
        private System.Windows.Forms.ComboBox cmbDay;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printTestHistory;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblTestReason;
        private System.Windows.Forms.RichTextBox txtTestReason;
        private System.Windows.Forms.RichTextBox txtTestResult;
        private System.Windows.Forms.Label lblTestResult;
        private System.Windows.Forms.MonthCalendar mclDateOfTest;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnUpdate;
    }
}