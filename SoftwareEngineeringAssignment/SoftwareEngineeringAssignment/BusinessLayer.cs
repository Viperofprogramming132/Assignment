using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Diagnostics;

namespace SoftwareEngineeringAssignment
{
    public class BusinessLayer
    {
        static private BusinessLayer m_instance = null;
        private StringBuilder sb = new StringBuilder();
        AesCryptoServiceProvider aesCSP;
        private BusinessLayer()
        {
            aesCSP = new AesCryptoServiceProvider();

            aesCSP.Key = new byte[32] { 2, 254, 44, 83, 232, 130, 185, 243, 187, 155, 219, 136, 198, 231, 16, 214, 20, 237, 205, 166, 157, 82, 255, 242, 140, 191, 104, 55, 188, 69, 247, 114 };
            aesCSP.IV = new byte[16] { 81, 117, 207, 183, 191, 235, 72, 140, 140, 2, 226, 123, 239, 207, 58, 113 };


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
                    staff.StaffID = dr.GetInt32(0).ToString();
                    staff.FName = DecryptBytes(aesCSP, dr.GetString(1));
                    staff.LName = DecryptBytes(aesCSP, dr.GetString(2));
                    staff.UserName = DecryptBytes(aesCSP, dr.GetString(3));
                    staff.Password = DecryptBytes(aesCSP, dr.GetString(4));
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
                string insertString = "INSERT INTO staff (StaffID, AddressID, FirstName, LastName, UserName, Password, authLevel,DoB) VALUES (NULL, '" + AddressID + "' ,'" + EncryptString(aesCSP, FirstName) + "', '" + EncryptString(aesCSP, LastName) + "', '" + EncryptString(aesCSP, UserName) + "', '" + EncryptString(aesCSP, Password) + "', '" + AuthLevel + "', '" + EncryptString(aesCSP, DoB.ToString()) + "');";
                if (con.Insert(insertString) != 0)
                {
                    con.CloseConnection();
                    
                    return true;
                }
                
                
            }
            
            return false;
        }

        public bool addPatient(string FirstName, string LastName, string UserName, string Password, int AuthLevel)
        {
            DbConection con = DbFactory.instance();
            if (con.OpenConnection())
            {
                string insertString = "INSERT INTO `staff` (`staffID`, `StaffFirstName`, `StaffLastName`, `UserName`, `Password`, `authLevel`) VALUES (NULL, '" + EncryptString(aesCSP, FirstName) + "', '" + EncryptString(aesCSP, LastName) + "', '" + EncryptString(aesCSP, UserName) + "', '" + EncryptString(aesCSP, Password) + "', '" + AuthLevel + "');";
                if (con.Insert(insertString) != 0)
                {
                    con.CloseConnection();

                    return true;
                }


            }

            return false;
        }


        /// <summary>
        /// encrypts the given string using the SymmetricAlgorithm given
        /// </summary>
        /// <param name="symAlg"></param>
        /// <param name="inString"></param>
        /// <returns></returns>
        public string EncryptString(SymmetricAlgorithm symAlg, string inString)
        {
            sb.Clear();
            byte[] inBlock = UnicodeEncoding.UTF32.GetBytes(inString);
            ICryptoTransform xfrm = symAlg.CreateEncryptor();
            byte[] outBlock = xfrm.TransformFinalBlock(inBlock, 0, inBlock.Length);

            foreach(byte i in outBlock)
            {
                sb.Append(i + ",");
            }
            sb.Remove(sb.Length-1, 1);
            return sb.ToString();
        }


        /// <summary>
        /// Decrypts the given string using the SymmetricAlgorithm given
        /// </summary>
        /// <param name="symAlg"></param>
        /// <param name="inString"></param>
        /// <returns></returns>
        public string DecryptBytes(SymmetricAlgorithm symAlg, string inString)
        {
            List<byte> inBytes = new List<byte>();
            List<string> inListString = new List<string>();
            inListString = inString.Split(',').ToList();
            for (int i = 0;i<inListString.Count; i++)
            {
                inBytes.Add(Convert.ToByte(inListString[i]));
            }
            ICryptoTransform xfrm = symAlg.CreateDecryptor();
            byte[] outBlock = xfrm.TransformFinalBlock(inBytes.ToArray(), 0, inBytes.Count);

            return UnicodeEncoding.UTF32.GetString(outBlock);
        }

        public bool addStaff(string FirstName, string LastName, string UserName, string Password, int AuthLevel)
        {
            DbConection con = DbFactory.instance();
            if (con.OpenConnection())
            {
                string insertString = "INSERT INTO staff (staffID, FirstName, LastName, UserName, Password, authLevel) VALUES (NULL, '" + EncryptString(aesCSP, FirstName) + "', '" + EncryptString(aesCSP, LastName) + "', '" + EncryptString(aesCSP, UserName) + "', '" + EncryptString(aesCSP, Password) + "', '" + AuthLevel + "');";
                if (con.Insert(insertString) != 0)
                {
                    con.CloseConnection();

                    return true;
                }


            }

            return false;
        }
    }
}
