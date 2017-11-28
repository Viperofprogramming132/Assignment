namespace SoftwareEngineeringAssignment
{
    partial class Patient
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.lblDoB = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblPerscriptions = new System.Windows.Forms.Label();
            this.lsvPerscriptions = new System.Windows.Forms.ListView();
            this.lsvAppointments = new System.Windows.Forms.ListView();
            this.lblAppointments = new System.Windows.Forms.Label();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblReligion = new System.Windows.Forms.Label();
            this.txtReligion = new System.Windows.Forms.TextBox();
            this.lblAllergies = new System.Windows.Forms.Label();
            this.lblNextOfKin = new System.Windows.Forms.Label();
            this.txtNextOfKin = new System.Windows.Forms.TextBox();
            this.lsvAllergies = new System.Windows.Forms.ListView();
            this.txtNoKTelephone = new System.Windows.Forms.TextBox();
            this.btnAdd_patient = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.lbltelephone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSearch.Location = new System.Drawing.Point(114, 616);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 37);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblID.Location = new System.Drawing.Point(12, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(96, 25);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "Patient ID";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtID.Location = new System.Drawing.Point(139, 6);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(126, 30);
            this.txtID.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtFirstName.Location = new System.Drawing.Point(139, 45);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(126, 30);
            this.txtFirstName.TabIndex = 4;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblFirstName.Location = new System.Drawing.Point(12, 48);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(106, 25);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtLastName.Location = new System.Drawing.Point(139, 88);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(126, 30);
            this.txtLastName.TabIndex = 6;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblLastName.Location = new System.Drawing.Point(12, 91);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(106, 25);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(266, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(198, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Month";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(134, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Day";
            // 
            // cmbYear
            // 
            this.cmbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(271, 152);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(73, 33);
            this.cmbYear.TabIndex = 20;
            // 
            // cmbMonth
            // 
            this.cmbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(202, 152);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(63, 33);
            this.cmbMonth.TabIndex = 19;
            // 
            // cmbDay
            // 
            this.cmbDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Location = new System.Drawing.Point(139, 152);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(57, 33);
            this.cmbDay.TabIndex = 18;
            // 
            // lblDoB
            // 
            this.lblDoB.AutoSize = true;
            this.lblDoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblDoB.Location = new System.Drawing.Point(12, 155);
            this.lblDoB.Name = "lblDoB";
            this.lblDoB.Size = new System.Drawing.Size(118, 25);
            this.lblDoB.TabIndex = 17;
            this.lblDoB.Text = "Date of Birth";
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnReturn.Location = new System.Drawing.Point(12, 616);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(96, 37);
            this.btnReturn.TabIndex = 24;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblPerscriptions
            // 
            this.lblPerscriptions.AutoSize = true;
            this.lblPerscriptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblPerscriptions.Location = new System.Drawing.Point(12, 351);
            this.lblPerscriptions.Name = "lblPerscriptions";
            this.lblPerscriptions.Size = new System.Drawing.Size(124, 25);
            this.lblPerscriptions.TabIndex = 25;
            this.lblPerscriptions.Text = "Perscriptions";
            // 
            // lsvPerscriptions
            // 
            this.lsvPerscriptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lsvPerscriptions.GridLines = true;
            this.lsvPerscriptions.Location = new System.Drawing.Point(12, 379);
            this.lsvPerscriptions.Name = "lsvPerscriptions";
            this.lsvPerscriptions.Size = new System.Drawing.Size(586, 231);
            this.lsvPerscriptions.TabIndex = 26;
            this.lsvPerscriptions.UseCompatibleStateImageBehavior = false;
            this.lsvPerscriptions.SelectedIndexChanged += new System.EventHandler(this.lsvPerscriptions_SelectedIndexChanged);
            // 
            // lsvAppointments
            // 
            this.lsvAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lsvAppointments.FullRowSelect = true;
            this.lsvAppointments.GridLines = true;
            this.lsvAppointments.Location = new System.Drawing.Point(629, 34);
            this.lsvAppointments.Name = "lsvAppointments";
            this.lsvAppointments.Size = new System.Drawing.Size(586, 576);
            this.lsvAppointments.TabIndex = 29;
            this.lsvAppointments.UseCompatibleStateImageBehavior = false;
            // 
            // lblAppointments
            // 
            this.lblAppointments.AutoSize = true;
            this.lblAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblAppointments.Location = new System.Drawing.Point(624, 6);
            this.lblAppointments.Name = "lblAppointments";
            this.lblAppointments.Size = new System.Drawing.Size(132, 25);
            this.lblAppointments.TabIndex = 28;
            this.lblAppointments.Text = "Appointments";
            // 
            // btnForward
            // 
            this.btnForward.Enabled = false;
            this.btnForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnForward.Location = new System.Drawing.Point(688, 616);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(40, 40);
            this.btnForward.TabIndex = 30;
            this.btnForward.Text = ">";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBack
            // 
            this.btnBack.Enabled = false;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnBack.Location = new System.Drawing.Point(642, 616);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 40);
            this.btnBack.TabIndex = 31;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblReligion
            // 
            this.lblReligion.AutoSize = true;
            this.lblReligion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReligion.Location = new System.Drawing.Point(12, 200);
            this.lblReligion.Name = "lblReligion";
            this.lblReligion.Size = new System.Drawing.Size(81, 25);
            this.lblReligion.TabIndex = 32;
            this.lblReligion.Text = "Religion";
            // 
            // txtReligion
            // 
            this.txtReligion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReligion.Location = new System.Drawing.Point(139, 200);
            this.txtReligion.Name = "txtReligion";
            this.txtReligion.Size = new System.Drawing.Size(100, 30);
            this.txtReligion.TabIndex = 33;
            // 
            // lblAllergies
            // 
            this.lblAllergies.AutoSize = true;
            this.lblAllergies.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllergies.Location = new System.Drawing.Point(364, 6);
            this.lblAllergies.Name = "lblAllergies";
            this.lblAllergies.Size = new System.Drawing.Size(87, 25);
            this.lblAllergies.TabIndex = 34;
            this.lblAllergies.Text = "Allergies";
            // 
            // lblNextOfKin
            // 
            this.lblNextOfKin.AutoSize = true;
            this.lblNextOfKin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextOfKin.Location = new System.Drawing.Point(12, 249);
            this.lblNextOfKin.Name = "lblNextOfKin";
            this.lblNextOfKin.Size = new System.Drawing.Size(112, 25);
            this.lblNextOfKin.TabIndex = 36;
            this.lblNextOfKin.Text = "Next Of Kin";
            // 
            // txtNextOfKin
            // 
            this.txtNextOfKin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNextOfKin.Location = new System.Drawing.Point(139, 244);
            this.txtNextOfKin.Name = "txtNextOfKin";
            this.txtNextOfKin.Size = new System.Drawing.Size(126, 30);
            this.txtNextOfKin.TabIndex = 37;
            // 
            // lsvAllergies
            // 
            this.lsvAllergies.Location = new System.Drawing.Point(369, 35);
            this.lsvAllergies.Name = "lsvAllergies";
            this.lsvAllergies.Size = new System.Drawing.Size(229, 239);
            this.lsvAllergies.TabIndex = 38;
            this.lsvAllergies.UseCompatibleStateImageBehavior = false;
            // 
            // txtNoKTelephone
            // 
            this.txtNoKTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoKTelephone.Location = new System.Drawing.Point(198, 281);
            this.txtNoKTelephone.Name = "txtNoKTelephone";
            this.txtNoKTelephone.Size = new System.Drawing.Size(126, 30);
            this.txtNoKTelephone.TabIndex = 39;
            // 
            // btnAdd_patient
            // 
            this.btnAdd_patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd_patient.Location = new System.Drawing.Point(208, 616);
            this.btnAdd_patient.Name = "btnAdd_patient";
            this.btnAdd_patient.Size = new System.Drawing.Size(207, 37);
            this.btnAdd_patient.TabIndex = 40;
            this.btnAdd_patient.Text = "Add New Patient";
            this.btnAdd_patient.UseVisualStyleBackColor = true;
            this.btnAdd_patient.Click += new System.EventHandler(this.btnAdd_patient_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnUpdate.Location = new System.Drawing.Point(421, 616);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(203, 37);
            this.btnUpdate.TabIndex = 48;
            this.btnUpdate.Text = "Update Changes";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailAddress.Location = new System.Drawing.Point(-2, 317);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(138, 25);
            this.lblEmailAddress.TabIndex = 41;
            this.lblEmailAddress.Text = "Email Address";
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailAddress.Location = new System.Drawing.Point(139, 317);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(205, 30);
            this.txtEmailAddress.TabIndex = 42;
            // 
            // lbltelephone
            // 
            this.lbltelephone.AutoSize = true;
            this.lbltelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelephone.Location = new System.Drawing.Point(12, 283);
            this.lbltelephone.Name = "lbltelephone";
            this.lbltelephone.Size = new System.Drawing.Size(180, 25);
            this.lbltelephone.TabIndex = 49;
            this.lbltelephone.Text = "Telephone Number";
            // 
            // frmQueryPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 665);
            this.Controls.Add(this.lbltelephone);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.btnAdd_patient);
            this.Controls.Add(this.txtNoKTelephone);
            this.Controls.Add(this.lsvAllergies);
            this.Controls.Add(this.txtNextOfKin);
            this.Controls.Add(this.lblNextOfKin);
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
            this.Name = "frmQueryPatient";
            this.Text = "frmQueryPatient";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQueryPatient_FormClosing);
            this.Load += new System.EventHandler(this.frmQueryPatient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ComboBox cmbDay;
        private System.Windows.Forms.Label lblDoB;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblPerscriptions;
        private System.Windows.Forms.ListView lsvPerscriptions;
        private System.Windows.Forms.ListView lsvAppointments;
        private System.Windows.Forms.Label lblAppointments;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblReligion;
        private System.Windows.Forms.TextBox txtReligion;
        private System.Windows.Forms.Label lblAllergies;
        private System.Windows.Forms.Label lblNextOfKin;
        private System.Windows.Forms.TextBox txtNextOfKin;
        private System.Windows.Forms.ListView lsvAllergies;
        private System.Windows.Forms.TextBox txtNoKTelephone;
        private System.Windows.Forms.Button btnAdd_patient;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.Label lbltelephone;
    }
}