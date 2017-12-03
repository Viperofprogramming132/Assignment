using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineeringAssignment
{
    public class Address
    {
        int m_AddressID;
        string m_AddressLoc, m_PostCode, m_City, m_POBox;

        public int AddressID { get { return m_AddressID; } set { m_AddressID = value; } }
        public string AddressLoc { get { return m_AddressLoc; } set { m_AddressLoc = value; } }
        public string PostCode { get { return m_PostCode; } set { m_PostCode = value; } }
        public string City { get { return m_City; } set { m_City = value; } }
        public string POBox { get { return m_POBox; } set { m_POBox = value; } }

        public override string ToString()
        {
            return m_AddressLoc + ", " + m_City + ", " + m_PostCode;
        }
    }
}
