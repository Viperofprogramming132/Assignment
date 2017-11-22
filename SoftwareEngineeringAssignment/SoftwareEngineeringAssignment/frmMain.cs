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
    public partial class frmMain : Form

    {
        Staff member = new Staff();

        /// <summary>
        /// Constructor for the main menu reciving a staff member that you are logged in as
        /// </summary>
        /// <param name="member"></param>
        public frmMain(Staff member)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.member = member;
            lblWelcome.Text = "Welcome " + member.FName + " " + member.LName;
            loaded();
        }

        #region button presses
        /// <summary>
        /// Shows the Book Appointment Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBookAppointment_Click(object sender, EventArgs e)
        {
            frmBook book = new frmBook();
            this.Hide();
            book.ShowDialog();
            this.Show();
        }

        private void btnChangeAppontments_Click(object sender, EventArgs e)
        {
            frmQueryAppointment change = new frmQueryAppointment();
            this.Hide();
            change.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Closes this form returning to login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogOff_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Shows the add staff form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            frmAddStaff staffAdd = new frmAddStaff();
            this.Hide();
            staffAdd.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Shows the query patients form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSeachPatients_Click(object sender, EventArgs e)
        {
            frmViewAppointments queryAppointments = new frmViewAppointments(member);
            this.Hide();
            queryAppointments.ShowDialog();
            this.Show();
        }


        /// <summary>
        /// Shows the add patient form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            frmAddPatient addPatient = new frmAddPatient();
            this.Hide();
            addPatient.ShowDialog();
            this.Show();
        }


        /// <summary>
        /// Shows the add perscription form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddPerscription_Click(object sender, EventArgs e)
        {
            frmAddPerscription addPerscription = new frmAddPerscription();
            this.Hide();
            addPerscription.ShowDialog();
            this.Show();
        }


        /// <summary>
        /// Shows the query perscription form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditPerscription_Click(object sender, EventArgs e)
        {
            frmQueryPerscription queryPerscription = new frmQueryPerscription();
            this.Hide();
            queryPerscription.ShowDialog();
            this.Show();
        }


        /// <summary>
        /// Shows the admin form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmAdmin admin = new frmAdmin();
            this.Hide();
            admin.ShowDialog();
            this.Show();
        }

        #endregion

        /// <summary>
        /// Sets the form to full screen on load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;

        }


        /// <summary>
        /// Sorts out the visability of the buttons based off the permission level
        /// </summary>
        private void loaded()
        {

            if (member.AuthLevel == (int)Staff.AuthenticationLevel.GP)
            {
                btnAdmin.Hide();
                btnBookAppointment.Hide();
                btnAddPerscription.Location = btnBookAppointment.Location;
            }
            else if (member.AuthLevel == (int)Staff.AuthenticationLevel.Nurse)
            {
                btnAdmin.Hide();
                btnBookAppointment.Hide();
                btnAddPerscription.Location = btnBookAppointment.Location;
            }
            else if (member.AuthLevel == (int)Staff.AuthenticationLevel.Receptionist)
            {
                btnAdmin.Hide();
                btnEditPerscription.Hide();
                btnAddPerscription.Hide();
            }
            else if (member.AuthLevel == (int)Staff.AuthenticationLevel.GeneralStaff)
            {
                btnBookAppointment.Hide();
                btnAdmin.Hide();
            }
            else if (member.AuthLevel == (int)Staff.AuthenticationLevel.Manager)
            {
                btnBookAppointment.Hide();
                btnEditPerscription.Hide();
                btnViewAppointments.Hide();
                btnAddPerscription.Hide();
                btnAdmin.Location = btnBookAppointment.Location;
            }
        }

        private void btnTimeTable_Click(object sender, EventArgs e)
        {
            frmViewTimetable timetables = new frmViewTimetable(member);

            this.Hide();
            timetables.ShowDialog();
            this.Show();
        }

    }
}
