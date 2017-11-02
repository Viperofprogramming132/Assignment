using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineeringAssignment
{
    public class Patient
    {
        string m_Address, m_PostCode, m_City, m_POBox, m_PatientID, m_FirstName, m_LastName, m_Religeon;
        List<Perscription> m_perscriptions = new List<Perscription>();
        List<Appointment> m_appoinments = new List<Appointment>();
        DateTime m_DoB;

        public string FirstName { get { return m_FirstName; } set { m_FirstName = value; } }
        public string LastName { get { return m_LastName; } set { m_LastName = value; } }
        public string PatientID { get { return m_PatientID; } set { m_PatientID = value; } }
        public string Religeon { get { return m_Religeon; } set { m_Religeon = value; } }

        public DateTime DoB { get { return m_DoB; } set { m_DoB = value; } }

        public List<Perscription> perscriptions { get { return m_perscriptions; } }
        public List<Appointment> appoinments { get { return m_appoinments; } }

        public Patient()
        {
        }
    }
}
