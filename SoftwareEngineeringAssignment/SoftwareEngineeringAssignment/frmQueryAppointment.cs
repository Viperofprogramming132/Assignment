using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        List<Patient> finP = new List<Patient>();
        List<Patient> patients = new List<Patient>();

        public frmQueryAppointment()
        {
            InitializeComponent();

        }

        private void frmQueryAppointment_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }

        private void populate(Patient patient)
        {
            List<string> result = new List<string>();

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
            BusinessLayer ml = BusinessLayer.Instance();


            patients = ml.GetPatients();
            foreach (Patient p in patients)
            {
                if (((txtFirstName.Text != "" || txtFirstName.Text == null) && p.FirstName == txtFirstName.Text) || ((txtLastName.Text != "" || txtLastName.Text == null) && p.LastName == txtLastName.Text) || ((txtID.Text != "" || txtID.Text == null) && p.PatientID.ToString() == txtID.Text))
                {
                    finP.Add(p);
                }
            }
            try
            {
                populate(finP[0]);
            }
            catch
            {
                MessageBox.Show("No Patients Found");
            }

            

                
                FullAppointmentList = ml.GetAppointments();
                List<Patient> tempPList = ml.GetPatients();



            foreach (Appointment a in FullAppointmentList)
            {
                if (a.PatientID == finP[0].PatientID)
                {
                    aList.Add(a);
                }


                // MessageBox.Show("You have no appointments for today");
            }
            
        }
    }
    }

