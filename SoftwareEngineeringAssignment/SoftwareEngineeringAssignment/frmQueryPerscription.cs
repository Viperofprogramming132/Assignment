using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace SoftwareEngineeringAssignment
{
    public partial class frmQueryPerscription : Form
    {
        Patient current;
        List<Drug> dList = new List<Drug>();
        Drug currentD = new Drug();
        List<Perscription> perList = new List<Perscription>();
        /// <summary>
        /// Constructor for the query perscription form
        /// </summary>
        public frmQueryPerscription()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// Sets the form full screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmQueryPerscription_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }


        /// <summary>
        /// Closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Opens add perscription
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_add_Click(object sender, EventArgs e)
        {
            frmAddPerscription addPerscription = new frmAddPerscription();
            this.Hide();
            addPerscription.ShowDialog();
            this.Show();
        }


        public void frmFillDrugs()
        {
            //Order the drugs alphabeticly
            List<Drug> temp = dList.OrderBy(x => x.DrugName).ToList();
            int i = 0;
            foreach (Drug d in temp)
            {
                dList[i] = temp[i];
                i++;
            }

            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            //Populate the drugs
            for (i = 1; i <= dList.Count; i++)
            {
                cmbDrugID.Items.Add(i);
            }

            foreach (Drug d in dList)
            {
                cmbDrugName.Items.Add(d.DrugName);
            }

        }




        private void PrintPrescriptions_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        Bitmap bmp;

        private PrintDocument PrintPrescriptions = new PrintDocument();



        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                PrintPrescriptions.PrintPage += new PrintPageEventHandler(PrintPrescriptions_PrintPage);
                this.Controls.Add(btnPrint);
                Graphics g = this.CreateGraphics();
                bmp = new Bitmap(this.Height, this.Width, g);
                Graphics mg = Graphics.FromImage(bmp);
                mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
                printDialog1.ShowDialog();
                PrintPrescriptions.Print();
            }
            catch
            {
                MessageBox.Show("Printer is'nt working");
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmQueryPatient qp = new frmQueryPatient(this);
            this.Hide();
            qp.ShowDialog();
            this.Show();

            populate(current);
        }

        public void TakePatient(Patient p)
        {
            current = p;
        }

        private void populate(Patient patient)
        {
            txtID.Text = current.PatientID.ToString();
            txtFirstName.Text = current.FirstName;
            txtLastName.Text = current.LastName;
            cmbDay.Text = current.DoB.Day.ToString();
            cmbMonth.Text = current.DoB.Month.ToString();
            cmbYear.Text = current.DoB.Year.ToString();

            BusinessLayer ml = BusinessLayer.Instance();

            perList = ml.GetPerscriptions(current.PatientID);

            cmbDrugID.Text = perList[0].DrugID.ToString();
            cmbDrugName.Text = currentD.DrugName;
            txtDrugDescription.Text = currentD.Description;
        }

        private void Populate()
        {

        }


    }
}
