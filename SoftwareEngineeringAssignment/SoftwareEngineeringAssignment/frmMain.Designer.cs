namespace SoftwareEngineeringAssignment
{
    partial class frmMain
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
            this.btnBookAppointment = new System.Windows.Forms.Button();
            this.btnViewAppointments = new System.Windows.Forms.Button();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.btnEditPerscription = new System.Windows.Forms.Button();
            this.btnAddPerscription = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnLogOff = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnTimeTable = new System.Windows.Forms.Button();
            this.btnChangeAppontments = new System.Windows.Forms.Button();
            this.btnTestHistory = new System.Windows.Forms.Button();
            this.btnAddTestHistory = new System.Windows.Forms.Button();
            this.btnAddAddress = new System.Windows.Forms.Button();
            this.btnViewAddress = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBookAppointment
            // 
            this.btnBookAppointment.Location = new System.Drawing.Point(567, 260);
            this.btnBookAppointment.Name = "btnBookAppointment";
            this.btnBookAppointment.Size = new System.Drawing.Size(183, 67);
            this.btnBookAppointment.TabIndex = 0;
            this.btnBookAppointment.Text = "Book Appointment";
            this.btnBookAppointment.UseVisualStyleBackColor = true;
            this.btnBookAppointment.Click += new System.EventHandler(this.btnBookAppointment_Click);
            // 
            // btnViewAppointments
            // 
            this.btnViewAppointments.Location = new System.Drawing.Point(975, 260);
            this.btnViewAppointments.Name = "btnViewAppointments";
            this.btnViewAppointments.Size = new System.Drawing.Size(183, 67);
            this.btnViewAppointments.TabIndex = 2;
            this.btnViewAppointments.Text = "View Appointments";
            this.btnViewAppointments.UseVisualStyleBackColor = true;
            this.btnViewAppointments.Click += new System.EventHandler(this.btnSeachPatients_Click);
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Location = new System.Drawing.Point(975, 354);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(183, 67);
            this.btnAddPatient.TabIndex = 3;
            this.btnAddPatient.Text = "Add Patient";
            this.btnAddPatient.UseVisualStyleBackColor = true;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // btnEditPerscription
            // 
            this.btnEditPerscription.Location = new System.Drawing.Point(975, 450);
            this.btnEditPerscription.Name = "btnEditPerscription";
            this.btnEditPerscription.Size = new System.Drawing.Size(183, 67);
            this.btnEditPerscription.TabIndex = 5;
            this.btnEditPerscription.Text = "Edit Perscription";
            this.btnEditPerscription.UseVisualStyleBackColor = true;
            this.btnEditPerscription.Click += new System.EventHandler(this.btnEditPerscription_Click);
            // 
            // btnAddPerscription
            // 
            this.btnAddPerscription.Location = new System.Drawing.Point(567, 450);
            this.btnAddPerscription.Name = "btnAddPerscription";
            this.btnAddPerscription.Size = new System.Drawing.Size(183, 67);
            this.btnAddPerscription.TabIndex = 6;
            this.btnAddPerscription.Text = "Add Perscription";
            this.btnAddPerscription.UseVisualStyleBackColor = true;
            this.btnAddPerscription.Click += new System.EventHandler(this.btnAddPerscription_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(975, 751);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(183, 67);
            this.btnAdmin.TabIndex = 8;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnLogOff
            // 
            this.btnLogOff.Location = new System.Drawing.Point(1325, 260);
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.Size = new System.Drawing.Size(183, 67);
            this.btnLogOff.TabIndex = 1;
            this.btnLogOff.Text = "Log Off";
            this.btnLogOff.UseVisualStyleBackColor = true;
            this.btnLogOff.Click += new System.EventHandler(this.btnLogOff_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(735, 137);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(137, 25);
            this.lblWelcome.TabIndex = 8;
            this.lblWelcome.Text = "Home Menu";
            // 
            // btnTimeTable
            // 
            this.btnTimeTable.Location = new System.Drawing.Point(975, 549);
            this.btnTimeTable.Name = "btnTimeTable";
            this.btnTimeTable.Size = new System.Drawing.Size(183, 67);
            this.btnTimeTable.TabIndex = 7;
            this.btnTimeTable.Text = "View Your Timetable";
            this.btnTimeTable.UseVisualStyleBackColor = true;
            this.btnTimeTable.Click += new System.EventHandler(this.btnTimeTable_Click);
            // 
            // btnChangeAppontments
            // 
            this.btnChangeAppontments.Location = new System.Drawing.Point(567, 354);
            this.btnChangeAppontments.Name = "btnChangeAppontments";
            this.btnChangeAppontments.Size = new System.Drawing.Size(183, 67);
            this.btnChangeAppontments.TabIndex = 4;
            this.btnChangeAppontments.Text = "Change Appointments";
            this.btnChangeAppontments.UseVisualStyleBackColor = true;
            this.btnChangeAppontments.Click += new System.EventHandler(this.btnChangeAppontments_Click);
            // 
            // btnTestHistory
            // 
            this.btnTestHistory.Location = new System.Drawing.Point(567, 549);
            this.btnTestHistory.Name = "btnTestHistory";
            this.btnTestHistory.Size = new System.Drawing.Size(183, 67);
            this.btnTestHistory.TabIndex = 9;
            this.btnTestHistory.Text = "View Test History";
            this.btnTestHistory.UseVisualStyleBackColor = true;
            this.btnTestHistory.Click += new System.EventHandler(this.btnTestHistory_Click_1);
            // 
            // btnAddTestHistory
            // 
            this.btnAddTestHistory.Location = new System.Drawing.Point(975, 647);
            this.btnAddTestHistory.Name = "btnAddTestHistory";
            this.btnAddTestHistory.Size = new System.Drawing.Size(183, 67);
            this.btnAddTestHistory.TabIndex = 10;
            this.btnAddTestHistory.Text = "Add Test History";
            this.btnAddTestHistory.UseVisualStyleBackColor = true;
            this.btnAddTestHistory.Click += new System.EventHandler(this.btnAddTestHistory_Click);
            // 
            // btnAddAddress
            // 
            this.btnAddAddress.Location = new System.Drawing.Point(567, 647);
            this.btnAddAddress.Name = "btnAddAddress";
            this.btnAddAddress.Size = new System.Drawing.Size(183, 67);
            this.btnAddAddress.TabIndex = 11;
            this.btnAddAddress.Text = "Add Address";
            this.btnAddAddress.UseVisualStyleBackColor = true;
            this.btnAddAddress.Click += new System.EventHandler(this.btnAddAddress_Click);
            // 
            // btnViewAddress
            // 
            this.btnViewAddress.Location = new System.Drawing.Point(567, 751);
            this.btnViewAddress.Name = "btnViewAddress";
            this.btnViewAddress.Size = new System.Drawing.Size(183, 67);
            this.btnViewAddress.TabIndex = 12;
            this.btnViewAddress.Text = "View Address";
            this.btnViewAddress.UseVisualStyleBackColor = true;
            this.btnViewAddress.Click += new System.EventHandler(this.btnViewAddress_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1643, 893);
            this.Controls.Add(this.btnViewAddress);
            this.Controls.Add(this.btnAddAddress);
            this.Controls.Add(this.btnAddTestHistory);
            this.Controls.Add(this.btnTestHistory);
            this.Controls.Add(this.btnChangeAppontments);
            this.Controls.Add(this.btnTimeTable);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnLogOff);
            this.Controls.Add(this.btnEditPerscription);
            this.Controls.Add(this.btnAddPerscription);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.btnViewAppointments);
            this.Controls.Add(this.btnBookAppointment);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBookAppointment;
        private System.Windows.Forms.Button btnViewAppointments;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Button btnEditPerscription;
        private System.Windows.Forms.Button btnAddPerscription;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnLogOff;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnTimeTable;
        private System.Windows.Forms.Button btnChangeAppontments;
        private System.Windows.Forms.Button btnTestHistory;
        private System.Windows.Forms.Button btnAddTestHistory;
        private System.Windows.Forms.Button btnAddAddress;
        private System.Windows.Forms.Button btnViewAddress;
    }
}