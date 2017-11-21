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
        List<TimeTable> Rota = new List<TimeTable>();
        List<Shift> timetable = new List<Shift>();

        public frmViewTimetable(Staff s)
        {
            m_currentMember = s;
            InitializeComponent();

            monthCalendar1.SelectionStart = StartOfWeek(monthCalendar1.SelectionStart);
            monthCalendar1.SelectionEnd = monthCalendar1.SelectionStart.AddDays(6);

            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
            worker.WorkerSupportsCancellation = true;

            worker.RunWorkerAsync();

            lsvTimeTable.View = View.Details;
            lsvTimeTable.Columns.Add("Monday", -2, HorizontalAlignment.Left);
            lsvTimeTable.Columns.Add("Tuesday", -2, HorizontalAlignment.Left);
            lsvTimeTable.Columns.Add("Wednesday", -2, HorizontalAlignment.Left);
            lsvTimeTable.Columns.Add("Thursday", -2, HorizontalAlignment.Left);
            lsvTimeTable.Columns.Add("Friday", -2, HorizontalAlignment.Left);
            lsvTimeTable.Columns.Add("Saturday", -2, HorizontalAlignment.Left);
            lsvTimeTable.Columns.Add("Sunday", -2, HorizontalAlignment.Left);
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            List<string> items = new List<string>();
            for(int i = 0; i<7;i++)
            {
                items.Add("-");
            }
            //Warning long if statment
            foreach(TimeTable s in Rota)
            {
                //lsvTimeTable.Items.Add(s.StartTime + " --- " + s.EndTime);
                if (s.StartTime.DayOfWeek == DayOfWeek.Monday)
                {
                    items.Insert(0, s.StartTime.TimeOfDay + " --- " + s.EndTime.TimeOfDay);
                }
                else
                {
                    if (items[0] == "-" || items[0] == "DO")
                    {
                        items[0] = "DO";
                    }
                }
                if (s.StartTime.DayOfWeek == DayOfWeek.Tuesday)
                {
                    items.Insert(1, s.StartTime.TimeOfDay + " --- " + s.EndTime.TimeOfDay);
                }
                else
                {
                    if (items[1] == "DO" || items[1] == "-")
                    {
                        items[1] = "DO";
                    }
                }
                if (s.StartTime.DayOfWeek == DayOfWeek.Wednesday)
                {
                    items.Insert(2, s.StartTime.TimeOfDay + " --- " + s.EndTime.TimeOfDay);
                }
                else
                {
                    if (items[2] == "DO" || items[2] == "-")
                    {
                        items[2] = "DO";
                    }
                }
                if (s.StartTime.DayOfWeek == DayOfWeek.Thursday)
                {
                    items.Insert(3, s.StartTime.TimeOfDay + " --- " + s.EndTime.TimeOfDay);
                }
                else
                {
                    if (items[3] ==  "-" || items[3] == "DO")
                    {
                        items[3] = "DO";
                    }
                }
                if (s.StartTime.DayOfWeek == DayOfWeek.Friday)
                {
                    items.Insert(4, s.StartTime.TimeOfDay + " --- " + s.EndTime.TimeOfDay);
                }
                else
                {
                    if (items[4] == "-" || items[4] == "DO")
                    {
                        items[4] = "DO";
                    }
                }
                if (s.StartTime.DayOfWeek == DayOfWeek.Saturday)
                {
                    items.Insert(5, s.StartTime.TimeOfDay + " --- " + s.EndTime.TimeOfDay);
                }
                else
                {
                    if (items[5] == "-" || items[5] == "DO")
                    {
                        items[5] = "DO";
                    }
                }
                if (s.StartTime.DayOfWeek == DayOfWeek.Sunday)
                {
                    items.Insert(6, s.StartTime.TimeOfDay + " --- " + s.EndTime.TimeOfDay);
                }
                else
                {
                    if (items[6] == "-" || items[6] == "DO")
                    {
                        items[6] = "DO";
                    }
                }
            }
            ListViewItem viewItem = lsvTimeTable.Items.Add(items[0]);
            for (int i = 1; i < items.Count; i++)
            {
                viewItem.SubItems.Add(items[i]);
            }
            ResizeListViewColumns(lsvTimeTable);
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            BusinessLayer ml = BusinessLayer.Instance();

            timetable.Clear();
            shift.Clear();
            Rota.Clear();

            timetable = ml.GetTimeTable(m_currentMember.StaffID);

            foreach(Shift s in timetable)
            {
                shift.Add(ml.GetShift(s.ShiftID));
            }
            foreach(TimeTable t in shift)
            {
                getWeekRota(t);
            }
        }

        private void ResizeListViewColumns(ListView lv)
        {
            foreach (ColumnHeader column in lv.Columns)
            {
                column.Width = -2;
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {

            monthCalendar1.SelectionStart = StartOfWeek(monthCalendar1.SelectionStart);
            monthCalendar1.SelectionEnd = monthCalendar1.SelectionStart.AddDays(6);
        }

        private void getWeekRota(TimeTable t)
        {
            if (t.StartTime.DayOfYear >= monthCalendar1.SelectionStart.DayOfYear && t.EndTime.DayOfYear <= monthCalendar1.SelectionEnd.DayOfYear)
            {
                Rota.Add(t);
            }
        }

        public DateTime StartOfWeek(DateTime dt)
        {
            System.Globalization.CultureInfo ci = System.Threading.Thread.CurrentThread.CurrentCulture;
            DayOfWeek fdow = ci.DateTimeFormat.FirstDayOfWeek;
            return dt.AddDays(-(dt.DayOfWeek - fdow));
        }
    }
}
