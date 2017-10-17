using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SoftwareEngineeringAssignment
{
    public partial class frmBook : Form
    {
        List<Patient> pList = new List<Patient>();

        Patient current;
        public frmBook()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            for (int i = 1; i <= 30; i++)
            {
                pList.Add(new Patient("1", "2", "3", "4", i.ToString() + 12345, "Bob", i + 54321.ToString(), "something", DateTime.UtcNow));
            }

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

        private void mclCalander_DateSelected(object sender, DateRangeEventArgs e)
        {
            Debug.WriteLine(mclCalander.SelectionStart);

            //would database search availiblity on that date
        }

        private void frmBook_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }

        private void btnSearchPatients_Click(object sender, EventArgs e)
        {
            frmQueryPatient queryPatient = new frmQueryPatient(this);

            queryPatient.takePatient(pList);
            this.Hide();
            queryPatient.ShowDialog();
            this.Show();
        }

        public void takePatient(Patient p)
        {
            current = p;
        }
    }
}
