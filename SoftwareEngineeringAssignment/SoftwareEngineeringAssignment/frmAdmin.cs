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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            frmAddStaff addStaff = new frmAddStaff();
            this.Hide();
            addStaff.ShowDialog();
            this.Show();
        }

        private void btnFindStaff_Click(object sender, EventArgs e)
        {
            new frmQueryStaff().Show();
        }

        private void btnTimetable_Click(object sender, EventArgs e)
        {
            frmTimetable frmTimetable = new frmTimetable();

            this.Hide();
            frmTimetable.ShowDialog();
            this.Show();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUI_Click(object sender, EventArgs e)
        {

        }
    }
}
