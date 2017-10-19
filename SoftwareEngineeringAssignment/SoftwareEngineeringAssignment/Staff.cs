using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineeringAssignment
{
    public class Staff
    {
        int m_StaffID,m_AuthLevel;
        string m_FName, m_LName, m_UserName;

        public string FName { get { return m_FName; } set { m_FName = value; } }
        public string LName { get { return m_LName; } }
        public int StaffID { get { return m_StaffID; } }
        public string UserName { get { return m_UserName; } }

        public Staff(int p_StaffID, string p_FName, string p_LName, string p_UserName, int p_AuthLevel)
        {
            m_StaffID = p_StaffID;
            m_FName = p_FName;
            m_LName = p_LName;
            m_UserName = p_UserName;
            m_AuthLevel = p_AuthLevel;
        }
    }
}
