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
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            BusinessLayer bl = BusinessLayer.instance();

            bl.addStaff(txtFirstName.Text, txtLastName.Text, txtUserName.Text, txtPassword.Text, Convert.ToInt32(txtAuthLevel.Text),1,DateTime.Now);
        }
    }
}
