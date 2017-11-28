using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareEngineeringAssignment
{
    public partial class frmViewTest : Form
    {        
        Patient current;
        public frmViewTest()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

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
        private void frmViewTest_load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }
        public void TakePatient(Patient p)
        {
            current = p;
        }

        Bitmap bmp;
        private PrintDocument PrintPrescriptions = new PrintDocument();
        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintPrescriptions.PrintPage += new PrintPageEventHandler(printTestHistory_PrintPage);
            this.Controls.Add(btnPrint);
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Height, this.Width, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printDialog1.ShowDialog();
            PrintPrescriptions.Print();
        }

        private void printTestHistory_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmQueryPatient queryPatient = new frmQueryPatient(this);

            this.Hide();
            queryPatient.ShowDialog();
            this.Show();
        }      

        private void btnReturn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmViewTest_VisibleChanged(object sender, EventArgs e)
        {
            if (current != null)
            {
                txtID.Text = current.PatientID.ToString();
                txtFirstName.Text = current.FirstName;
                txtLastName.Text = current.LastName;
                cmbDay.Text = current.DoB.Day.ToString();
                cmbMonth.Text = current.DoB.Month.ToString();
                cmbYear.Text = current.DoB.Year.ToString();
            }
        }
    }
}
