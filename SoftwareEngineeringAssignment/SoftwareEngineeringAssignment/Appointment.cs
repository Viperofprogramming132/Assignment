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
        string m_description;
        int m_appointmentID;
        int m_staffID;
        int m_patientID;
        DateTime m_endTime;

        public bool Attended { get { return m_attended; } set { m_attended = value; } }
        public bool Canceled { get { return m_canceled; } set { m_canceled = value; } }
        public DateTime AppointmentTime { get { return m_appointmentTime; } set { m_appointmentTime = value; } }
        public string Description { get { return m_description; } set { m_description = value; } }
        public int AppointmentID { get { return m_appointmentID; } set { m_appointmentID = value; } }
        public int StaffID { get { return m_staffID; } set { m_staffID = value; } }
        public int PatientID { get { return m_patientID; } set { m_patientID = value; } }
        public DateTime EndTime { get { return m_endTime; } set { m_endTime = value; } }

        
    }
}
