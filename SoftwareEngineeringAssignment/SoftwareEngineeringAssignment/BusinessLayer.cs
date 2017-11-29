using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Diagnostics;
using System.IO;

namespace SoftwareEngineeringAssignment
{
    public class BusinessLayer
    {
        static private BusinessLayer m_Instance = null;
        private StringBuilder m_SB = new StringBuilder();
        Aes m_AES = new AesManaged();

        private BusinessLayer()
        {
            //Sets the key and IV for encryption
            m_AES.Key = new byte[32] { 2, 254, 44, 83, 232, 130, 185, 243, 187, 155, 219, 136, 198, 231, 16, 214, 20, 237, 205, 166, 157, 82, 255, 242, 140, 191, 104, 55, 188, 69, 247, 114 };
            m_AES.IV = new byte[16] { 81, 117, 207, 183, 191, 235, 72, 140, 140, 2, 226, 123, 239, 207, 58, 113 };
            m_AES.Padding = PaddingMode.PKCS7;
        }

        /// <summary>
        /// Gets the intance of the singleton
        /// </summary>
        /// <returns></returns>
        static public BusinessLayer Instance()
        {
            if (null == m_Instance)
            {
                m_Instance = new BusinessLayer();
            }
            return m_Instance;
        }

        /// <summary>
        /// Gets the infomation from the Patient table
        /// </summary>
        /// <returns></returns>
        public List<Patient> GetPatients()
        {
            List<Patient> m_patients = new List<Patient>();

            DbConection m_con = DbFactory.instance();
            if (m_con.OpenConnection())
            {
                DbDataReader m_dr = m_con.Select("SELECT * FROM patient;");

                //Read the data and store them in the list
                while (m_dr.Read())
                {
                    Patient m_patient = new Patient();
                    m_patient.PatientID = m_dr.GetInt32(0);
                    m_patient.AddressID = m_dr.GetInt32(1);
                    m_patient.FirstName = DecryptBytes(m_dr.GetString(2));
                    m_patient.LastName = DecryptBytes(m_dr.GetString(3));
                    m_patient.DoB = Convert.ToDateTime(DecryptBytes(m_dr.GetString(4)));
                    m_patient.Religeon = DecryptBytes(m_dr.GetString(5));
                    m_patient.Email = DecryptBytes(m_dr.GetString(6));
                    m_patient.Allergies = DecryptBytes(m_dr.GetString(7));
                    m_patient.NextOfKin = DecryptBytes(m_dr.GetString(8));
                    m_patient.NoKTelephone = DecryptBytes(m_dr.GetString(9));
                    m_patients.Add(m_patient);
                }

                //close Data Reader
                m_dr.Close();
                m_con.CloseConnection();
            }

            return m_patients;
        }

        

        /// <summary>
        /// retrieves information from the timetable table
        /// </summary>
        /// <param name="i">Staff ID</param>
        /// <returns></returns>
        public List<Shift> GetTimeTable(int i)
        {
            List<Shift> m_shifts = new List<Shift>();

            DbConection m_con = DbFactory.instance();
            if (m_con.OpenConnection())
            {
                DbDataReader m_dr = m_con.Select("SELECT * FROM timetable WHERE StaffID='" + i + "';");

                //Reads the data and store them in the list
                while (m_dr.Read())
                {
                    Shift m_shift = new Shift();
                    m_shift.StaffID = m_dr.GetInt32(0);
                    m_shift.ShiftID = m_dr.GetInt32(1);
                    m_shifts.Add(m_shift);
                }

                //close Data Reader
                m_dr.Close();
                m_con.CloseConnection();
            }

            return m_shifts;
        }

        internal string UpdateAppointment(string v)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// retrieves information from the m_shift table
        /// </summary>
        /// <returns></returns>
        public List<TimeTable> GetShift()
        {
            List<TimeTable> m_shifts = new List<TimeTable>();

            DbConection m_con = DbFactory.instance();
            if (m_con.OpenConnection())
            {
                DbDataReader m_dr = m_con.Select("SELECT * FROM shift;");

                //Reads the data and store them in the list
                while (m_dr.Read())
                {
                    TimeTable m_shift = new TimeTable();
                    m_shift.ShiftID = m_dr.GetInt32(0);
                    m_shift.StartTime = Convert.ToDateTime(DecryptBytes(m_dr.GetString(1)));
                    m_shift.EndTime = Convert.ToDateTime(DecryptBytes(m_dr.GetString(2)));
                    m_shifts.Add(m_shift);
                }

                //close Data Reader
                m_dr.Close();
                m_con.CloseConnection();
            }

            return m_shifts;
        }

