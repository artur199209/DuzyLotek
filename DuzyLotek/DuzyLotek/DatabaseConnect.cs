﻿using System.Data.SqlClient;
using System.Windows.Forms;

namespace DuzyLotek
{
    public class DatabaseConnect
    {
        private static DatabaseConnect dbInstance;
        private static string connectionString = "Data Source='ARTUR-KOMPUTER\\SQLEXPRESS';" + "Integrated Security = True;Pooling =False;Initial Catalog ='lotto'";
       
        public readonly static SqlConnection conn = new SqlConnection(connectionString);
		
        private DatabaseConnect()
        {
        }

        public static DatabaseConnect getDbInstance()
        {
            if (dbInstance == null)
            {
                dbInstance = new DatabaseConnect();
            }
            return dbInstance;
        }

        public SqlConnection GetDBConnection()
        {
            try
            {
                conn.Open();
               // MessageBox.Show("Connected");
            }
            catch (SqlException e)
            {
                //MessageBox.Show("Not connected : "+e.ToString());
            }
            finally
            {
               // MessageBox.Show("End...");
            }
            return conn;
        }
    }
}
