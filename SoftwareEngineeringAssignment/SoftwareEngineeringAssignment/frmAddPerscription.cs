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
    public partial class frmAddPerscription : Form
    {
        List<Drug> dList = new List<Drug>();
        List<Patient> pList = new List<Patient>();
        Patient currentP = new Patient();
        Drug currentD = new Drug();

        public frmAddPerscription()
        {
            BusinessLayer ml = BusinessLayer.Instance();

            dList = ml.GetDrugs();
            pList = ml.GetPatients();

            List<Drug> temp = dList.OrderBy(x => x.DrugName).ToList();
            int i = 0;
            foreach(Drug d in temp)
            {
                dList[i] = temp[i];
                i++;
            }

            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            for(i=1;i<=dList.Count;i++)
            {
                cmbDrugID.Items.Add(i);
            }

            foreach (Drug d in dList)
            {
                cmbDrugName.Items.Add(d.DrugName);
            }

            mclEndDate.SelectionStart = mclStartDate.SelectionStart.AddDays(7);
            mclEndDate.SelectionEnd = mclStartDate.SelectionEnd.AddDays(7);
        }

        private void frmAddPerscription_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }

        private void cmbDrugName_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (Drug d in dList)
            {
                if (d.DrugName.ToString() == this.cmbDrugName.Text)
                {
                    currentD = d;
                    Populate();
                }
            }
        }

        private void Populate()
        {
            cmbDrugID.Text = currentD.DrugID.ToString();
            cmbDrugName.Text = currentD.DrugName;
            txtDrugDescription.Text = currentD.Description;
        }

        private void Populate(Patient p)
        {
            txtFirstName.Text = p.FirstName;
            txtLastName.Text = p.LastName;
            txtNhsNum.Text = p.PatientID.ToString();

            cmbDay.Text = p.DoB.Date.ToString();
            cmbMonth.Text = p.DoB.Month.ToString();
            cmbYear.Text = p.DoB.Year.ToString();
        }

        private void cmbDrugID_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach(Drug d in dList)
            {
                if(d.DrugID.ToString() == this.cmbDrugID.Text)
                {
                    currentD = d;
                    Populate();
                }
            }
            
        }

        public void TakePatient(Patient p)
        {
            currentP = p;
        }

        private void btnSearchPatients_Click(object sender, EventArgs e)
        {
            frmQueryPatient queryPatient = new frmQueryPatient(this);

            this.Hide();
            queryPatient.ShowDialog();
            this.Show();

            Populate(currentP);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(currentD == null)
            {
                MessageBox.Show("Please Select a Drug to perscribe");
            }
            if (currentP == null)
            {
                MessageBox.Show("Please Select a Patient to perscribe a drug to");
            }
            else
            {
                BusinessLayer ml = BusinessLayer.Instance();

                ml.AddPerscription(currentP.PatientID, currentD.DrugID, mclStartDate.SelectionStart, mclEndDate.SelectionStart, txtReason.Text);
            }
        }
    }
}
