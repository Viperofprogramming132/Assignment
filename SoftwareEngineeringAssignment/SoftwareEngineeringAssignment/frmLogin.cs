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
using System.Net.Mail;


namespace SoftwareEngineeringAssignment
{
    public partial class frmLogin : Form
    {
        BackgroundWorker worker = new BackgroundWorker();
        List<Staff> m_staff;
        Staff staffMember;
        int keyPressed;

        /// <summary>
        /// Constructor for login form
        /// </summary>
        public frmLogin()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            
            //Sets up the worker
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
            worker.WorkerSupportsCancellation = true;

            this.KeyDown += btnSubmit_Click;
            txtPassword.KeyDown += btnSubmit_Click;
        }

        /// <summary>
        /// Starts the worker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!worker.IsBusy)
            {
                worker.RunWorkerAsync();
            }
           
        }

        /// <summary>
        /// Opens the main menu form if there was a user found
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                if (keyPressed == (int)Keys.Enter)
                {
                    frmMain Main = new frmMain(staffMember);
                    this.Hide();
                    Main.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                if (keyPressed == (int) Keys.Enter)
                {
                    MessageBox.Show("No user found with that username and password.\nPlease Try Again");
                }
                
            }
        }

        /// <summary>
        /// Checks all user data with the inputed data to see if there is a successfull login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        /// <summary>
        /// On load sets the form to full screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }

        /// <summary>
        /// Clears the text boxes on show
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLogin_VisibleChanged(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtUsername.Clear();
        }


        /// <summary>
        /// Enter button key check
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            keyPressed = e.KeyValue;
        }


        /// <summary>
        /// Enter button key check
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            keyPressed = e.KeyValue;
        }

        /// <summary>
        /// Enter button key check
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            
        }


        /// <summary>
        /// Closes the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
