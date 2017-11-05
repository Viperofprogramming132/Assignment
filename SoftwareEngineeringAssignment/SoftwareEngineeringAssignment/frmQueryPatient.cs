﻿using System;
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
        public frmQueryPatient(frmBook f)
        {
            InitializeComponent();
            this.m_FB = f;
            initializeForm();
        }

        public frmQueryPatient(frmAddPerscription f)
        {
            InitializeComponent();
            this.m_FAP = f;
            initializeForm();
        }

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
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BusinessLayer ml = BusinessLayer.Instance();


            patients = ml.GetPatients();
            aList = ml.GetAppointments();
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

        private void lsvPerscriptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsvPerscriptions.FullRowSelect = true;
        }

        private void frmQueryPatient_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }
        private void populate(Patient patient)
        {
            showing = finP.IndexOf(patient);
            drawLSV();
            buttonUpdate();

            txtFirstName.Text = patient.FirstName;
            txtLastName.Text = patient.LastName;
            txtID.Text = patient.PatientID.ToString();

            cmbDay.Text = patient.DoB.Day.ToString();
            cmbMonth.Text = patient.DoB.Month.ToString();
            cmbYear.Text = patient.DoB.Year.ToString();



            foreach(Perscription per in pList)
            {
                if(patient.PatientID == per.PatientID)
                lsvPerscriptions.Items.Add(new ListViewItem(new string[] { per.DrugID.ToString(), per.Name, per.StartDate.ToString(), per.EndDate.ToString(), per.description }));
            }

            int i = 0;
            foreach (Appointment app in aList)
            {
                if (patient.PatientID == app.patientID)
                {
                    lsvAppointments.Items.Add(new ListViewItem(new string[] { patient.PatientID.ToString(), patient.FirstName, patient.LastName, app.appointmentTime.ToString() }));
                    if (app.canceled)
                    {
                        lsvAppointments.Items[i].BackColor = Color.Red;
                    }

                    i++;
                }
            }
            ResizeListViewColumns(lsvAppointments);
            ResizeListViewColumns(lsvPerscriptions);
        }

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
            lsvAppointments.Columns.Add("Last Name", -2, HorizontalAlignment.Left);
            lsvAppointments.Columns.Add("Appointment Time", -2, HorizontalAlignment.Left);
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            populate(finP[showing + 1]);
        }

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            populate(finP[showing - 1]);
        }

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

        private void ResizeListViewColumns(ListView lv)
        {
            foreach (ColumnHeader column in lv.Columns)
            {
                column.Width = -2;
            }
        }
    }
}
