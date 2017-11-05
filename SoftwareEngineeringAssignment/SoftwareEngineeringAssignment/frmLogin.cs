using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SoftwareEngineeringAssignment
{
    public partial class frmLogin : Form
    {
        BackgroundWorker worker = new BackgroundWorker();
        List<Staff> m_staff;
        Staff staffMember;
        public frmLogin()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
            worker.WorkerSupportsCancellation = true;
        }

    
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!worker.IsBusy)
            {
                worker.RunWorkerAsync();
            }
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                frmMain Main = new frmMain(staffMember);
                this.Hide();
                Main.ShowDialog();
                this.Show();
            }
        }


        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            BusinessLayer ml = BusinessLayer.Instance();
            m_staff = ml.GetStaff();

            foreach (Staff s in m_staff)
            {
                
                if (s.UserName == txtUsername.Text && s.Password == txtPassword.Text)
                {
                    staffMember = s;
                    worker.CancelAsync();
                }

                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }


        private void frmLogin_VisibleChanged(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtUsername.Clear();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtUsername.KeyDown += btnSubmit_Click;
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.KeyDown += btnSubmit_Click;
            }
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.KeyDown += btnSubmit_Click;
            }
        }
    }
}
