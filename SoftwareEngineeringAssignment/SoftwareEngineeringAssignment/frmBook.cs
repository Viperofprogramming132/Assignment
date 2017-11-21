using System;
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
using System.Net.Mail;

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

        /// <summary>
        /// Constructor for booking form
        /// </summary>
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
            //Fills the combo boxs
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
                if (s.AuthLevel == (int)Staff.AuthenticationLevel.GP || s.AuthLevel == (int)Staff.AuthenticationLevel.Nurse)
                {
                    cmbDoctor.Items.Add(s.FName + " " + s.LName);
                }
            }
            #endregion

        }

        /// <summary>
        /// On date selected check for any appointments on that day and check remove from combobox what is not availible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mclCalander_DateSelected(object sender, DateRangeEventArgs e)
        {
            Debug.WriteLine(mclCalander.SelectionStart);

            //Searchs for Clashes in times
            foreach(Appointment a in aList)
            {
                //Searches staff appointments based off the staff member
                if (GetCurrent() != null)
                {
                    if (a.StaffID == GetCurrent().StaffID)
                    {
                        timeList.Remove(a.AppointmentTime);
                    }
                }
                //checks the availible staff off a timeslot
                else
                {
                    fillTime();
                    checkTimeSlot(a);
                }
            }

            writeTime();
        }

        /// <summary>
        /// Makes form full screen on load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBook_Load(object sender, EventArgs e)
        {
            //Full screens the window
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }

        /// <summary>
        /// Opens query patient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            try
            {
                //TODO: change the email system currently crashes every run

                //ml.GetPatients(current.Email);
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("you_address@gmail.com");
                mail.To.Add("");
                mail.Subject = "Test Mail - 1";
                mail.Body = "Appointment booking";



                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("", "infamous");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);


                MessageBox.Show("Message Sent");
            }
            catch
            {
                MessageBox.Show("Message not sent");
            }
            
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
            if(timeSlot != "")
            {
                DateTime date = mclCalander.SelectionStart;
                DateTime time = DateTime.ParseExact(timeSlot, "HH:mm:ss", CultureInfo.InvariantCulture);

                DateTime dateTime = date.AddHours(time.Hour).AddMinutes(time.Minute);
                return dateTime;
            }
            return DateTime.Now;
        }



        /// <summary>
        /// Fills the times into timeList
        /// </summary>
        private void fillTime()
        {
            cmbTimeslot.Items.Clear();
            cmbTimeslot.ResetText();
            timeList.Clear();
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
                if (a.AppointmentTime.TimeOfDay == getTime(cmbTimeslot.Text).TimeOfDay)
                {
                    cmbDoctor.Items.Remove(s.ToString());
                }

            }
        }

        /// <summary>
        /// When timeslot is chosen checks its availibility
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbTimeslot_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (Appointment a in aList)
            {
                checkTimeSlot(a);
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
    }
}
