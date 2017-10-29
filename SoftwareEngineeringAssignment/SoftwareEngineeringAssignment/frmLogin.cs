﻿using System;
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
    public partial class frmLogin : Form
    {
        List<Staff> m_staff;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            BusinessLayer ml = BusinessLayer.instance();
            m_staff = ml.getStaff();

            //do for each for every staff
            //if(m_staff.username == txtUsername.Text && m_staff.password == txtPassword.Text)
            //open main form sending that staff member

            frmMain Main = new frmMain(new Staff());
            this.Hide();
            Main.ShowDialog();
            this.Show();
        }
    }
}
