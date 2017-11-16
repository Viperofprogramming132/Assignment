using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineeringAssignment
{
    public class Shift
    {
        private int m_StaffID, m_ShiftID;

        public int StaffID { get { return m_StaffID; } set { m_StaffID = value; } }
        public int ShiftID { get { return m_ShiftID; } set { m_ShiftID = value; } }
    }
}
