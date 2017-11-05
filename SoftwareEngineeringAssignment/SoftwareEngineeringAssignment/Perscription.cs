using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineeringAssignment
{
    public class Perscription
    {
        string m_Name;
        int m_PatientID, m_DrugID, m_PerscriptionID;
        DateTime m_StartDate, m_EndDate;
        string m_description;
        Patient m_p;

        public int DrugID { get { return m_DrugID; } set { m_DrugID = value; } }
        public int PerscriptionID { get { return m_PerscriptionID; } set { m_PerscriptionID = value; } }
        public string Name { get { return m_Name; } set { m_Name = value; } }
        public string description { get { return m_description; } set { m_description = value; } }
        public DateTime StartDate { get { return m_StartDate; } set { m_StartDate = value; } }
        public DateTime EndDate { get { return m_EndDate; } set { m_EndDate = value; } }
        public int PatientID { get { return m_PatientID; } set { m_PatientID = value; } }
    }
}
