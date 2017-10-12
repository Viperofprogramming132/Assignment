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
    public partial class frmQueryPatient : Form
    {
        public frmQueryPatient()
        {
            InitializeComponent();
            lsvPerscriptions.View = View.Details;


            lsvPerscriptions.Columns.Add("Drug ID", -2, HorizontalAlignment.Left);
            lsvPerscriptions.Columns.Add("Drug Name", -2, HorizontalAlignment.Left);
            lsvPerscriptions.Columns.Add("Date Perscribed", -2, HorizontalAlignment.Left);
            lsvPerscriptions.Columns.Add("Expiry Date", -2, HorizontalAlignment.Left);

            for (int i = 1; i <= 31; i++)
            {
                cmbDay.Items.Add(i);
            }

            for (int i = 1; i <= 12; i++)
            {
                cmbMonth.Items.Add(i);
            }
            for (int i = 1900; i <= DateTime.Now.Year; i++)
            {
                cmbYear.Items.Add(i);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //database query this info
        }

        private void lsvPerscriptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsvPerscriptions.FullRowSelect = true;
        }
    }
}
