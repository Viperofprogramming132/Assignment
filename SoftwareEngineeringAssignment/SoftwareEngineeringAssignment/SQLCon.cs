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
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
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
            DataSet dataSet;

            // create the object dataAdapter to manipulate a table from the database StudentDissertations specified by connectionToDB
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlStatement, connection);
            // create the dataset
            dataSet = new System.Data.DataSet();
            dataAdapter.Fill(dataSet);
            //return the dataSet
            return dataSet;
        }

        public int Insert(string query)
        {
            //Create Command
            MySqlCommand cmd = new MySqlCommand(query, connection);
            int i = cmd.ExecuteNonQuery();
            return i;
        }

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator\n" + ex.Message);
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again\n" + ex.Message);
                        break;
                    default:
                        MessageBox.Show("Unable to connect to database exception:\n" + ex.Message);
                        break;
                }
                return false;
            }
            return true;
        }

        public void Restore()
        {
            throw new NotImplementedException();
        }

        public DbDataReader Select(string query)
        {
            DbDataReader dr = null;

            if (null != connection)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                //MySqlDataReader dataReader = cmd.ExecuteReader();
                dr = cmd.ExecuteReader();
            }
            return dr;
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
