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

        public string FirstName { get { return m_FirstName; } }
        public string LastName { get { return m_LastName; } }
        public string PatientID { get { return m_PatientID; } }

        public DateTime DoB { get { return m_DoB; } }

        public List<Perscription> perscriptions { get { return m_perscriptions; } }
        public List<Appointment> appoinments { get { return m_appoinments; } }

        public Patient(string address, string postCode, string city, string POBox, string PatientID, string FirstName, string LastName, string Religeon, DateTime DoB)
        {
            m_Address = address;
            m_PostCode = postCode;
            m_City = city;
            this.m_POBox = POBox;
            this.m_PatientID = PatientID;
            this.m_FirstName = FirstName;
            this.m_LastName = LastName;
            this.m_Religeon = Religeon;
            this.m_DoB = DoB;
            dummyData();
        }

        public void dummyData()
        {
            Random r = new Random();
            
            for(int i = 0; i<r.Next(0,4);i++)
            {
                m_perscriptions.Add(new Perscription(DateTime.MinValue, DateTime.MaxValue, "never ending persciption", this));
            }
            int test1, test2;
            test1 = r.Next(2, 4);
            for (int i = 0; i < test1; i++)
            {
                m_appoinments.Add(new Appointment(DateTime.Now,r.Next(0,128461824).ToString(),this));
                test2 = r.Next(0, 2);
                if (test2 == 0)
                {
                    m_appoinments[i].attended = true;
                }
                if (test2 == 1)
                {
                    m_appoinments[i].attended = false;
                }

                test2 = r.Next(0, 2);
                if (test2 == 0)
                {
                    m_appoinments[i].canceled = true;
                }
                if (test2 == 1)
                {
                    m_appoinments[i].canceled = false;
                }
            }
        }
    }
}
