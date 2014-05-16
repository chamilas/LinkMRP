using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace DL
{
  public static class ConnectionStringClass
    {


        public static System.Data.SqlClient.SqlConnection GetConnection()
        {
            return new System.Data.SqlClient.SqlConnection(getConnectionStr());
        }

        public static string getConnectionStr()
        {
            string value = ConfigurationManager.ConnectionStrings["MRPConnectionString"].ConnectionString;
            return value;
            
        }

        public static void Save(SqlConnectionStringBuilder builder)
        {

            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConnectionStringSettings dd = new ConnectionStringSettings();
            config.ConnectionStrings.ConnectionStrings.Remove("MRPConnectionString");
            config.ConnectionStrings.ConnectionStrings.Add(new ConnectionStringSettings("MRPConnectionString", builder.ConnectionString, "System.Data.SqlClient"));
            config.Save(ConfigurationSaveMode.Modified);

        }


        public static System.Data.SqlClient.SqlConnection GetConnectionMRP()
        {
            return new System.Data.SqlClient.SqlConnection(getConnectionStrMRP());
        }

        public static string getConnectionStrMRP()
        {
            string value = ConfigurationManager.ConnectionStrings["MRPConnectionString"].ConnectionString;
            return value;
        }



    }
}
