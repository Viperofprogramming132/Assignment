using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineeringAssignment
{
    public class Perscription
    {
        string m_DrugID, m_Name;
        DateTime m_StartDate, m_EndDate;
        string m_description;
        Patient m_p;

        public string DrugID { get { return m_DrugID; } }
        public string Name { get { return m_Name; } }
        public string description { get { return m_description; } }
        public DateTime StartDate { get { return m_StartDate; } }
        public DateTime EndDate { get { return m_EndDate; } }

        public Perscription(DateTime StartDate, DateTime EndDate, string Desctiption, Patient p)
        {
            this.m_StartDate = StartDate;
            this.m_EndDate = EndDate;
            this.m_description = Desctiption;
            this.m_p = p;
        }
    }
}
