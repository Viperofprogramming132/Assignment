﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineeringAssignment
{
    public class Patient
    {
        int m_PatientID;
        string m_Address, m_PostCode, m_City, m_POBox, m_FirstName, m_LastName, m_Religeon;
        DateTime m_DoB;

        public string FirstName { get { return m_FirstName; } set { m_FirstName = value; } }
        public string LastName { get { return m_LastName; } set { m_LastName = value; } }
        public int PatientID { get { return m_PatientID; } set { m_PatientID = value; } }
        public string Religeon { get { return m_Religeon; } set { m_Religeon = value; } }

        public DateTime DoB { get { return m_DoB; } set { m_DoB = value; } }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
