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
    public class DbFactory
    {
        private static DbConection m_instance = null;

        Dictionary<string, string> m_properties;
        private static string propfile = "properties-mysql.dat";

        private DbFactory()
        {
            m_properties = new Dictionary<string, string>();
        }
        public static DbConection instance()
        {
            if (null == m_instance)
            {
                DbFactory factory = new DbFactory();
                m_instance = factory.getConection();
            }
            return m_instance;
        }
        private DbConection getConection()
        {
            DbConection connection = null;

            try
            {
                m_properties = getProperties();
                string provider = m_properties["Provider"];
                if (provider.Equals("MySQL"))
                    connection = new SQLCon(m_properties);
                else
                {
                    // should throw unsupport exception here
                    throw new DBException("Not supported provider '" + provider + "'");
                }
            }
            catch (FileNotFoundException e)
            {
                Debug.WriteLine("Error file not found" + e.Message);
                connection = null;
                throw e;
            }
            catch (Exception e)
            {
                Debug.WriteLine("Property file parsing exception thrown : " + e.Message);
                connection = null;
                throw e;
            }
            return connection;
        }

        private Dictionary<string, string> getProperties()
        {
            string fileData = "";
            using (StreamReader sr = new StreamReader(propfile))
            {
                fileData = sr.ReadToEnd().Replace("\r", "");
            }
            Dictionary<string, string> properties = new Dictionary<string, string>();
            string[] kvp;
            string[] records = fileData.Split("\n".ToCharArray());
            foreach (string record in records)
            {
                kvp = record.Split("=".ToCharArray());
                properties.Add(kvp[0], kvp[1]);
            }
            return properties;
        }
    }
    class DBException : System.Exception
    {
        public DBException(string message) : base(message) { }
    }

    public interface DbConection
    {
        bool OpenConnection();

        bool CloseConnection();


        //Insert statement
        int Insert(string insertString); 
        //Update statement
        void Update();
        //Delete statement
        void Delete();
        


        //Select statement
        DbDataReader Select(String query);
        
        //Count statement
        int Count();
        void Backup();
        void Restore();
       
        

        DataSet getDataSet(string sqlStatement);

    }
}
