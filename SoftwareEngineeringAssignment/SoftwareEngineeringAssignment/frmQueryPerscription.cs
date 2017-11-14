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
    public partial class frmQueryPerscription : Form
    {
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
    }
}
