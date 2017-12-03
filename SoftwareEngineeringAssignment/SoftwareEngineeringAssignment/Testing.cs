using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineeringAssignment
{
    public class Testing
    {
        string m_ReasonForTest, m_Result;
        DateTime m_Date;
        int m_ID;

        public string ReasonForTest { get { return m_ReasonForTest; } set { m_ReasonForTest = value; } }
        public string Result { get { return m_Result; } set { m_Result = value; } }
        public DateTime Date { get { return m_Date; } set { m_Date = value; } }
        public int ID { get { return m_ID; } set { m_ID = value; } }

        public override string ToString()
        {
            return m_ReasonForTest + " " + m_Result + " " + m_Date.Date;
        }
    }
}
