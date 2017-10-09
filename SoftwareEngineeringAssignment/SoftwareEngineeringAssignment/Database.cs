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
                catch
                {

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
            throw new NotImplementedException();
        }

        public void addStaff(string username, string password)
        {

        }
    }
}
