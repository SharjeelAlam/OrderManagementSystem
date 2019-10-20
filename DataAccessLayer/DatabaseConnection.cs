using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DatabaseConnection
    {
        string DBServer;
        string DatabaseName;
        string Username;
        string Password;
        string DBConnectionString;
        SqlConnection SqlConnectionObj;

        public SqlConnection SqlConnectionObj1
        {
            get
            {
                return SqlConnectionObj;
            }

            set
            {
                SqlConnectionObj = value;
            }
        }

        public DatabaseConnection()
        {
            //Initializing the values for database connection string in this Constructor
            DBServer = "LAPTOP-K2PTEQ63";
            DatabaseName = "Northwind";
            Username = "sa";
            Password = "123";
            DBConnectionString = "Data Source=" + DBServer + ";Initial Catalog =" + DatabaseName + "; User ID =" + Username + "; Password =" + Password;
            SqlConnectionObj = new SqlConnection(DBConnectionString);
        }

        public void CreateDBConnection()
        {
            //Open the Database Connection in this function
            try
            {
                SqlConnectionObj.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CloseDBConnection()
        {
            SqlConnectionObj.Close();
        }
    }
}