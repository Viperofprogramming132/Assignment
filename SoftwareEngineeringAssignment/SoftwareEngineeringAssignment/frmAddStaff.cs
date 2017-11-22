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
    public partial class frmAddStaff : Form
    {
        BackgroundWorker worker = new BackgroundWorker();
        DateTime DoB = DateTime.Now;
        int selectedLevel;
        /// <summary>
        /// Constructor for the add staff
        /// </summary>
        public frmAddStaff()
        {
            InitializeComponent();

            cmbAuthLevel.Items.Add("GP");
            cmbAuthLevel.Items.Add("Nurse");
            cmbAuthLevel.Items.Add("Receptionist");
            cmbAuthLevel.Items.Add("General Staff");
            cmbAuthLevel.Items.Add("Manager");

            //set up background worker
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
            worker.WorkerSupportsCancellation = true;

            this.WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// When the background worker is complete will update pop up a message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("User added");
        }

        /// <summary>
        /// Database connection to add staff to database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            BusinessLayer bl = BusinessLayer.Instance();

            bl.AddStaff(txtFirstName.Text, txtLastName.Text, txtUserName.Text, txtPassword.Text, selectedLevel, 1, DoB);
        }

        /// <summary>
        /// Starts the worker to do the database connection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGo_Click(object sender, EventArgs e)
        {

            BusinessLayer bl = BusinessLayer.Instance();
            if (cmbAuthLevel.SelectedIndex != -1)
            {
                bl.AddStaff(txtFirstName.Text, txtLastName.Text, txtUserName.Text, txtPassword.Text, cmbAuthLevel.SelectedIndex, 1, DateTime.Now);
            }
            else
            {
                MessageBox.Show("Please select a Job");
            }
        

            worker.RunWorkerAsync();
 
        }

        /// <summary>
        /// Sets the form to full screen on load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAddStaff_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
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

        private void mclDoB_DateChanged(object sender, DateRangeEventArgs e)
        {
            DoB = mclDoB.SelectionStart;
        }

        private void cmbAuthLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedLevel = cmbAuthLevel.SelectedIndex;
        }
    }
}
