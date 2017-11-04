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

        List<Staff> m_staff;
        public frmLogin()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

    
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            BusinessLayer ml = BusinessLayer.instance();
            m_staff = ml.getStaff();

            //foreach(Staff s in m_staff)
            //{
                //if (s.UserName == txtUsername.Text && s.Password == txtPassword.Text)
                //{
                    frmMain Main = new frmMain(new Staff());
                    this.Hide();
                    Main.ShowDialog();
                    this.Show();
                //}
            //}


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
