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
        List<Appointment> FullAppointmentList = new List<Appointment>();
        List<Patient> pList = new List<Patient>();
        List<Perscription> perList = new List<Perscription>();
        Staff LoggedInStaff;
        int selectedAppointment, selectedPatient;
        DateTime selectedDate;
        bool goodData = true;
        public frmViewAppointments(Staff current)
        {
            InitializeComponent();
            LoggedInStaff = current;
            drawLSV();
            selectedPatient = 0;
            selectedAppointment = 0;
            selectedDate = DateTime.Now;
            getInfomation();
            if (goodData)
            {
                populate();
            }
        }

        private void getInfomation()
        {
            BusinessLayer ml = BusinessLayer.Instance();

            aList = ml.GetAppointments();
            FullAppointmentList = ml.GetAppointments();
            List<Patient> tempPList = ml.GetPatients();

            sortAppointments(selectedDate);

            if (aList.Count > 0)
            {
                foreach (Patient p in tempPList)
                {
                    if (aList[selectedAppointment].PatientID == p.PatientID)
                    {
                        pList.Add(p);
                    }
                }
                goodData = true;
            }
            else
            {
                MessageBox.Show("You have no appointments for today");
                goodData = false;
                btnBack.Enabled = false;
                btnForward.Enabled = false;
                clearItems();
            }
        }
        private void clearItems()
        {
            txtAppointmentTime.Clear();
            txtFirstName.Clear();
            txtID.Clear();
            txtLastName.Clear();
            txtNextOfKin.Clear();
            txtNoKTelephone.Clear();
            txtReason.Clear();
            txtReligion.Clear();
            lsvAllergies.Clear();
            lsvAppointments.Clear();
            lsvPerscriptions.Clear();
            cmbDay.Text = "";
            cmbMonth.Text = "";
            cmbYear.Text = "";

            drawLSV();
        }
        private void populate()
        {
            lsvAllergies.Clear();
            drawLSV();
            List<string> result = new List<string>();
            txtAppointmentTime.Text = aList[selectedAppointment].AppointmentTime.TimeOfDay.ToString();

            txtID.Text = aList[selectedAppointment].PatientID.ToString();
            txtFirstName.Text = pList[selectedPatient].FirstName;
            txtLastName.Text = pList[selectedPatient].LastName;
            cmbDay.Text = pList[selectedPatient].DoB.Day.ToString();
            cmbMonth.Text = pList[selectedPatient].DoB.Month.ToString();
            cmbYear.Text = pList[selectedPatient].DoB.Year.ToString();
            txtReligion.Text = pList[selectedPatient].Religeon;

            txtNextOfKin.Text = pList[selectedPatient].NextOfKin;
            txtNoKTelephone.Text = pList[selectedPatient].NoKTelephone;
            txtReason.Text = aList[selectedAppointment].Description;

            result = pList[selectedPatient].Allergies.Split(',').ToList();

            foreach (string s in result)
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
            foreach (Appointment app in FullAppointmentList)
            {
                if (pList[selectedPatient].PatientID == app.PatientID)
                {
                    lsvAppointments.Items.Add(new ListViewItem(new string[] { pList[selectedPatient].PatientID.ToString(), pList[selectedPatient].ToString(), app.StaffID.ToString(), app.AppointmentTime.ToString() }));
                    if (app.Canceled)
                    {
                        lsvAppointments.Items[i].BackColor = Color.Orange;
                    }
                    if (app.Attended)
                    {
                        lsvAppointments.Items[i].BackColor = Color.Red;
                    }
                    i++;
                }
            }
            ResizeListViewColumns(lsvAppointments);
            ResizeListViewColumns(lsvPerscriptions);
            ResizeListViewColumns(lsvAllergies);
            buttonUpdate();
        }

        private void sortAppointments(DateTime date)
        {
            List<Appointment> temp = new List<Appointment>();
            List<Appointment> temp2 = new List<Appointment>();
            foreach (Appointment a in aList)
            {
                if (a.StaffID == LoggedInStaff.StaffID)
                {
                    temp.Add(a);
                    temp2.Add(a);
                }
            }

            foreach (Appointment a in temp)
            {
                if (a.AppointmentTime.DayOfYear != date.DayOfYear)
                {
                    temp2.Remove(a);
                }
            }
            List<Appointment> SortedList = temp2.OrderBy(o => o.AppointmentTime).ToList();
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

        private void btnbook_New_Appointment_Click(object sender, EventArgs e)
        {
            frmBook book = new frmBook();
            this.Hide();
            book.ShowDialog();
            this.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            selectedAppointment--;
            populate();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            selectedAppointment++;
            populate();
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

        private void btnNewDate_Click(object sender, EventArgs e)
        {
            mclAppointmentDay.Visible = true;
            lblInfomation.Visible = true;
            lblInfomation.Text = "Please select a date";
        }

        private void mclAppointmentDay_DateSelected(object sender, DateRangeEventArgs e)
        {
            selectedDate = mclAppointmentDay.SelectionStart;
            getInfomation();
            if (goodData)
            {
                populate();
            }
            mclAppointmentDay.Visible = false;
            lblInfomation.Visible = false;
        }

        private void frmViewAppointments_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdate()
        {
            if(selectedAppointment == 0)
            {
                btnBack.Enabled = false;
            }
            else
            {
                btnBack.Enabled = true;
            }

            if (aList.Count == selectedAppointment + 1)
            {
                btnForward.Enabled = false;
            }
            else
            {
                btnForward.Enabled = true;
            }
        }
    }
}
