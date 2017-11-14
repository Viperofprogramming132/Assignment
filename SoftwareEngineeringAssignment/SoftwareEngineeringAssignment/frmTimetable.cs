using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareEngineeringAssignment
{
    public partial class frmTimetable : Form
    {
        BackgroundWorker worker = new BackgroundWorker();
        Staff current = new Staff();
        DateTime StartTime, EndTime;


        public frmTimetable()
        {
            InitializeComponent();
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
            worker.WorkerSupportsCancellation = true;
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Added shift to the staff member "  +  current.ToString());
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            BusinessLayer ml = BusinessLayer.Instance();
            List<Shift> sList = new List<Shift>();
            if(ml.AddShift(current.StaffID, StartTime, EndTime))
            {
                sList = ml.GetShift();
                ml.AddTimetable(current.StaffID, sList[sList.Count - 1].ShiftID);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmQueryStaff queryStaff = new frmQueryStaff(this);

            this.Hide();
            queryStaff.ShowDialog();
            this.Show();
        }

        public void takeStaff(Staff s)
        {
            current = s;
        }

        private void frmTimetable_VisibleChanged(object sender, EventArgs e)
        {
            lblCurrentStaffMember.Text = "Current Member: " + current.ToString();
            fillTime();
        }

        /// <summary>
        /// Fills the times into timeList
        /// </summary>
        private void fillTime()
        {
            int inc = 60;
            List<DateTime> timeList = new List<DateTime>();
            cmbStartTime.Items.Clear();
            cmbEndTime.Items.Clear();
            timeList.Clear();

            DateTime startTime = mclTimeTable.SelectionStart.AddHours(9);
            DateTime endTime = mclTimeTable.SelectionStart.AddHours(20);

            while (startTime < endTime)
            {
                timeList.Add(startTime);
                startTime = startTime.AddMinutes(inc);
            }

            foreach (DateTime appTime in timeList)
            {
                cmbStartTime.Items.Add(appTime.TimeOfDay);
                cmbEndTime.Items.Add(appTime.TimeOfDay);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            StartTime = getTime(cmbStartTime.Text);
            EndTime = getTime(cmbEndTime.Text);
            worker.RunWorkerAsync();
        }

        private DateTime getTime(string timeSlot)
        {
            if (timeSlot != "")
            {
                DateTime date = mclTimeTable.SelectionStart;
                DateTime time = DateTime.ParseExact(timeSlot, "HH:mm:ss", CultureInfo.InvariantCulture);

                DateTime dateTime = date.AddHours(time.Hour).AddMinutes(time.Minute);
                return dateTime;
            }
            return DateTime.Now;
        }
    }
}
