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
        /// <summary>
        /// Constructor for Admin form
        /// </summary>
        public frmAdmin()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// Sets the form to full screen on load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAdmin_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }

        /// <summary>
        /// opens the add staff form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            frmAddStaff addStaff = new frmAddStaff();
            this.Hide();
            addStaff.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Opens the query staff form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFindStaff_Click(object sender, EventArgs e)
        {
            frmQueryStaff frmStaff = new frmQueryStaff();

            this.Hide();
            frmStaff.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Opens the Timetable form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTimetable_Click(object sender, EventArgs e)
        {
            frmTimetable frmTimetable = new frmTimetable();

            this.Hide();
            frmTimetable.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAdmin_Load_1(object sender, EventArgs e)
        { }
        /// <summary>
        /// Opens the UI form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUI_Click(object sender, EventArgs e)
        {
            frmBugReport frmBugReport = new frmBugReport();
            this.Hide();
            frmBugReport.ShowDialog();
            this.Show();
        }
    }
}
