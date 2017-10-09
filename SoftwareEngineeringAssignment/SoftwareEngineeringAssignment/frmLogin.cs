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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Database conn = Database.getInstance();

            frmMain Main = new frmMain(new Staff(1,"Bill","Billy","Bill 1 Billy", 50));
            this.Hide();
            Main.ShowDialog();
            this.Show();
        }
    }
}
