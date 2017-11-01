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
        public frmAddStaff()
        {
            InitializeComponent();

            cmbAuthLevel.Items.Add("GP");
            cmbAuthLevel.Items.Add("Nurse");
            cmbAuthLevel.Items.Add("Receptionist");
            cmbAuthLevel.Items.Add("General Staff");
            cmbAuthLevel.Items.Add("Manager");
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            int authL;
            BusinessLayer bl = BusinessLayer.instance();

            if (cmbAuthLevel.Text == "GP")
            {
                authL = 1;
            }
            if (cmbAuthLevel.Text == "Nurse")
            {
                authL = 2;
            }
            if (cmbAuthLevel.Text == "Receptionist")
            {
                authL = 3;
            }
            if (cmbAuthLevel.Text == "General Staff")
            {
                authL = 4;
            }
            if (cmbAuthLevel.Text == "Manager")
            {
                authL = 5;
            }
            else
            {
                authL = 4;
            }

            bl.addStaff(txtFirstName.Text, txtLastName.Text, txtUserName.Text, txtPassword.Text, authL ,1,DateTime.Now);
        }
    }
}
