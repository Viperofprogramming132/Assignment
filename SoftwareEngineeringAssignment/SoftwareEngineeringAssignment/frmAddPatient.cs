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
    public partial class frmAddPatient : Form
    {
        public frmAddPatient()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmAddPatient_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            BusinessLayer ml = BusinessLayer.instance();

            ml.addPatient(txtFirstname.Text, txtLastname.Text, mclDoB.ToString(), txtReligion.Text);
        }
    }
}