        /// <summary>
        /// retrieves information from the m_shift table where shiftID
        /// </summary>
        /// <param name="i">ShiftID</param>
        /// <returns></returns>
        public TimeTable GetShift(int i)
        {
            TimeTable m_shift = new TimeTable();
            DbConection m_con = DbFactory.instance();
            if (m_con.OpenConnection())
            {
                DbDataReader m_dr = m_con.Select("SELECT * FROM shift WHERE ShiftID=" + i + ";");

                //Reads the data and store them in the list
                while (m_dr.Read())
                {

                    m_shift.ShiftID = m_dr.GetInt32(0);
                    m_shift.StartTime = Convert.ToDateTime(DecryptBytes(m_dr.GetString(1)));
                    m_shift.EndTime = Convert.ToDateTime(DecryptBytes(m_dr.GetString(2)));
                }

                //close Data Reader
                m_dr.Close();
                m_con.CloseConnection();
            }

            return m_shift;
        }



        /// <summary>
        /// Gets the staff
        /// </summary>
        /// <returns></returns>
        public List<Staff> GetStaff()
        {
            List<Staff> m_staffs = new List<Staff>();

            DbConection m_con = DbFactory.instance();
            if (m_con.OpenConnection())
            {
                DbDataReader m_dr = m_con.Select("SELECT StaffID, FirstName, LastName, UserName, Password, authLevel, DoB FROM staff;");

                //Read the data and store them in the list
                while (m_dr.Read())
                {
                    Staff m_staff = new Staff();
                    m_staff.StaffID = m_dr.GetInt32(0);
                    m_staff.FName = DecryptBytes(m_dr.GetString(1));
                    m_staff.LName = DecryptBytes(m_dr.GetString(2));
                    m_staff.UserName = DecryptBytes(m_dr.GetString(3));
                    m_staff.Password = DecryptBytes(m_dr.GetString(4));
                    m_staff.AuthLevel = m_dr.GetInt32(5);
                    m_staff.DoB = Convert.ToDateTime(DecryptBytes(m_dr.GetString(6)));
                    m_staffs.Add(m_staff);
                }

                //close Data Reader
                m_dr.Close();
                m_con.CloseConnection();
            }

            return m_staffs;
        }


        /// <summary>
        /// Gets the appointments
        /// </summary>
        /// <returns></returns>
        public List<Appointment> GetAppointments()
        {
            List<Appointment> m_appointments = new List<Appointment>();

            DbConection m_con = DbFactory.instance();
            if (m_con.OpenConnection())
            {
                DbDataReader m_dr = m_con.Select("SELECT * FROM appointment;");

                //Read the data and store them in the list
                while (m_dr.Read())
                {
                    Appointment m_appointment = new Appointment();
                    m_appointment.AppointmentID = m_dr.GetInt32(0);
                    m_appointment.PatientID = m_dr.GetInt32(1);
                    m_appointment.StaffID = m_dr.GetInt32(2);
                    m_appointment.AppointmentTime = Convert.ToDateTime(DecryptBytes(m_dr.GetString(3)));
                    m_appointment.EndTime = Convert.ToDateTime(DecryptBytes(m_dr.GetString(4)));
                    m_appointment.Description = DecryptBytes(m_dr.GetString(5));
                    m_appointments.Add(m_appointment);
                }

                //close Data Reader
                m_dr.Close();
                m_con.CloseConnection();
            }

            return m_appointments;
        }


