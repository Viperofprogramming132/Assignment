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
    public partial class frmQueryAddress : Form
    {
        private BackgroundWorker worker = new BackgroundWorker();
        private List<Address> addressList = new List<Address>();
        private frmQueryPatient m_FQP;
        private frmAddStaff m_FAS;
        private frmAddPatient frmAddPatient;
        private int showing = 0;


        public frmQueryAddress()
        {
            InitializeComponent();
            setupForm();
        }

        public frmQueryAddress(frmQueryPatient f)
        {
            InitializeComponent();
            setupForm();
            m_FQP = f;
        }

        public frmQueryAddress(frmAddStaff f)
        {
            InitializeComponent();
            setupForm();
            m_FAS = f;
        }

        public frmQueryAddress(frmAddPatient frmAddPatient)
        {
            InitializeComponent();
            setupForm();
            this.frmAddPatient = frmAddPatient;
        }

        /// <summary>
        /// Sets up the form with worker and fills combo box
        /// </summary>
        private void setupForm()
        {
            
            this.WindowState = FormWindowState.Maximized;


            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
            worker.WorkerSupportsCancellation = true;
        }


        /// <summary>
        /// Gets the staff members
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            addressList = null;

            BusinessLayer ml = BusinessLayer.Instance();

            if (txtID.Text != "")
            {
                addressList = ml.GetAddress(int.Parse(txtID.Text));
            }
            if(txtPostCode.Text != "")
            {
                addressList = ml.GetAddress(txtPostCode.Text);
            }

            if (worker.CancellationPending)
            {
                e.Cancel = true;
                return;
            }
        }

        /// <summary>
        /// On worker complete will display the users
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                
                populate();
            }
            catch
            {
                MessageBox.Show("Could not find any matching Address'");
            }
        }

        /// <summary>
        /// Sets the form full screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmQueryStaff_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }

        /// <summary>
        /// populates infomation with the given staff
        /// </summary>
        /// <param name="s"></param>
        private void populate()
        {
            buttonUpdate();

            txtAddress.Text = addressList[showing].AddressLoc;
            txtCity.Text = addressList[showing].City;
            txtID.Text = addressList[showing].AddressID.ToString();
            txtPOBox.Text = addressList[showing].POBox;
            txtPostCode.Text = addressList[showing].PostCode;
        }

        /// <summary>
        /// Enables and disables buttons based off how many are in the list
        /// </summary>
        private void buttonUpdate()
        {
            if (showing == 0)
            {
                btnBack.Enabled = false;
            }
            else
            {
                btnBack.Enabled = true;
            }
            if (showing == addressList.Count - 1)
            {
                btnForward.Enabled = false;
            }
            else
            {
                btnForward.Enabled = true;
            }

        }


        private void btnForward_Click(object sender, EventArgs e)
        {
            showing++;
            buttonUpdate();
            populate();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            showing--;
            buttonUpdate();
            populate();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!worker.IsBusy)
            {
                worker.RunWorkerAsync();
            }
        }

        private void frmQueryAddress_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(m_FQP != null)
            {
                m_FQP.TakeAddress(addressList[showing]);
            }
            if (m_FAS != null)
            {
                m_FAS.TakeAddress(addressList[showing]);
            }
            if (frmAddPatient != null)
            {
                frmAddPatient.TakeAddress(addressList[showing]);
            }
        }
    }
}
