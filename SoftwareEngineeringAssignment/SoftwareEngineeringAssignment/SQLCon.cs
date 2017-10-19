using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Data.Common;
using System.Data;

namespace SoftwareEngineeringAssignment
{
    class SQLCon : DbConection
    {
        Dictionary<string, string> m_properties;
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public SQLCon(Dictionary<string, string> properties)
        {
            m_properties = properties;
            initialize();
        }


        private void initialize()
        {
            server = m_properties["Server"];
            database = m_properties["Database"];
            uid = m_properties["User"];

            setConection();
        }

        private void setConection()
        {
            string connectionString;
            connectionString = "server=" + server + ";" + "database=" +
            database + ";" + "uid=" + uid + ";";
            connection = new MySqlConnection(connectionString);
        }

        public void Backup()
        {
            throw new NotImplementedException();
        }

        public bool CloseConnection()
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public DataSet getDataSet(string sqlStatement)
        {
            throw new NotImplementedException();
        }

        public void Insert()
        {
            throw new NotImplementedException();
        }

        public bool OpenConnection()
        {
            throw new NotImplementedException();
        }

        public void Restore()
        {
            throw new NotImplementedException();
        }

        public DbDataReader Select(string query)
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
