﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;

namespace SoftwareEngineeringAssignment
{
    public partial class frmBook : Form
    {
        List<Staff> sList = new List<Staff>();
        List<Appointment> aList = new List<Appointment>();
        BusinessLayer ml = BusinessLayer.Instance();
        Patient current;
        int inc = 5;
        List<DateTime> timeList = new List<DateTime>();


        public frmBook()
        {
            InitializeComponent();
            
            this.WindowState = FormWindowState.Maximized;

            //Fill the data
            fillTime();
            writeTime();

            //Get the lists
            sList = ml.GetStaff();
            aList = ml.GetAppointments();


            #region comboBoxs
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

            foreach(Staff s in sList)
            {
                if (s.AuthLevel == 1 || s.AuthLevel == 2)
                {
                    cmbDoctor.Items.Add(s.FName + " " + s.LName);
                }
            }
            #endregion

        }

        private void mclCalander_DateSelected(object sender, DateRangeEventArgs e)
        {
            Debug.WriteLine(mclCalander.SelectionStart);

            //Searchs for Clashes in times
            foreach(Appointment a in aList)
            {
                //Searches staff appointments based off the staff member
                if (GetCurrent() != null)
                {
                    if (a.staffID == GetCurrent().StaffID)
                    {
                        timeList.Remove(a.appointmentTime);
                    }
                }
                //checks the availible staff off a timeslot
                else
                {
                    checkTimeSlot(a);
                }
            }

            writeTime();
        }

        private void frmBook_Load(object sender, EventArgs e)
        {
            //Full screens the window
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }

        private void btnSearchPatients_Click(object sender, EventArgs e)
        {
            frmQueryPatient queryPatient = new frmQueryPatient(this);

            this.Hide();
            queryPatient.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Takes a patient to display infomation on
        /// </summary>
        /// <param name="p"></param>
        public void TakePatient(Patient p)
        {
            current = p;
        }


        /// <summary>
        /// Fills the patient data with the selected patient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbDay_VisibleChanged(object sender, EventArgs e)
        {
            if (current != null)
            {
                txtNhsNum.Text = current.PatientID.ToString();
                txtFirstName.Text = current.FirstName;
                txtLastName.Text = current.LastName;
                cmbDay.Text = current.DoB.Day.ToString();
                cmbMonth.Text = current.DoB.Month.ToString();
                cmbYear.Text = current.DoB.Year.ToString();
            }
        }

        /// <summary>
        /// Submits the appointment to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ml.AddAppointment(current.PatientID, GetCurrent().StaffID, getTime(cmbTimeslot.Text), getTime(cmbTimeslot.Text).AddMinutes(5), txtDescription.Text);
        }

        /// <summary>
        /// Gets the current Staff member
        /// </summary>
        /// <returns>Current Selected Staff</returns>
        private Staff GetCurrent()
        {
            if (cmbDoctor.Text != null || cmbDoctor.Text == "")
            {
                foreach (Staff s in sList)
                {
                    if (cmbDoctor.Text == s.ToString())
                    {
                        return s;
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// Gets a dateTime from a string
        /// </summary>
        /// <param name="timeSlot"></param>
        /// <returns></returns>
        private DateTime getTime(string timeSlot)
        {
           return DateTime.ParseExact(timeSlot, "HH:mm:ss", CultureInfo.InvariantCulture);
        }



        /// <summary>
        /// Fills the times into timeList
        /// </summary>
        private void fillTime()
        {
            
            DateTime startTime = mclCalander.SelectionStart.AddHours(9);
            DateTime endTime = mclCalander.SelectionStart.AddHours(11);

            while (startTime < endTime)
            {
                timeList.Add(startTime);
                startTime = startTime.AddMinutes(inc);
            }

            startTime = mclCalander.SelectionStart.AddHours(14);
            endTime = mclCalander.SelectionStart.AddHours(16);

            while (startTime < endTime)
            {
                timeList.Add(startTime);
                startTime = startTime.AddMinutes(inc);
            }

            startTime = mclCalander.SelectionStart.AddHours(18);
            endTime = mclCalander.SelectionStart.AddHours(20);

            while (startTime < endTime)
            {
                timeList.Add(startTime);
                startTime = startTime.AddMinutes(inc);
            }

        }

        /// <summary>
        /// Writes the time of the appointments in 5 minute intervals
        /// </summary>
        private void writeTime()
        {
            cmbTimeslot.Items.Clear();
            foreach (DateTime appTime in timeList)
            {
                cmbTimeslot.Items.Add(appTime.TimeOfDay);
            }
        }

        /// <summary>
        /// Checks the timeslot based off the timeslot selected
        /// </summary>
        /// <param name="a"></param>
        private void checkTimeSlot(Appointment a)
        {
            foreach (Staff s in sList)
            {
                if (a.appointmentTime.TimeOfDay == getTime(cmbTimeslot.Text).TimeOfDay)
                {
                    cmbDoctor.Items.Remove(s.ToString());
                }

            }
        }


        private void cmbTimeslot_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (Appointment a in aList)
            {
                checkTimeSlot(a);
            }
        }
    }
}
