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
    public partial class frmViewTimetable : Form
    {
        Staff m_currentMember;
        BackgroundWorker worker = new BackgroundWorker();
        List<TimeTable> shift = new List<TimeTable>();
        List<Shift> timetable = new List<Shift>();

        public frmViewTimetable(Staff s)
        {
            m_currentMember = s;
            InitializeComponent();


            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
            worker.WorkerSupportsCancellation = true;

            worker.RunWorkerAsync();

            /*lsvTimeTable.View = View.Details;
            lsvTimeTable.Columns.Add("Monday", -2, HorizontalAlignment.Left);
            lsvTimeTable.Columns.Add("Tuesday", -2, HorizontalAlignment.Left);
            lsvTimeTable.Columns.Add("Wednesday", -2, HorizontalAlignment.Left);
            lsvTimeTable.Columns.Add("Thursday", -2, HorizontalAlignment.Left);
            lsvTimeTable.Columns.Add("Friday", -2, HorizontalAlignment.Left);
            lsvTimeTable.Columns.Add("Saturday", -2, HorizontalAlignment.Left);
            lsvTimeTable.Columns.Add("Sunday", -2, HorizontalAlignment.Left);*/
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach(TimeTable s in shift)
            {
                lsvTimeTable.Items.Add(s.StartTime + " - " + s.EndTime);
            }
            
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            BusinessLayer ml = BusinessLayer.Instance();

            timetable = ml.GetTimeTable(m_currentMember.StaffID);

            foreach(Shift s in timetable)
            {
                shift.Add(ml.GetShift(s.ShiftID));
            }
        }

        private void ResizeListViewColumns(ListView lv)
        {
            foreach (ColumnHeader column in lv.Columns)
            {
                column.Width = -2;
            }
        }
    }
}
