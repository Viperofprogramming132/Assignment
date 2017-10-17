using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineeringAssignment
{
    public class Appointment
    {
        bool m_attended;
        bool m_canceled;
        DateTime m_appointmentTime;
        string description;
        Patient p;

        public bool attended { get { return m_attended; } set { m_attended = value; } }
        public bool canceled { get { return m_canceled; } set { m_canceled = value; } }
        public DateTime appointmentTime { get { return m_appointmentTime; } }

        public Appointment(DateTime appointmentTime, string description, Patient p)
        {
            this.m_appointmentTime = appointmentTime;
            this.description = description;
            this.p = p;
        }

        
    }
}