        /// <summary>
        /// Gets the perscriptions
        /// </summary>
        /// <returns></returns>
        public List<Perscription> GetPerscriptions()
        {
            List<Perscription> m_perscriptions = new List<Perscription>();

            DbConection m_con = DbFactory.instance();
            if (m_con.OpenConnection())
            {
                DbDataReader m_dr = m_con.Select("SELECT * FROM perscription;");

                //Read the data and store them in the list
                while (m_dr.Read())
                {
                    Perscription m_perscription = new Perscription();
                    m_perscription.PerscriptionID = m_dr.GetInt32(0);
                    m_perscription.PatientID = m_dr.GetInt32(1);
                    m_perscription.DrugID = m_dr.GetInt32(2);
                    m_perscription.StartDate = Convert.ToDateTime(DecryptBytes(m_dr.GetString(3)));
                    m_perscription.EndDate = Convert.ToDateTime(DecryptBytes(m_dr.GetString(4)));
                    m_perscription.description = m_dr.GetString(5);
                    m_perscriptions.Add(m_perscription);
                }

                //close Data Reader
                m_dr.Close();
                m_con.CloseConnection();
            }

            return m_perscriptions;
        }

        public List<Perscription> GetPerscriptions(int PID)
        {
            List<Perscription> m_perscriptions = new List<Perscription>();

            DbConection m_con = DbFactory.instance();
            if (m_con.OpenConnection())
            {
                DbDataReader m_dr = m_con.Select("SELECT * FROM perscription WHERE PatientID="+PID+";");

                //Read the data and store them in the list
                while (m_dr.Read())
                {
                    Perscription m_perscription = new Perscription();
                    m_perscription.PerscriptionID = m_dr.GetInt32(0);
                    m_perscription.PatientID = m_dr.GetInt32(1);
                    m_perscription.DrugID = m_dr.GetInt32(2);
                    m_perscription.description = m_dr.GetString(5);
                    m_perscriptions.Add(m_perscription);
                }

                //close Data Reader
                m_dr.Close();
                m_con.CloseConnection();
            }

            return m_perscriptions;
        }

        /// <summary>
        /// Gets the drugs from 
        /// </summary>
        /// <returns></returns>
        public List<Drug> GetDrugs()
        {
            List<Drug> m_drugs = new List<Drug>();

            DbConection m_con = DbFactory.instance();
            if (m_con.OpenConnection())
            {
                DbDataReader m_dr = m_con.Select("SELECT * FROM drug;");

                //Read the data and store them in the list
                while (m_dr.Read())
                {
                    Drug m_drug = new Drug();
                    m_drug.DrugID = m_dr.GetInt32(0);
                    m_drug.DrugName = m_dr.GetString(1);
                    m_drug.Description = m_dr.GetString(2);
                    m_drugs.Add(m_drug);
                }

                //close Data Reader
                m_dr.Close();
                m_con.CloseConnection();
            }

            return m_drugs;
        }



        /// <summary>
        /// Adds a m_staff member and returns true if it added the member
        /// </summary>
        /// <param name="FirstName"></param>
        /// <param name="LastName"></param>
        /// <param name="UserName"></param>
        /// <param name="Password"></param>
        /// <param name="AuthLevel"></param>
        /// <returns></returns>
        public bool AddStaff(string FirstName, string LastName, string UserName, string Password, int AuthLevel, int AddressID, DateTime DoB)
        {
            DbConection m_con = DbFactory.instance();
            if (m_con.OpenConnection())
            {
                string insertString = "INSERT INTO staff (StaffID, AddressID, FirstName, LastName, UserName, Password, authLevel,DoB) VALUES (NULL, '" + AddressID + "' ,'" + EncryptString(FirstName) + "', '" + EncryptString(LastName) + "', '" + EncryptString(UserName) + "', '" + EncryptString(Password) + "', '" + AuthLevel + "', '" + EncryptString(DoB.ToString()) + "');";
                if (m_con.Insert(insertString) != 0)
                {
                    m_con.CloseConnection();

                    return true;
                }


            }

            return false;
        }

        /// <summary>
        /// Creates a Perscription
        /// </summary>
        /// <param name="PatientID"></param>
        /// <param name="DrugID"></param>
        /// <param name="StartDate"></param>
        /// <param name="EndDate"></param>
        /// <param name="Description"></param>
        /// <returns></returns>
        public bool AddPerscription(int PatientID, int DrugID, DateTime StartDate, DateTime EndDate, string Description)
        {
            DbConection m_con = DbFactory.instance();
            if (m_con.OpenConnection())
            {
                string insertString = "INSERT INTO perscription (PerscriptionID, PatientID, DrugID, StartDate, EndDate, Description) VALUES (NULL,'" + PatientID + "', '" + DrugID + "', '" + EncryptString(StartDate.ToString()) + "', '" + EncryptString(EndDate.ToString()) + "', '" + EncryptString(Description) + "');";
                if (m_con.Insert(insertString) != 0)
                {
                    m_con.CloseConnection();

                    return true;
                }


            }

            return false;
        }

