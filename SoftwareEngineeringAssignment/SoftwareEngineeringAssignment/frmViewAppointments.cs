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
    public partial class frmViewAppointments : Form
    {
        List<Appointment> aList = new List<Appointment>();
        List<Patient> pList = new List<Patient>();
        List<Perscription> perList = new List<Perscription>();
        Staff LoggedInStaff;
        int selectedAppointment, selectedPatient;
        public frmViewAppointments(Staff current)
        {
            InitializeComponent();
            LoggedInStaff = current;
            drawLSV();
            selectedPatient = 0;
            selectedAppointment = 0;
            getInfomation();
            populate();
        }

        private void getInfomation()
        {
            BusinessLayer ml = BusinessLayer.Instance();

            aList = ml.GetAppointments();
            List<Patient> tempPList = ml.GetPatients();

            sortAppointments();

            if (aList.Count > 0)
            {
                foreach (Patient p in tempPList)
                {
                    if (aList[selectedAppointment].patientID == p.PatientID)
                    {
                        pList.Add(p);
                    }
                }
            }
            else
            {
                MessageBox.Show("You have no appointments for today");
            }
        }

        private void populate()
        {
            List<string> result = new List<string>();
            txtAppointmentTime.Text = aList[selectedAppointment].appointmentTime.TimeOfDay.ToString();

            txtID.Text = aList[selectedAppointment].patientID.ToString();
            txtFirstName.Text = pList[selectedPatient].FirstName;
            txtLastName.Text = pList[selectedPatient].LastName;
            cmbDay.Text = pList[selectedPatient].DoB.Day.ToString();
            cmbMonth.Text = pList[selectedPatient].DoB.Month.ToString();
            cmbYear.Text = pList[selectedPatient].DoB.Year.ToString();
            txtReligion.Text = pList[selectedPatient].Religeon;

            txtNextOfKin.Text = pList[selectedPatient].NextOfKin;
            txtNoKTelephone.Text = pList[selectedPatient].NoKTelephone;

            result = pList[selectedPatient].Allergies.Split(',').ToList();

            foreach(string s in result)
            {
                lsvAllergies.Items.Add(s);
            }

            foreach (Perscription per in perList)
            {
                if (pList[selectedAppointment].PatientID == per.PatientID)
                {
                    lsvPerscriptions.Items.Add(new ListViewItem(new string[] { per.DrugID.ToString(), per.Name, per.StartDate.ToString(), per.EndDate.ToString(), per.description }));
                }

            }

            int i = 0;
            foreach (Appointment app in aList)
            {
                if (pList[selectedAppointment].PatientID == app.patientID)
                {
                    lsvAppointments.Items.Add(new ListViewItem(new string[] { pList[selectedAppointment].PatientID.ToString(), pList[selectedAppointment].ToString(), app.staffID.ToString(), app.appointmentTime.ToString() }));
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

        private void sortAppointments()
        {
            List<Appointment> temp = new List<Appointment>();
            foreach (Appointment a in aList)
            {
                if (a.staffID == LoggedInStaff.StaffID)
                {
                    temp.Add(a);
                }
            }
            List<Appointment> SortedList = temp.OrderBy(o => o.appointmentTime).ToList();
            aList.Clear();
            foreach (Appointment a in SortedList)
            {
                aList.Add(a);
            }
        }

        private void ResizeListViewColumns(ListView lv)
        {
            foreach (ColumnHeader column in lv.Columns)
            {
                column.Width = -2;
            }
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
            lsvAppointments.Columns.Add("StaffID", -2, HorizontalAlignment.Left);
            lsvAppointments.Columns.Add("Appointment Time", -2, HorizontalAlignment.Left);
        }
    }
}
