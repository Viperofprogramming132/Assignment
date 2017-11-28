using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareEngineeringAssignment
{
    public partial class frmQueryStaff : Form
    {
        BackgroundWorker worker = new BackgroundWorker();
        List<Staff> sList = new List<Staff>();
        List<Staff> finS = new List<Staff>();
        frmTimetable m_TimeTable;

        int showing = 0;

        /// <summary>
        /// Constructor of query staff
        /// </summary>
        public frmQueryStaff()
        {
            InitializeComponent();

            setupForm();
        }

        /// <summary>
        /// Constructor for query staff from Timetable form
        /// </summary>
        /// <param name="timetable"></param>
        public frmQueryStaff(frmTimetable timetable)
        {
            m_TimeTable = timetable;
            InitializeComponent();

            setupForm();
        }

        /// <summary>
        /// Sets up the form with worker and fills combo box
        /// </summary>
        private void setupForm()
        {
            this.WindowState = FormWindowState.Maximized;

            cmbJob.Items.Add("GP");
            cmbJob.Items.Add("Nurse");
            cmbJob.Items.Add("Receptionist");
            cmbJob.Items.Add("General Staff");
            cmbJob.Items.Add("Manager");
            
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

            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
            worker.WorkerSupportsCancellation = true;
        }


        /// <summary>
        /// Gets the staff members
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            sList = null;
            finS.Clear();

            BusinessLayer ml = BusinessLayer.Instance();

            sList = ml.GetStaff();

            foreach (Staff s in sList)
            {
                if (((txtFirstName.Text != "" || txtFirstName.Text == null) && s.FName == txtFirstName.Text) || ((txtLastName.Text != "" || txtLastName.Text == null) && s.LName == txtLastName.Text) || ((txtID.Text != "" || txtID.Text == null) && s.StaffID.ToString() == txtID.Text))
                {
                    finS.Add(s);
                    worker.CancelAsync();
                }
            }
            
            if (worker.CancellationPending)
            {
                e.Cancel = true;
                return;
            }
        }

        /// <summary>
        /// On worker complete will display the users
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                populate(finS[0]);
            }
            catch
            {
                MessageBox.Show("Could not find any matching staff members");
            }
        }

        /// <summary>
        /// Sets the form full screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmQueryStaff_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }

        /// <summary>
        /// Runs the worker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!worker.IsBusy)
            {
                worker.RunWorkerAsync();
            }
        }

        /// <summary>
        /// populates infomation with the given staff
        /// </summary>
        /// <param name="s"></param>
        private void populate(Staff s)
        {
            showing = finS.IndexOf(s);
            buttonUpdate();

            txtFirstName.Text = s.FName;
            txtLastName.Text = s.LName;
            txtID.Text = s.StaffID.ToString();
            txtUserName.Text = s.UserName;

            cmbDay.Text = s.DoB.Day.ToString();
            cmbMonth.Text = s.DoB.Month.ToString();
            cmbYear.Text = s.DoB.Year.ToString();

            if(s.AuthLevel == (int)Staff.AuthenticationLevel.GP)
            {
                cmbJob.Text = "GP";
            }
            else if (s.AuthLevel == (int)Staff.AuthenticationLevel.Nurse)
            {
                cmbJob.Text = "Nurse";
            }
            else if (s.AuthLevel == (int)Staff.AuthenticationLevel.Receptionist)
            {
                cmbJob.Text = "Receptionist";
            }
            else if (s.AuthLevel == (int)Staff.AuthenticationLevel.GeneralStaff)
            {
                cmbJob.Text = "General Staff";
            }
            else if (s.AuthLevel == (int)Staff.AuthenticationLevel.Manager)
            {
                cmbJob.Text = "Manager";
            }
            else
            {
                cmbJob.Text = "Unknown";
            }
        }

        /// <summary>
        /// Enables and disables buttons based off how many are in the list
        /// </summary>
        private void buttonUpdate()
        {
            if (showing == 0)
            {
                btnBack.Enabled = false;
            }
            else
            {
                btnBack.Enabled = true;
            }
            if (showing == finS.Count - 1)
            {
                btnForward.Enabled = false;
            }
            else
            {
                btnForward.Enabled = true;
            }

        }

        /// <summary>
        /// Confirm use of staff member
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (m_TimeTable != null)
            {
                DialogResult dr = MessageBox.Show("Are you sure you wish to use " + finS[showing].ToString(), "Confirm", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {
                    m_TimeTable.takeStaff(finS[showing]);
                }
            }
            this.Close();
        }

        /// <summary>
        /// Opens add staff member form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnadd_staff_Click(object sender, EventArgs e)
        {
            frmAddStaff addStaff = new frmAddStaff();
            this.Hide();
            addStaff.ShowDialog();
            this.Show();
        }

        private void frmQueryStaff_FormClosing(object sender, FormClosingEventArgs e)
        {
            Update();
        }

        /// <summary>
        /// Gets the time from a string
        /// </summary>
        /// <param name="timeSlot"></param>
        /// <returns></returns>
        private DateTime getTime(string timeSlot)
        {
            if (timeSlot != "")
            {
                DateTime dateofbirth = Convert.ToDateTime(timeSlot + " 00:00:00.00");

                return dateofbirth;
            }
            return DateTime.Now;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            showing++;
            buttonUpdate();
            populate(finS[showing]);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            showing--;
            buttonUpdate();
            populate(finS[showing]);
        }
        private void UpdatePerson()
        {
            if (finS[showing].FName != txtFirstName.Text || finS[showing].LName != txtLastName.Text || finS[showing].DoB.Day.ToString() != cmbDay.Text || finS[showing].DoB.Month.ToString() != cmbYear.Text || finS[showing].DoB.Year.ToString() != cmbYear.Text || finS[showing].UserName != txtUserName.Text)
            {

                DialogResult dr = MessageBox.Show("Do you want to save changes to " + finS[showing].ToString(), "Confirm", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {
                    BusinessLayer ml = BusinessLayer.Instance();
                    MessageBox.Show(ml.UpdateStafffrm(txtFirstName.Text, txtLastName.Text, getTime(cmbDay.Text + "/" + cmbMonth.Text + "/" + cmbYear.Text), txtUserName.Text, finS[showing].StaffID) + " Number of entries updated");

                }
            }


        }
    }
}
