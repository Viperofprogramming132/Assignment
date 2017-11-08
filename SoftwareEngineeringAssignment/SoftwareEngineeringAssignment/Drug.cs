using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineeringAssignment
{
    public class Drug
    {
        int m_DrugID;
        string m_DrugName, m_Description;

        public int DrugID { get { return m_DrugID; } set { m_DrugID = value; } }
        public string DrugName { get { return m_DrugName; } set { m_DrugName = value; } }
        public string Description { get { return m_Description; } set { m_Description = value; } }
    }
}
