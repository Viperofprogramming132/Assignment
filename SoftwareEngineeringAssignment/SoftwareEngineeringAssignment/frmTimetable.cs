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
    public partial class frmTimetable : Form
    {
        Staff current = new Staff();
        public frmTimetable()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmQueryStaff queryStaff = new frmQueryStaff();

            this.Hide();
            queryStaff.ShowDialog();
            this.Show();
        }

        public void takeStaff(Staff s)
        {
            current = s;
        }
    }
}
