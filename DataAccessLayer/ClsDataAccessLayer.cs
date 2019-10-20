using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using BusinessEntities;

namespace DataAccessLayer
{
    public class ClsDataAccessLayer
    {
        public DatabaseConnection DatabaseConnectionObject;

        public ClsDataAccessLayer()
        {
            //Constructor initializing class variables
            DatabaseConnectionObject = new DatabaseConnection();
        }

        public int CreateCustomer(Customer customerObj)
        {
            int rowsAffected;
            string Query = "INSERT INTO dbo.Customers VALUES('" + customerObj.CustomerID1 + "','" + customerObj.CompanyName1 + "','" + customerObj.ContactName1 + "','" + customerObj.ContactTitle1 + "','" + customerObj.Address1 + "','" + customerObj.City1 + "','" + customerObj.Region1 + "','" + customerObj.PostalCode1 + "','" + customerObj.Country1 + "','" + customerObj.Phone1 + "','" + customerObj.Fax1 + "');";
            SqlCommand sqlCommandObj = new SqlCommand();
            //Opens the connection of SQLConnection Object
            DatabaseConnectionObject.CreateDBConnection();
            //Set the connection field of SQL Command object to the connection opened in the above line.
            sqlCommandObj.Connection = DatabaseConnectionObject.SqlConnectionObj1;
            sqlCommandObj.CommandText = Query;
            try
            {
                rowsAffected = sqlCommandObj.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            DatabaseConnectionObject.CloseDBConnection();
            return rowsAffected;
        }

        public int UpdateCustomer(Customer customerObj)
        {
            int rowsAffected;
            string Query = "UPDATE dbo.Customers SET CompanyName ='" + customerObj.CompanyName1 + "', ContactName ='" + customerObj.ContactName1 + "',ContactTitle ='" + customerObj.ContactTitle1 + "',Address ='" + customerObj.Address1 + "',City ='" + customerObj.City1 + "',Region ='" + customerObj.Region1 + "',PostalCode ='" + customerObj.PostalCode1 + "',Country ='" + customerObj.Country1 + "',Phone ='" + customerObj.Phone1 + "',Fax ='" + customerObj.Fax1 + "' WHERE CustomerID ='" + customerObj.CustomerID1 + "';";
            SqlCommand sqlCommandObj = new SqlCommand();
            //Opens the connection of SQLConnection Object
            DatabaseConnectionObject.CreateDBConnection();
            //Set the connection field of SQL Command object to the connection opened in the above line.
            sqlCommandObj.Connection = DatabaseConnectionObject.SqlConnectionObj1;
            sqlCommandObj.CommandText = Query;
            try
            {
                rowsAffected = sqlCommandObj.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            DatabaseConnectionObject.CloseDBConnection();
            return rowsAffected;
        }

        public int DeleteCustomer(string customerID)
        {
            int rowsAffected;
            string Query = "DELETE FROM dbo.Customers WHERE CustomerID ='" + customerID + "';";
            SqlCommand sqlCommandObj = new SqlCommand();
            //Opens the connection of SQLConnection Object
            DatabaseConnectionObject.CreateDBConnection();
            //Set the connection field of SQL Command object to the connection opened in the above line.
            sqlCommandObj.Connection = DatabaseConnectionObject.SqlConnectionObj1;
            sqlCommandObj.CommandText = Query;
            try
            {
                rowsAffected = sqlCommandObj.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            DatabaseConnectionObject.CloseDBConnection();
            return rowsAffected;
        }

        public Customer SearchCustomer(string customerID)
        {
            Customer customerObj = new Customer();
            string Query = "SELECT * from dbo.Customers WHERE CustomerID ='" + customerID + "';";
            SqlCommand sqlCommandObj = new SqlCommand();
            //Opens the connection of SQLConnection Object
            DatabaseConnectionObject.CreateDBConnection();
            //Set the connection field of SQL Command object to the connection opened in the above line.
            sqlCommandObj.Connection = DatabaseConnectionObject.SqlConnectionObj1;
            sqlCommandObj.CommandText = Query;

            try
            {
                SqlDataReader sqlDataReaderObj = sqlCommandObj.ExecuteReader();
                while (sqlDataReaderObj.Read())
                {
                    customerObj.CustomerID1 = sqlDataReaderObj[0].ToString();
                    customerObj.CompanyName1 = sqlDataReaderObj[1].ToString();
                    customerObj.ContactName1 = sqlDataReaderObj[2].ToString();
                    customerObj.ContactTitle1 = sqlDataReaderObj[3].ToString();
                    customerObj.Address1 = sqlDataReaderObj[4].ToString();
                    customerObj.City1 = sqlDataReaderObj[5].ToString();
                    customerObj.Region1 = sqlDataReaderObj[6].ToString();
                    customerObj.PostalCode1 = sqlDataReaderObj[7].ToString();
                    customerObj.Country1 = sqlDataReaderObj[8].ToString();
                    customerObj.Phone1 = sqlDataReaderObj[9].ToString();
                    customerObj.Fax1 = sqlDataReaderObj[10].ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            DatabaseConnectionObject.CloseDBConnection();
            return customerObj;
        }

        public DataTable ViewAllCustomers()
        {
            DataTable dt = new DataTable();
            string Query = "SELECT * from dbo.Customers;";
            //Opens the connection of SQLConnection Object
            DatabaseConnectionObject.CreateDBConnection();
            //Set the connection field of SQL Command object to the connection opened in the above line.
            SqlDataAdapter sqlDataAdapterObj = new SqlDataAdapter(Query, DatabaseConnectionObject.SqlConnectionObj1);
            sqlDataAdapterObj.Fill(dt);
            return dt;
        }

        public bool Login(string username, string password)
        {
            bool loginSuccessful = false;
            //SaveNewUser(username, password); //Used to insert users into LoginDetails table.
            LoginHandler loginHandlerObj = new LoginHandler();
            loginSuccessful = loginHandlerObj.MatchPassword(username,password);
            return loginSuccessful; 
        }

        public int SaveNewUser(string username, string password)
        {
            LoginHandler loginHandlerObj = new LoginHandler();
            byte[] passwordHash = loginHandlerObj.PasswordHasher(password);
            int rowsAffected;
            string query = "INSERT INTO dbo.LoginDetails VALUES('" + username + "', @password);";
            SqlCommand sqlCommandObj = new SqlCommand();
            //Opens the connection of SQLConnection Object
            DatabaseConnectionObject.CreateDBConnection();
            //Set the connection field of SQL Command object to the connection opened in the above line.
            sqlCommandObj.Connection = DatabaseConnectionObject.SqlConnectionObj1;
            sqlCommandObj.CommandText = query;
            SqlParameter paramPassword = sqlCommandObj.Parameters.AddWithValue("@password",passwordHash);
            paramPassword.DbType = DbType.Binary;
            try
            {
                rowsAffected = sqlCommandObj.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return rowsAffected;
        }

    }
}