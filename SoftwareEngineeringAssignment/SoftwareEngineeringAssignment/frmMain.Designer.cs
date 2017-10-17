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
            this.SuspendLayout();
            // 
            // btnBookAppointment
            // 
            this.btnBookAppointment.Location = new System.Drawing.Point(12, 53);
            this.btnBookAppointment.Name = "btnBookAppointment";
            this.btnBookAppointment.Size = new System.Drawing.Size(124, 42);
            this.btnBookAppointment.TabIndex = 0;
            this.btnBookAppointment.Text = "Book Appointment";
            this.btnBookAppointment.UseVisualStyleBackColor = true;
            this.btnBookAppointment.Click += new System.EventHandler(this.btnBookAppointment_Click);
            // 
            // btnViewAppointments
            // 
            this.btnViewAppointments.Location = new System.Drawing.Point(12, 101);
            this.btnViewAppointments.Name = "btnViewAppointments";
            this.btnViewAppointments.Size = new System.Drawing.Size(124, 42);
            this.btnViewAppointments.TabIndex = 1;
            this.btnViewAppointments.Text = "View Appointments";
            this.btnViewAppointments.UseVisualStyleBackColor = true;
            this.btnViewAppointments.Click += new System.EventHandler(this.btnSeachPatients_Click);
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Location = new System.Drawing.Point(148, 101);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(124, 42);
            this.btnAddPatient.TabIndex = 3;
            this.btnAddPatient.Text = "Add Patient";
            this.btnAddPatient.UseVisualStyleBackColor = true;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // btnEditPerscription
            // 
            this.btnEditPerscription.Location = new System.Drawing.Point(148, 149);
            this.btnEditPerscription.Name = "btnEditPerscription";
            this.btnEditPerscription.Size = new System.Drawing.Size(124, 42);
            this.btnEditPerscription.TabIndex = 5;
            this.btnEditPerscription.Text = "Edit Perscription";
            this.btnEditPerscription.UseVisualStyleBackColor = true;
            this.btnEditPerscription.Click += new System.EventHandler(this.btnEditPerscription_Click);
            // 
            // btnAddPerscription
            // 
            this.btnAddPerscription.Location = new System.Drawing.Point(12, 149);
            this.btnAddPerscription.Name = "btnAddPerscription";
            this.btnAddPerscription.Size = new System.Drawing.Size(124, 42);
            this.btnAddPerscription.TabIndex = 4;
            this.btnAddPerscription.Text = "Add Perscription";
            this.btnAddPerscription.UseVisualStyleBackColor = true;
            this.btnAddPerscription.Click += new System.EventHandler(this.btnAddPerscription_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(80, 197);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(124, 42);
            this.btnAdmin.TabIndex = 7;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnLogOff
            // 
            this.btnLogOff.Location = new System.Drawing.Point(148, 53);
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.Size = new System.Drawing.Size(124, 42);
            this.btnLogOff.TabIndex = 6;
            this.btnLogOff.Text = "Log Off";
            this.btnLogOff.UseVisualStyleBackColor = true;
            this.btnLogOff.Click += new System.EventHandler(this.btnLogOff_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(12, 13);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(35, 13);
            this.lblWelcome.TabIndex = 8;
            this.lblWelcome.Text = "label1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 249);
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
    }
}