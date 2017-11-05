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
        Patient current = new Patient();

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
                    Populate(d);
                }
            }
        }

        private void Populate(Drug d)
        {
            cmbDrugID.Text = d.DrugID.ToString();
            cmbDrugName.Text = d.DrugName;
            txtDrugDescription.Text = d.Description;
        }

        private void Populate(Patient p)
        {
            cmbDrugID.Text = d.DrugID.ToString();
            cmbDrugName.Text = d.DrugName;
            txtDrugDescription.Text = d.Description;
        }

        private void cmbDrugID_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach(Drug d in dList)
            {
                if(d.DrugID.ToString() == this.cmbDrugID.Text)
                {
                    Populate(d);
                }
            }
            
        }

        public void TakePatient(Patient p)
        {
            current = p;
        }
    }
}
