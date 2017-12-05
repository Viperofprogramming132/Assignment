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
        Address currentAddress;
        /// <summary>
        /// Constructor for the add patient form
        /// </summary>
        public frmAddPatient()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// Sets the form full screen on load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAddPatient_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }

        /// <summary>
        /// Button press to add the patient to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            BusinessLayer ml = BusinessLayer.Instance();

            ml.AddPatient(txtFirstname.Text, txtLastname.Text, Convert.ToDateTime(mclDoB.SelectionStart) , txtReligion.Text,txtAllergies.Text,txtNextOfKin.Text,txtNoKTele.Text,txtEmailAddress.Text, currentAddress.AddressID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmQueryAddress queryAddress = new frmQueryAddress(this);
            this.Hide();
            queryAddress.ShowDialog();
            this.Show();
        }

        public void TakeAddress(Address a)
        {
            currentAddress = a;

            txtAddress.Text = a.ToString();
        }
    }
}
