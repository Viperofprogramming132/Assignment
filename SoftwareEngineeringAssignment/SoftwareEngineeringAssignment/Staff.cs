using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineeringAssignment
{
    public class Staff
    {
        int m_AuthLevel, m_StaffID;
        string m_FName, m_LName, m_UserName, m_Password;

        public string FName { get { return m_FName; } set { m_FName = value; } }
        public string LName { get { return m_LName; } set { m_LName = value; } }
        public int StaffID { get { return m_StaffID; } set { m_StaffID = value; } }
        public string UserName { get { return m_UserName; } set { m_UserName = value; } }
        public int AuthLevel { get { return m_AuthLevel; } set { m_AuthLevel = value; } }
        public string Password { get { return m_Password; } set { m_Password = value; } }

        public override string ToString()
        {
            return m_FName + " " + m_LName;
        }
    }
}
