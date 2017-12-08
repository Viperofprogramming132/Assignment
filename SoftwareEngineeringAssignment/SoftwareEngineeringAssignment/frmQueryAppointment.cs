using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareEngineeringAssignment
{
    public partial class frmQueryAppointment : Form
    {
        List<Appointment> aList = new List<Appointment>();
        List<Appointment> FullAppointmentList = new List<Appointment>();
        Patient CurrentPatient;
        int selectedAppointment = 0;

        public frmQueryAppointment()
        {
            InitializeComponent();
            selectedAppointment = 0;
        }

        private void frmQueryAppointment_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }



        private void populate(Patient patient)
        {
            List<string> result = new List<string>();
            txtAppointmentTime.Text = aList[selectedAppointment].AppointmentTime.ToString();
            txtReason.Text = aList[selectedAppointment].Description;
            txtFirstName.Text = patient.FirstName;
            txtLastName.Text = patient.LastName;
            txtID.Text = patient.PatientID.ToString();
            txtNoKTelephone.Text = patient.NoKTelephone;
            txtEmailAddress.Text = patient.Email;
            cmbDay.Text = patient.DoB.Day.ToString();
            cmbMonth.Text = patient.DoB.Month.ToString();
            cmbYear.Text = patient.DoB.Year.ToString();
        }


        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            frmQueryPatient frmQueryPatient = new frmQueryPatient(this);
            this.Hide();
            frmQueryPatient.ShowDialog();
            this.Show();


            BusinessLayer ml = BusinessLayer.Instance();
            FullAppointmentList = ml.GetAppointments();

            foreach(Appointment a in FullAppointmentList)
            {
                if(a.PatientID == CurrentPatient.PatientID)
                {
                    aList.Add(a);
                }
            }

            populate(CurrentPatient);
            buttonUpdate();
        }
        private void UpdateAppointment()
        {
            if (aList[selectedAppointment].AppointmentTime.TimeOfDay.ToString() != txtAppointmentTime.Text || aList[selectedAppointment].Description != txtReason.Text)
            {
                DialogResult dr = MessageBox.Show("Do you want to save changes to " + CurrentPatient.ToString(), "Confirm", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {
                    BusinessLayer ml = BusinessLayer.Instance();
                    MessageBox.Show(ml.UpdateAppointment(getTime(txtAppointmentTime.Text), getTime(txtAppointmentTime.Text).AddMinutes(5), txtReason.Text,aList[selectedAppointment].AppointmentID) + " Number of entries updated");
                }
            }
        }

        private DateTime getTime(string timeSlot)
        {
            if (timeSlot != "")
            {
                DateTime date = mclAppointmentDay.SelectionStart;
                DateTime time = DateTime.ParseExact(timeSlot, "HH:mm:ss", CultureInfo.InvariantCulture);

                DateTime dateTime = date.AddHours(time.Hour).AddMinutes(time.Minute);
                return dateTime;
            }
            return DateTime.Now;
        }

        private void frmQueryAppointment_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateAppointment();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            UpdateAppointment();
        }

        public void TakePatient(Patient p)
        {
            CurrentPatient = p;
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            selectedAppointment++;
            populate(CurrentPatient);
            buttonUpdate();
        }

        /// <summary>
        /// Enables and disables forward a backwards button as needed
        /// </summary>
        private void buttonUpdate()
        {
            if (selectedAppointment == 0)
            {
                btnBack.Enabled = false;
            }
            else
            {
                btnBack.Enabled = true;
            }
            if (selectedAppointment == aList.Count - 1)
            {
                btnForward.Enabled = false;
            }
            else
            {
                btnForward.Enabled = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            selectedAppointment--;
            populate(CurrentPatient);
            buttonUpdate();
        }
    }
}