        public bool AddTestHistory(int patientID, string test)
        {
            DbConection m_con = DbFactory.instance();
            if (m_con.OpenConnection())
            {
                //string insertString = "INSERT INTO perscription (PerscriptionID, PatientID, DrugID, StartDate, EndDate, Description) VALUES (NULL,'" + PatientID + "', '" + DrugID + "', '" + EncryptString(StartDate.ToString()) + "', '" + EncryptString(EndDate.ToString()) + "', '" + EncryptString(Description) + "');";
                //if (m_con.Insert(insertString) != 0)
                {
                    m_con.CloseConnection();

                    return true;
                }


            }

            return false;
        }

        /// <summary>
        /// Adds a patient and returns true if added
        /// </summary>
        /// <param name="FirstName"></param>
        /// <param name="LastName"></param>
        /// <param name="DoB"></param>
        /// <param name="Religion"></param>
        /// <param name="Allergies"></param>
        /// <param name="NextOfKin"></param>
        /// <param name="NoKtele"></param>
        /// <param name="Email"></param>
        /// <returns></returns>
        public bool AddPatient(string FirstName, string LastName, DateTime DoB, string Religion, string Allergies, string NextOfKin, string NoKtele, string Email)
        {
            DbConection m_con = DbFactory.instance();
            if (m_con.OpenConnection())
            {
                string insertString = "INSERT INTO patient (PatientID, AddressID, FirstName, LastName, DateOfBirth, Religeon, Allergies, NextOfKin, NoKTelephone, Email) VALUES (NULL, '1', '" + EncryptString(FirstName) + "', '" + EncryptString(LastName) + "', '" + EncryptString(DoB.ToString()) + "', '" + EncryptString(Religion) + "', '" + EncryptString(Allergies) + "', '" + EncryptString(NextOfKin) + "', '" + EncryptString(NoKtele) + "', '" + EncryptString(Email) + "');";
                if (m_con.Insert(insertString) != 0)
                {
                    m_con.CloseConnection();

                    return true;
                }


            }

            return false;
        }

        /// <summary>
        /// Adds a Timetable entry
        /// </summary>
        /// <param name="staffId"></param>
        /// <param name="shiftId"></param>
        /// <returns></returns>
        public bool AddTimetable(int staffId, int shiftId)
        {
            DbConection m_con = DbFactory.instance();
            if (m_con.OpenConnection())
            {
                string insertString = "INSERT INTO timetable (ShiftID, StaffID) VALUES ('" + shiftId + "', '" + staffId + "');";
                if (m_con.Insert(insertString) != 0)
                {
                    m_con.CloseConnection();

                    return true;
                }


            }

            return false;
        }

        /// <summary>
        /// Adds an appointment
        /// </summary>
        /// <param name="AppointmentID"></param>
        /// <param name="StaffID"></param>
        /// <param name="StartTime"></param>
        /// <param name="EndTime"></param>
        /// <param name="Description"></param>
        /// <returns></returns>
        public bool AddAppointment(int AppointmentID, int StaffID, DateTime StartTime, DateTime EndTime, string Description)
        {
            DbConection m_con = DbFactory.instance();
            if (m_con.OpenConnection())
            {
                string insertString = "INSERT INTO appointment (AppointmentID, PatientID, StaffID, StartTime, EndTime, Description) VALUES (NULL, '" + AppointmentID.ToString() + "', '" + StaffID.ToString() + "', '" + EncryptString(StartTime.ToString()) + "', '" + EncryptString(EndTime.ToString()) + "', '" + EncryptString(Description) + "');";
                if (m_con.Insert(insertString) != 0)
                {
                    m_con.CloseConnection();

                    return true;
                }


            }

            return false;
        }

