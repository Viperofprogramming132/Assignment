using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Diagnostics;

namespace SoftwareEngineeringAssignment
{
    public class Database
    {
        SqlConnection con;
        SqlCommand cmd;
        private static Database m_uniqueInstance = null;

        public static Database getInstance()
        {
            if (m_uniqueInstance == null)
            {
                m_uniqueInstance = new Database();
            }
            return m_uniqueInstance;
        }
    
        private Database()
        {
            
        }

        private void connect()
        {
            try
            {
                con.Open();
            }
            catch(Exception e)
            {
                Debug.WriteLine(e);
            }
            Debug.WriteLine("Connected");
        }

        private void disconnect()
        {
            con.Close();
            con.Dispose();
        }

        public void addPatient()
        {
            
        }

        public bool queryStaff(string username, string password)
        {
            System.Security.SecureString test = new System.Security.SecureString();
            test.IsReadOnly();

            SqlCredential sqlCredential = new SqlCredential("root",test);
            con = new SqlConnection("server=localhost;user id=root;database=test;Trusted_Connection=true;",sqlCredential);
            connect();
            Debug.WriteLine(con.Credential);

            Debug.WriteLine(con.Database);

            cmd = con.CreateCommand();

            cmd.CommandText = "SELECT * FROM staffMembers WHERE UserName='@UN' AND Password='@Pass';";
            cmd.Parameters.AddWithValue("@UN", username);
            cmd.Parameters.AddWithValue("@Name", password);
            
            if (true)
            {
                return true;
            }
            return false;
        }

        public void addStaff(string username, string password)
        {
            System.Security.SecureString test = new System.Security.SecureString();
            test.MakeReadOnly();

            SqlCredential sqlCredential = new SqlCredential("root", test);
            con = new SqlConnection("server=localhost;database=test;", sqlCredential);
            connect();

            cmd = con.CreateCommand();

            cmd.CommandText = "INSERT INTO `staffMembers` (`staffID`, `StaffFirstName`, `StaffLastName`, `UserName`, `Password`) VALUES (NULL, 'Bob', 'Bill', 'Hello', 'Password')";
            int i = cmd.ExecuteNonQuery();

            Debug.WriteLine(i.ToString() + " Rows affected");


        }
    }
}
