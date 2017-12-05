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
    public partial class frmAddAddress : Form
    {
        public frmAddAddress()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtPostCode.Text != "" && txtAddress.Text != "" && txtCity.Text != "")
            {
                BusinessLayer ml = BusinessLayer.Instance();

                ml.AddAddress(txtAddress.Text, txtCity.Text, txtPOBox.Text, txtPostCode.Text);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
