﻿using System;
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
        static private BusinessLayer m_instance = null;
        private StringBuilder sb = new StringBuilder();
        Aes aes = new AesManaged();
        private BusinessLayer()
        {
            //aesCSP = new AesCryptoServiceProvider();

            aes.Key = new byte[32] { 2, 254, 44, 83, 232, 130, 185, 243, 187, 155, 219, 136, 198, 231, 16, 214, 20, 237, 205, 166, 157, 82, 255, 242, 140, 191, 104, 55, 188, 69, 247, 114 };
            aes.IV = new byte[16] { 81, 117, 207, 183, 191, 235, 72, 140, 140, 2, 226, 123, 239, 207, 58, 113 };
            aes.Padding = PaddingMode.PKCS7;
        }

        static public BusinessLayer instance()
        {
            if (null == m_instance)
            {
                m_instance = new BusinessLayer();
            }
            return m_instance;
        }

        /// <summary>
        /// Gets the infomation from the Patient table
        /// </summary>
        /// <returns></returns>
        public List<Patient> getPatients()
        {
            List<Patient> patients = new List<Patient>();

            DbConection con = DbFactory.instance();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT PatientID, FirstName, LastName, DateOfBirth, Religeon FROM patient;");

                //Read the data and store them in the list
                while (dr.Read())
                {
                    Patient patient = new Patient();
                    patient.PatientID = dr.GetInt32(0);
                    patient.FirstName = DecryptBytes( dr.GetString(1));
                    patient.LastName = DecryptBytes( dr.GetString(2));
                    patient.DoB = Convert.ToDateTime(DecryptBytes( dr.GetString(3)));
                    patient.Religeon = DecryptBytes( dr.GetString(4));
                    patients.Add(patient);
                }

                //close Data Reader
                dr.Close();
                con.CloseConnection();
            }

            return patients;
        }


        /// <summary>
        /// Gets the infomation from the staff table
        /// </summary>
        /// <returns></returns>
        public List<Staff> getStaff()
        {
            List<Staff> staffs = new List<Staff>();

            DbConection con = DbFactory.instance();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT StaffID, FirstName, LastName, UserName, Password, authLevel FROM staff;");

                //Read the data and store them in the list
                while (dr.Read())
                {
                    Staff staff = new Staff();
                    staff.StaffID = dr.GetInt32(0);
                    staff.FName = DecryptBytes( dr.GetString(1));
                    staff.LName = DecryptBytes( dr.GetString(2));
                    staff.UserName = DecryptBytes( dr.GetString(3));
                    staff.Password = DecryptBytes( dr.GetString(4));
                    staff.AuthLevel = dr.GetInt32(5);
                    staffs.Add(staff);
                }

                //close Data Reader
                dr.Close();
                con.CloseConnection();
            }
            
            return staffs;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Appointment> getAppointments()
        {
            List<Appointment> appointments = new List<Appointment>();

            DbConection con = DbFactory.instance();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT * FROM appointment;");

                //Read the data and store them in the list
                while (dr.Read())
                {
                    Appointment appointment = new Appointment();
                    appointment.appointmentID = dr.GetInt32(0);
                    appointment.patientID = dr.GetInt32(1);
                    appointment.staffID = dr.GetInt32(2);
                    appointment.appointmentTime = Convert.ToDateTime(DecryptBytes( dr.GetString(3)));
                    appointment.endTime = Convert.ToDateTime(DecryptBytes( dr.GetString(4)));
                    appointment.description = dr.GetString(5);
                    appointments.Add(appointment);
                }

                //close Data Reader
                dr.Close();
                con.CloseConnection();
            }

            return appointments;
        }

        public List<Perscription> getPerscriptions()
        {
            List<Perscription> perscriptions = new List<Perscription>();

            DbConection con = DbFactory.instance();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT * FROM perscription;");

                //Read the data and store them in the list
                while (dr.Read())
                {
                    Perscription perscription = new Perscription();
                    perscription.PerscriptionID = dr.GetInt32(0);
                    perscription.PatientID = dr.GetInt32(1);
                    perscription.DrugID = dr.GetInt32(2);
                    perscription.StartDate = Convert.ToDateTime(DecryptBytes(dr.GetString(3)));
                    perscription.EndDate = Convert.ToDateTime(DecryptBytes(dr.GetString(4)));
                    perscription.description = dr.GetString(5);
                    perscriptions.Add(perscription);
                }

                //close Data Reader
                dr.Close();
                con.CloseConnection();
            }

            return perscriptions;
        }


        /// <summary>
        /// Adds a staff member and returns true if it added the member
        /// </summary>
        /// <param name="FirstName"></param>
        /// <param name="LastName"></param>
        /// <param name="UserName"></param>
        /// <param name="Password"></param>
        /// <param name="AuthLevel"></param>
        /// <returns></returns>
        public bool addStaff(string FirstName, string LastName, string UserName, string Password, int AuthLevel, int AddressID, DateTime DoB)
        {
            DbConection con = DbFactory.instance();
            if(con.OpenConnection())
            {
                string insertString = "INSERT INTO staff (StaffID, AddressID, FirstName, LastName, UserName, Password, authLevel,DoB) VALUES (NULL, '" + AddressID + "' ,'" + EncryptString( FirstName) + "', '" + EncryptString( LastName) + "', '" + EncryptString( UserName) + "', '" + EncryptString( Password) + "', '" + AuthLevel + "', '" + EncryptString( DoB.ToString()) + "');";
                if (con.Insert(insertString) != 0)
                {
                    con.CloseConnection();
                    
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
        /// <returns></returns>
        public bool addPatient(string FirstName, string LastName, DateTime DoB, string Religion)
        {
            DbConection con = DbFactory.instance();
            if (con.OpenConnection())
            {
                string insertString = "INSERT INTO patient (PatientID, PerscriptionID, AddressID, FirstName, LastName, DateOfBirth, Religeon) VALUES (NULL, NULL, '1', '" + EncryptString( FirstName) + "', '" + EncryptString( LastName) + "', '" + EncryptString(DoB.ToString()) + "', '" + EncryptString( Religion) + "');";
                if (con.Insert(insertString) != 0)
                {
                    con.CloseConnection();

                    return true;
                }


            }

            return false;
        }

        public bool addAppointment(int PatientID, int StaffID, DateTime StartTime, DateTime EndTime, string Description)
        {
            DbConection con = DbFactory.instance();
            if (con.OpenConnection())
            {
                string insertString = "INSERT INTO appointment (AppointmentID, PatientID, StaffID, StartTime, EndTime, Description) VALUES (NULL, '" + PatientID.ToString() + "', '" + StaffID.ToString() + "', '" + EncryptString(StartTime.ToString()) + "', '" + EncryptString(EndTime.ToString()) + "', '" + EncryptString(Description) + "');";
                if (con.Insert(insertString) != 0)
                {
                    con.CloseConnection();

                    return true;
                }


            }

            return false;
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
            sb.Clear();
            byte[] rawPlaintext = Encoding.Unicode.GetBytes(inString);
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(rawPlaintext, 0, rawPlaintext.Length);
                    cs.FlushFinalBlock();
                }

                foreach (byte i in ms.ToArray())
                {
                    sb.Append(i + ",");
                }
                sb.Remove(sb.Length - 1, 1);
                return sb.ToString();
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
            for (int i = 0;i<inListString.Count; i++)
            {
                inBytes.Add(Convert.ToByte(inListString[i]));
            }
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(inBytes.ToArray(), 0, inBytes.Count);
                }
                return UnicodeEncoding.Unicode.GetString(ms.ToArray());
            }
        }


    }
}