        public bool UpdateAppointment( DateTime StartTime, DateTime EndTime, string Description, int appointmentID)
        {
            DbConection m_con = DbFactory.instance();
            if (m_con.OpenConnection())
            {
                string insertString = "UPDATE appointment (StartTime, EndTime, Description) VALUES ('" + EncryptString(StartTime.ToString()) + "', '" + EncryptString(EndTime.ToString()) + "', '" + EncryptString(Description) + "' WHERE " + appointmentID + ");";
                if (m_con.Insert(insertString) != 0)
                {
                    m_con.CloseConnection();

                    return true;
                }
            }
            return false;
        }
                /// <summary>
                /// Creates a shift
                /// </summary>
                /// <param name="StartTime"></param>
                /// <param name="EndTime"></param>
                /// <returns></returns>
                public bool AddShift(DateTime StartTime, DateTime EndTime)
        {
            DbConection m_con = DbFactory.instance();
            if (m_con.OpenConnection())
            {
                string insertString = "INSERT INTO shift (ShiftID, StartTime, EndTime) VALUES (NULL, '" + EncryptString(StartTime.ToString()) + "', '" + EncryptString(EndTime.ToString()) + "');";
                if (m_con.Insert(insertString) != 0)
                {
                    m_con.CloseConnection();

                    return true;
                }


            }

            return false;
        }

        /// <summary>
        /// Updates the Staff memeber
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="DoB"></param>
        /// <param name="userName"></param>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int UpdateStafffrm(string firstName, string lastName, DateTime DoB, string userName, int ID)
        {
            int i = 0;
            DbConection m_con = DbFactory.instance();
            if (m_con.OpenConnection())
            {
                string SqlCommand = "update m_staff set FirstName='" + EncryptString(firstName) + "' ,LastName='" + EncryptString(lastName) + "',DoB='" + EncryptString(DoB.ToString()) + "',UserName='" + EncryptString(userName) + "' WHERE StaffID=" + ID + ";";

                i = m_con.Update(SqlCommand);

                m_con.CloseConnection();
            }
            return i;
        }

        /// <summary>
        /// Updates the Patient
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="DateOfBirth"></param>
        /// <param name="Religion"></param>
        /// <param name="NextOfKin"></param>
        /// <param name="NoKTelephone"></param>
        /// <param name="PatientID"></param>
        /// <returns></returns>
        public int UpdatePatientfrm(string firstName, string lastName, DateTime DateOfBirth, string Religion, string NextOfKin, string NoKTelephone, int PatientID)
        {
            int i = 0;
            DbConection m_con = DbFactory.instance();
            if (m_con.OpenConnection())
            {
                string SqlCommand = "update patient set FirstName='" + EncryptString(firstName) + "' ,LastName='" + EncryptString(lastName) + "',DateOfBirth='" + EncryptString(DateOfBirth.ToString()) + "',Religeon='" + EncryptString(Religion) + "',NextOfKin='" + EncryptString(NextOfKin) + "',NoKTelephone='" + EncryptString(NoKTelephone) + "' WHERE PatientID=" + PatientID + ";";

                i = m_con.Update(SqlCommand);

                m_con.CloseConnection();
            }
            return i;
        }

        //https://stackoverflow.com/questions/604210/padding-is-invalid-and-cannot-be-removed-using-aesmanaged

        /// <summary>
        /// encrypts the given string using the SymmetricAlgorithm given
        /// </summary>
        /// <param name="symAlg"></param>
        /// <param name="inString"></param>
        /// <returns></returns>
        public string EncryptString(string inString)
        {
            m_SB.Clear();
            byte[] rawPlaintext = Encoding.Unicode.GetBytes(inString);
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, m_AES.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(rawPlaintext, 0, rawPlaintext.Length);
                    cs.FlushFinalBlock();
                }

                foreach (byte i in ms.ToArray())
                {
                    m_SB.Append(i + ",");
                }
                m_SB.Remove(m_SB.Length - 1, 1);
                return m_SB.ToString();
            }
        }


        /// <summary>
        /// Decrypts the given string using the SymmetricAlgorithm given
        /// </summary>
        /// <param name="symAlg"></param>
        /// <param name="inString"></param>
        /// <returns></returns>
        public string DecryptBytes(string inString)
        {
            List<byte> inBytes = new List<byte>();
            List<string> inListString = new List<string>();
            inListString = inString.Split(',').ToList();
            for (int i = 0; i < inListString.Count; i++)
            {
                inBytes.Add(Convert.ToByte(inListString[i]));
            }
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, m_AES.CreateDecryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(inBytes.ToArray(), 0, inBytes.Count);
                }
                return UnicodeEncoding.Unicode.GetString(ms.ToArray());
            }
        }


    }
}
