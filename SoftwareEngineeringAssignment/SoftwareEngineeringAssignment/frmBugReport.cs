using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SoftwareEngineeringAssignment
{
    public partial class frmBugReport : Form
    {
        private string path = "ReportedBugs.txt";

        public frmBugReport()
        {
            InitializeComponent();
        }

        private void btnBug_Click(object sender, EventArgs e)
        {
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Bug Text File");
                }
            }

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(txtBug.Text);
            }
        }
    }
}
