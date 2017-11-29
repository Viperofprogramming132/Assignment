﻿using System;
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
        }

        public void TakePatient(Patient p)
        {
            current = p;
        }
    }
}
