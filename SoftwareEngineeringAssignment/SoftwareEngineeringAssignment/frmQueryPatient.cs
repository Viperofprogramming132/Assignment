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
    public partial class frmQueryPatient : Form
    {
        List<Patient> patients = new List<Patient>();

        List<Patient> finP = new List<Patient>();

        List<Appointment> aList = new List<Appointment>();
        List<Perscription> pList = new List<Perscription>();

        frmBook m_FB;
        frmAddPerscription m_FAP;

        int showing;

        /// <summary>
        /// Constructor for query patient taking frmBook form
        /// </summary>
        /// <param name="f"></param>
        public frmQueryPatient(frmBook f)
        {
            InitializeComponent();
            this.m_FB = f;
            initializeForm();
        }

        /// <summary>
        /// Constructor for query patient taking frmAddPerscription form
        /// </summary>
        /// <param name="f"></param>
        public frmQueryPatient(frmAddPerscription f)
        {
            InitializeComponent();
            this.m_FAP = f;
            initializeForm();
        }

        /// <summary>
        /// Sets up the List views and combo boxs
        /// </summary>
        private void initializeForm()
        {
            
            this.WindowState = FormWindowState.Maximized;

            drawLSV();

            for (int i = 1; i <= 31; i++)
            {
                cmbDay.Items.Add(i);
            }

            for (int i = 1; i <= 12; i++)
            {
                cmbMonth.Items.Add(i);
            }
            for (int i = 1900; i <= DateTime.Now.Year; i++)
            {
                cmbYear.Items.Add(i);
            }
        }

        /// <summary>
        /// Closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Starts the worker to get the patient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            BusinessLayer ml = BusinessLayer.Instance();


            patients = ml.GetPatients();
            aList = ml.GetAppointments();
            pList = ml.GetPerscriptions();
            //database query this info
            foreach(Patient pa in patients)
            {
                if(((txtFirstName.Text != "" || txtFirstName.Text == null) && pa.FirstName == txtFirstName.Text) || ((txtLastName.Text != "" || txtLastName.Text == null) && pa.LastName == txtLastName.Text) || ((txtID.Text != "" || txtID.Text == null) && pa.PatientID.ToString() == txtID.Text)) 
                {
                    finP.Add(pa);
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
        }

        /// <summary>
        /// Makes the full row selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lsvPerscriptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsvPerscriptions.FullRowSelect = true;
        }

        /// <summary>
        /// Sets the form to full screen on load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmQueryPatient_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }

        /// <summary>
        /// Populates the infomation with the given patient
        /// </summary>
        /// <param name="patient"></param>
        private void populate(Patient patient)
        {
            List<string> result = new List<string>();
            showing = finP.IndexOf(patient);
            drawLSV();
            buttonUpdate();

            txtFirstName.Text = patient.FirstName;
            txtLastName.Text = patient.LastName;
            txtID.Text = patient.PatientID.ToString();
            txtReligion.Text = patient.Religeon.ToString();
            
            result = finP[showing].Allergies.Split(',').ToList();

            foreach (string s in result)
            {
                lsvAllergies.Items.Add(s);
            }
            txtNextOfKin.Text = patient.NextOfKin;
            txtNoKTelephone.Text = patient.NoKTelephone;
            cmbDay.Text = patient.DoB.Day.ToString();
            cmbMonth.Text = patient.DoB.Month.ToString();
            cmbYear.Text = patient.DoB.Year.ToString();


            //gets perscriptions
            foreach(Perscription per in pList)
            {
                if(patient.PatientID == per.PatientID)
                {
                    lsvPerscriptions.Items.Add(new ListViewItem(new string[] { per.DrugID.ToString(), per.Name, per.StartDate.ToString(), per.EndDate.ToString(), per.description }));
                }
                
            }

            int i = 0;
            //Gets appointments and shows if they are cancled or not attended
            foreach (Appointment app in aList)
            {
                if (patient.PatientID == app.patientID)
                {
                    lsvAppointments.Items.Add(new ListViewItem(new string[] { patient.PatientID.ToString(), patient.ToString(), app.staffID.ToString() , app.appointmentTime.ToString() }));
                    if (app.canceled)
                    {
                        lsvAppointments.Items[i].BackColor = Color.Orange;
                    }
                    if (app.attended)
                    {
                        lsvAppointments.Items[i].BackColor = Color.Red;
                    }
                    i++;
                }
            }
            ResizeListViewColumns(lsvAppointments);
            ResizeListViewColumns(lsvPerscriptions);
        }

        /// <summary>
        /// Draws the collums for the list views
        /// </summary>
        private void drawLSV()
        {
            lsvPerscriptions.Clear();
            lsvAppointments.Clear();
            lsvPerscriptions.View = View.Details;
            lsvPerscriptions.Columns.Add("Drug ID", -2, HorizontalAlignment.Left);
            lsvPerscriptions.Columns.Add("Drug Name", -2, HorizontalAlignment.Left);
            lsvPerscriptions.Columns.Add("Date Perscribed", -2, HorizontalAlignment.Left);
            lsvPerscriptions.Columns.Add("Expiry Date", -2, HorizontalAlignment.Left);
            lsvPerscriptions.Columns.Add("Description", -2, HorizontalAlignment.Left);

            lsvAppointments.View = View.Details;

            lsvAppointments.Columns.Add("NHS Number", -2, HorizontalAlignment.Left);
            lsvAppointments.Columns.Add("First Name", -2, HorizontalAlignment.Left);
            lsvAppointments.Columns.Add("StaffID", -2, HorizontalAlignment.Left);
            lsvAppointments.Columns.Add("Appointment Time", -2, HorizontalAlignment.Left);
        }

        /// <summary>
        /// Goes forward 1 patient if it returns more than 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnForward_Click(object sender, EventArgs e)
        {
            populate(finP[showing + 1]);
        }


        /// <summary>
        /// Enables and disables forward a backwards button as needed
        /// </summary>
        private void buttonUpdate()
        {
            if(showing == 0)
            {
                btnBack.Enabled = false;
            }
            else
            {
                btnBack.Enabled = true;
            }
            if (showing == finP.Count-1)
            {
                btnForward.Enabled = false;
            }
            else
            {
                btnForward.Enabled = true;
            }

        }

        /// <summary>
        ///  Goes back 1 patient if it returns more than 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            populate(finP[showing - 1]);
        }

        /// <summary>
        /// Sends the patient back when the form is closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmQueryPatient_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_FB != null)
            {
                if (finP.Count != 0)
                {
                    m_FB.TakePatient(finP[showing]);
                }
                else
                {
                    MessageBox.Show("No user was selected. Returning to Booking");
                }
            }
            else if (m_FAP != null)
            {
                if (finP.Count != 0)
                {
                    m_FAP.TakePatient(finP[showing]);
                }
                else
                {
                    MessageBox.Show("No user was selected. Returning to Add Perscription");
                }
            }
        }

        /// <summary>
        /// Resizes the list view to fit all infomation
        /// </summary>
        /// <param name="lv"></param>
        private void ResizeListViewColumns(ListView lv)
        {
            foreach (ColumnHeader column in lv.Columns)
            {
                column.Width = -2;
            }
        }

        /// <summary>
        /// Shows the add patient form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_patient_Click(object sender, EventArgs e)
        {
            frmAddPatient addPatient = new frmAddPatient();
            this.Hide();
            addPatient.ShowDialog();
            this.Show();
        }
    }
}
