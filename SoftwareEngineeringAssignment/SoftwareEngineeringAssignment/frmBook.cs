﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SoftwareEngineeringAssignment
{
    public partial class frmBook : Form
    {
        public frmBook()
        {
            InitializeComponent();

            for(int i = 1; i <= 31; i++)
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

        private void mclCalander_DateSelected(object sender, DateRangeEventArgs e)
        {
            Debug.WriteLine(mclCalander.SelectionStart);

            //would database search availiblity on that date
        }
    }
}
