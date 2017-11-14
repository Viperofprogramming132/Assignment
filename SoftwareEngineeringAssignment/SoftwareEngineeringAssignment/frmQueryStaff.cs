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
    public partial class frmQueryStaff : Form
    {
        BackgroundWorker worker = new BackgroundWorker();
        List<Staff> sList = new List<Staff>();
        List<Staff> finS = new List<Staff>();
        frmTimetable m_TimeTable;

        int showing = 0;
        public frmQueryStaff()
        {
            InitializeComponent();

            setupForm();
        }

        public frmQueryStaff(frmTimetable timetable)
        {
            m_TimeTable = timetable;
            InitializeComponent();

            setupForm();
        }

        private void setupForm()
        {
            this.WindowState = FormWindowState.Maximized;

            cmbJob.Items.Add("GP");
            cmbJob.Items.Add("Nurse");
            cmbJob.Items.Add("Receptionist");
            cmbJob.Items.Add("General Staff");
            cmbJob.Items.Add("Manager");

            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
            worker.WorkerSupportsCancellation = true;
        }
        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
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

        private void frmQueryStaff_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            worker.RunWorkerAsync();
        }

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

            if(s.AuthLevel == 1)
            {
                cmbJob.Text = "GP";
            }
            else if (s.AuthLevel == 2)
            {
                cmbJob.Text = "Nurse";
            }
            else if (s.AuthLevel == 3)
            {
                cmbJob.Text = "Receptionist";
            }
            else if (s.AuthLevel == 4)
            {
                cmbJob.Text = "General Staff";
            }
            else if (s.AuthLevel == 5)
            {
                cmbJob.Text = "Manager";
            }
        }

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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you wish to use" + finS[showing].ToString(), "Confirm", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                m_TimeTable.takeStaff(finS[showing]);
            }
        }

        private void btnadd_staff_Click(object sender, EventArgs e)
        {
            frmAddStaff addStaff = new frmAddStaff();
            this.Hide();
            addStaff.ShowDialog();
            this.Show();
        }

        private void frmQueryStaff_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (finS[showing].FName != txtFirstName.Text || finS[showing].LName != txtLastName.Text || finS[showing].DoB.Day.ToString() != cmbDay.Text || finS[showing].DoB.Month.ToString() != cmbYear.Text || finS[showing].DoB.Year.ToString() != cmbYear.Text || finS[showing].UserName != txtUserName.Text)
            {

                DialogResult dr = MessageBox.Show("Are you sure you wish to use" + finS[showing].ToString(), "Confirm", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {
                    BusinessLayer ml = BusinessLayer.Instance();
                    ml.UpdateStafffrm( finS[showing].FName, finS[showing].LName, finS[showing].DoB, finS[showing].UserName);

                }
            }
        }
    }
}
