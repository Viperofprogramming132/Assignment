using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineeringAssignment
{
    public class Shift
    {
        int m_ShiftID;
        DateTime m_StartTime, m_EndTime;

        public int ShiftID { get { return m_ShiftID; } set { m_ShiftID = value; } }
        public DateTime StartTime { get { return m_StartTime; } set { m_StartTime = value; } }
        public DateTime EndTime { get { return m_EndTime; } set { m_EndTime = value; } }
    }
}
