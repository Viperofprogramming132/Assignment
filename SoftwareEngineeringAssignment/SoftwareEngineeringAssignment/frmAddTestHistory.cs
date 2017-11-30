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
    public partial class frmAddTestHistory : Form
    {
        List<Testing> dList = new List<Testing>();
        Patient currentP = new Patient();
        Testing currentT = new Testing();

        public frmAddTestHistory()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmAddTestHistory_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }
        private void populate()
        {
            txtTestResult.Text = currentT.ReasonForTest.ToString();
            txtTestReason.Text = currentT.Result.ToString();
        }

        private void Populate(Patient p)
        {
            txtFirstName.Text = currentP.FirstName;
            txtLastName.Text = currentP.LastName;
            txtID.Text = currentP.PatientID.ToString();

            cmbDay.Text = currentP.DoB.Date.ToString();
            cmbMonth.Text = currentP.DoB.Month.ToString();
            cmbYear.Text = currentP.DoB.Year.ToString();
        }

        public void TakePatient(Patient p)
        {
            currentP = p;
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (currentT == null)
            {
                MessageBox.Show("Please add a test to patient's history");
            }
            if (currentP == null)
            {
                MessageBox.Show("Please Select a Patient to add a test to");
            }
            else
            {
                BusinessLayer ml = BusinessLayer.Instance();

                ml.AddTestHistory(txtTestReason.Text, txtTestResult.Text);
            }
        }

        private void frmAddTestHistory_VisibleChanged(object sender, EventArgs e)
        {
            if (currentP != null)
            {
                txtID.Text = currentP.PatientID.ToString();
                txtFirstName.Text = currentP.FirstName;
                txtLastName.Text = currentP.LastName;
                cmbDay.Text = currentP.DoB.Day.ToString();
                cmbMonth.Text = currentP.DoB.Month.ToString();
                cmbYear.Text = currentP.DoB.Year.ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmQueryPatient queryPatient = new frmQueryPatient(this);

            this.Hide();
            queryPatient.ShowDialog();
            this.Show();

            Populate(currentP);
        }
    }
}
