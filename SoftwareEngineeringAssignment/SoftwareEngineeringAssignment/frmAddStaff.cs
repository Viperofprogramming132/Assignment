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
        public frmAddStaff()
        {
            InitializeComponent();

            cmbAuthLevel.Items.Add("GP");
            cmbAuthLevel.Items.Add("Nurse");
            cmbAuthLevel.Items.Add("Receptionist");
            cmbAuthLevel.Items.Add("General Staff");
            cmbAuthLevel.Items.Add("Manager");

            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
            worker.WorkerSupportsCancellation = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            throw new NotImplementedException();
        }

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
        }

        private void frmAddStaff_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }
    }
}
