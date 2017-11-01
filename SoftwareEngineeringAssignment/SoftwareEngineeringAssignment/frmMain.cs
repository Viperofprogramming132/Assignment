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
        public frmMain(Staff member)
        {
            InitializeComponent();
            lblWelcome.Text = "Welcome " + member.FName + " " + member.LName;
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
            frmAddStaff queryPatient = new frmAddStaff();
            this.Hide();
            queryPatient.ShowDialog();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
