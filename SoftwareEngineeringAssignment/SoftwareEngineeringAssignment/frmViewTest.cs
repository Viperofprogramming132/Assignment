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
        List<Testing> testList = new List<Testing>();
        private int SelectedTest = 0;
        Bitmap bmp;
        private PrintDocument PrintTest = new PrintDocument();

        public frmViewTest()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// Makes the form full screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmViewTest_load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }

        /// <summary>
        /// Takes the patient and adds it to the form
        /// </summary>
        /// <param name="p"></param>
        public void TakePatient(Patient p)
        {
            current = p;
        }


        
        /// <summary>
        /// Prints the form as an image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Click(object sender, EventArgs e)
        {

            try
            {
                PrintTest.PrintPage += new PrintPageEventHandler(printTestHistory_PrintPage);
                this.Controls.Add(btnPrint);
                Graphics g = this.CreateGraphics();
                bmp = new Bitmap(this.Height, this.Width, g);
                Graphics mg = Graphics.FromImage(bmp);
                mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
                printDialog1.ShowDialog();
                
                PrintTest.Print();
            }
            catch
            {
                
                MessageBox.Show("You have not printed");
            }
        }

        private void printTestHistory_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        /// <summary>
        /// Opens Search for patient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmQueryPatient queryPatient = new frmQueryPatient(this);

            this.Hide();
            queryPatient.ShowDialog();
            this.Show();
        }      

        /// <summary>
        /// Closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Gets the tests and updates the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmViewTest_VisibleChanged(object sender, EventArgs e)
        {
            if (current != null)
            {
                BusinessLayer ml = BusinessLayer.Instance();

                testList = ml.GetTest(current.PatientID);
                populate();
            }
        }

        /// <summary>
        /// Updates the form with the information it has
        /// </summary>
        private void populate()
        {
            if (current != null)
            {
                txtID.Text = current.PatientID.ToString();
                txtFirstName.Text = current.FirstName;
                txtLastName.Text = current.LastName;
                cmbDay.Text = current.DoB.Day.ToString();
                cmbMonth.Text = current.DoB.Month.ToString();
                cmbYear.Text = current.DoB.Year.ToString();

                txtTestReason.Text = testList[SelectedTest].ReasonForTest;
                txtTestResult.Text = testList[SelectedTest].Result;
                mclDateOfTest.SelectionStart = testList[SelectedTest].Date;
                mclDateOfTest.SelectionEnd = testList[SelectedTest].Date;

                updateButtons();
            }
        }

        /// <summary>
        /// Shows the next test
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnForward_Click(object sender, EventArgs e)
        {
            SelectedTest++;
            updateButtons();
            populate();
        }

        /// <summary>
        /// Disables and enables the buttons to stop a crash
        /// </summary>
        private void updateButtons()
        {
            if (SelectedTest == 0)
            {
                btnBack.Enabled = false;
            }
            else
            {
                btnBack.Enabled = true;
            }
            if (SelectedTest == testList.Count - 1)
            {
                btnForward.Enabled = false;
            }
            else
            {
                btnForward.Enabled = true;
            }
        }


        /// <summary>
        /// Shows the previous test
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            SelectedTest--;
            updateButtons();
            populate();
        }

        /// <summary>
        /// Updates the test in the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                BusinessLayer ml = BusinessLayer.Instance();

                ml.UpdateTest(txtTestReason.Text, txtTestResult.Text, mclDateOfTest.SelectionStart, testList[SelectedTest].ID);
            }
        }
    }
}
