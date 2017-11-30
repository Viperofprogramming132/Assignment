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

        public string ReasonForTest { get { return m_ReasonForTest; } set { m_ReasonForTest = value; } }
        public string Result { get { return m_Result; } set { m_Result = value; } }

        public override string ToString()
        {
            return ReasonForTest + " " + Result;
        }
    }
}
