using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineeringAssignment
{
    public class BusinessLayer
    {
        static private BusinessLayer m_instance = null;

        private BusinessLayer() { }

        static public BusinessLayer instance()
        {
            if (null == m_instance)
            {
                m_instance = new BusinessLayer();
            }
            return m_instance;
        }

        // Could just have a set of static helper methods rather than a singleton!
        public List<Patient> getPatients()
        {
            List<Patient> patients = new List<Patient>();

            DbConection con = DbFactory.instance();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT PatientID, FirstName, LastName, DateOfBirth FROM patient;");

                //Read the data and store them in the list
                while (dr.Read())
                {
                    Patient patient = new Patient();
                    patient.PatientID = dr.GetInt32(0).ToString();
                    patient.FirstName = dr.GetString(1);
                    patient.LastName = dr.GetString(2);
                    patient.DoB = dr.GetDateTime(3);
                    patients.Add(patient);
                }

                //close Data Reader
                dr.Close();
                con.CloseConnection();
            }

            return patients;
        }
    }
}
