namespace SoftwareEngineeringAssignment
{
    partial class frmViewAppointments
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
            this.txtNextOfKin = new System.Windows.Forms.TextBox();
            this.lblNextOfKin = new System.Windows.Forms.Label();
            this.txtAllergies = new System.Windows.Forms.TextBox();
            this.lblAllergies = new System.Windows.Forms.Label();
            this.txtReligion = new System.Windows.Forms.TextBox();
            this.lblReligion = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.lsvAppointments = new System.Windows.Forms.ListView();
            this.lblAppointments = new System.Windows.Forms.Label();
            this.lsvPerscriptions = new System.Windows.Forms.ListView();
            this.lblPerscriptions = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.lblDoB = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNextOfKin
            // 
            this.txtNextOfKin.Enabled = false;
            this.txtNextOfKin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNextOfKin.Location = new System.Drawing.Point(140, 663);
            this.txtNextOfKin.Name = "txtNextOfKin";
            this.txtNextOfKin.Size = new System.Drawing.Size(205, 30);
            this.txtNextOfKin.TabIndex = 65;
            // 
            // lblNextOfKin
            // 
            this.lblNextOfKin.AutoSize = true;
            this.lblNextOfKin.Enabled = false;
            this.lblNextOfKin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextOfKin.Location = new System.Drawing.Point(13, 668);
            this.lblNextOfKin.Name = "lblNextOfKin";
            this.lblNextOfKin.Size = new System.Drawing.Size(112, 25);
            this.lblNextOfKin.TabIndex = 64;
            this.lblNextOfKin.Text = "Next Of Kin";
            // 
            // txtAllergies
            // 
            this.txtAllergies.Enabled = false;
            this.txtAllergies.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAllergies.Location = new System.Drawing.Point(140, 620);
            this.txtAllergies.Name = "txtAllergies";
            this.txtAllergies.Size = new System.Drawing.Size(205, 30);
            this.txtAllergies.TabIndex = 63;
            // 
            // lblAllergies
            // 
            this.lblAllergies.AutoSize = true;
            this.lblAllergies.Enabled = false;
            this.lblAllergies.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllergies.Location = new System.Drawing.Point(13, 620);
            this.lblAllergies.Name = "lblAllergies";
            this.lblAllergies.Size = new System.Drawing.Size(87, 25);
            this.lblAllergies.TabIndex = 62;
            this.lblAllergies.Text = "Allergies";
            // 
            // txtReligion
            // 
            this.txtReligion.Enabled = false;
            this.txtReligion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReligion.Location = new System.Drawing.Point(140, 575);
            this.txtReligion.Name = "txtReligion";
            this.txtReligion.Size = new System.Drawing.Size(205, 30);
            this.txtReligion.TabIndex = 61;
            // 
            // lblReligion
            // 
            this.lblReligion.AutoSize = true;
            this.lblReligion.Enabled = false;
            this.lblReligion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReligion.Location = new System.Drawing.Point(13, 575);
            this.lblReligion.Name = "lblReligion";
            this.lblReligion.Size = new System.Drawing.Size(81, 25);
            this.lblReligion.TabIndex = 60;
            this.lblReligion.Text = "Religion";
            // 
            // btnBack
            // 
            this.btnBack.Enabled = false;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnBack.Location = new System.Drawing.Point(519, 991);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 40);
            this.btnBack.TabIndex = 59;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnForward
            // 
            this.btnForward.Enabled = false;
            this.btnForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnForward.Location = new System.Drawing.Point(565, 991);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(40, 40);
            this.btnForward.TabIndex = 58;
            this.btnForward.Text = ">";
            this.btnForward.UseVisualStyleBackColor = true;
            // 
            // lsvAppointments
            // 
            this.lsvAppointments.Enabled = false;
            this.lsvAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lsvAppointments.FullRowSelect = true;
            this.lsvAppointments.GridLines = true;
            this.lsvAppointments.Location = new System.Drawing.Point(630, 409);
            this.lsvAppointments.Name = "lsvAppointments";
            this.lsvAppointments.Size = new System.Drawing.Size(586, 576);
            this.lsvAppointments.TabIndex = 57;
            this.lsvAppointments.UseCompatibleStateImageBehavior = false;
            // 
            // lblAppointments
            // 
            this.lblAppointments.AutoSize = true;
            this.lblAppointments.Enabled = false;
            this.lblAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblAppointments.Location = new System.Drawing.Point(625, 381);
            this.lblAppointments.Name = "lblAppointments";
            this.lblAppointments.Size = new System.Drawing.Size(132, 25);
            this.lblAppointments.TabIndex = 56;
            this.lblAppointments.Text = "Appointments";
            // 
            // lsvPerscriptions
            // 
            this.lsvPerscriptions.Enabled = false;
            this.lsvPerscriptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lsvPerscriptions.GridLines = true;
            this.lsvPerscriptions.Location = new System.Drawing.Point(13, 754);
            this.lsvPerscriptions.Name = "lsvPerscriptions";
            this.lsvPerscriptions.Size = new System.Drawing.Size(586, 231);
            this.lsvPerscriptions.TabIndex = 54;
            this.lsvPerscriptions.UseCompatibleStateImageBehavior = false;
            // 
            // lblPerscriptions
            // 
            this.lblPerscriptions.AutoSize = true;
            this.lblPerscriptions.Enabled = false;
            this.lblPerscriptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblPerscriptions.Location = new System.Drawing.Point(13, 726);
            this.lblPerscriptions.Name = "lblPerscriptions";
            this.lblPerscriptions.Size = new System.Drawing.Size(124, 25);
            this.lblPerscriptions.TabIndex = 53;
            this.lblPerscriptions.Text = "Perscriptions";
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnReturn.Location = new System.Drawing.Point(13, 991);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(96, 37);
            this.btnReturn.TabIndex = 52;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(267, 500);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 51;
            this.label3.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(199, 500);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 50;
            this.label4.Text = "Month";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(135, 500);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 25);
            this.label5.TabIndex = 49;
            this.label5.Text = "Day";
            // 
            // cmbYear
            // 
            this.cmbYear.Enabled = false;
            this.cmbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(272, 527);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(73, 33);
            this.cmbYear.TabIndex = 48;
            // 
            // cmbMonth
            // 
            this.cmbMonth.Enabled = false;
            this.cmbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(203, 527);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(63, 33);
            this.cmbMonth.TabIndex = 47;
            // 
            // cmbDay
            // 
            this.cmbDay.Enabled = false;
            this.cmbDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Location = new System.Drawing.Point(140, 527);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(57, 33);
            this.cmbDay.TabIndex = 46;
            // 
            // lblDoB
            // 
            this.lblDoB.AutoSize = true;
            this.lblDoB.Enabled = false;
            this.lblDoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblDoB.Location = new System.Drawing.Point(13, 530);
            this.lblDoB.Name = "lblDoB";
            this.lblDoB.Size = new System.Drawing.Size(118, 25);
            this.lblDoB.TabIndex = 45;
            this.lblDoB.Text = "Date of Birth";
            // 
            // txtLastName
            // 
            this.txtLastName.Enabled = false;
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtLastName.Location = new System.Drawing.Point(140, 464);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(205, 30);
            this.txtLastName.TabIndex = 44;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Enabled = false;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblLastName.Location = new System.Drawing.Point(13, 467);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(106, 25);
            this.lblLastName.TabIndex = 43;
            this.lblLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Enabled = false;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtFirstName.Location = new System.Drawing.Point(140, 421);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(205, 30);
            this.txtFirstName.TabIndex = 42;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Enabled = false;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblFirstName.Location = new System.Drawing.Point(13, 424);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(106, 25);
            this.lblFirstName.TabIndex = 41;
            this.lblFirstName.Text = "First Name";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtID.Location = new System.Drawing.Point(140, 382);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(205, 30);
            this.txtID.TabIndex = 40;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Enabled = false;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblID.Location = new System.Drawing.Point(13, 385);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(96, 25);
            this.lblID.TabIndex = 39;
            this.lblID.Text = "Patient ID";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSearch.Location = new System.Drawing.Point(115, 991);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 37);
            this.btnSearch.TabIndex = 38;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // frmViewAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.txtNextOfKin);
            this.Controls.Add(this.lblNextOfKin);
            this.Controls.Add(this.txtAllergies);
            this.Controls.Add(this.lblAllergies);
            this.Controls.Add(this.txtReligion);
            this.Controls.Add(this.lblReligion);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.lsvAppointments);
            this.Controls.Add(this.lblAppointments);
            this.Controls.Add(this.lsvPerscriptions);
            this.Controls.Add(this.lblPerscriptions);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
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
            this.Controls.Add(this.btnSearch);
            this.Name = "frmViewAppointments";
            this.Text = "frmViewAppointments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNextOfKin;
        private System.Windows.Forms.Label lblNextOfKin;
        private System.Windows.Forms.TextBox txtAllergies;
        private System.Windows.Forms.Label lblAllergies;
        private System.Windows.Forms.TextBox txtReligion;
        private System.Windows.Forms.Label lblReligion;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.ListView lsvAppointments;
        private System.Windows.Forms.Label lblAppointments;
        private System.Windows.Forms.ListView lsvPerscriptions;
        private System.Windows.Forms.Label lblPerscriptions;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ComboBox cmbDay;
        private System.Windows.Forms.Label lblDoB;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnSearch;
    }
}