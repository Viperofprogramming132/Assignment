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

        private void btnBookAppointment_Click(object sender, EventArgs e)
        {
            frmBook book = new frmBook();
            this.Hide();
            book.ShowDialog();
            this.Show();
        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {

        }

        private void btnSeachPatients_Click(object sender, EventArgs e)
        {

        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {

        }

        private void btnAddPerscription_Click(object sender, EventArgs e)
        {

        }

        private void btnEditPerscription_Click(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {

        }
    }
}
