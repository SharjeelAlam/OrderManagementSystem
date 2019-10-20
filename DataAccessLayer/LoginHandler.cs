using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace DataAccessLayer
{
    class LoginHandler
    {
        private int saltSize;
        private int hashSize;
        public LoginHandler()
        {
            saltSize = 0;
            hashSize = 50;
        }
        public byte[] PasswordHasher(string password)
        {
            byte[] salt = ASCIIEncoding.Unicode.GetBytes("ThisIsASalt");
            saltSize = salt.Length;
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt);
            var hash = pbkdf2.GetBytes(hashSize);
            return hash;
        }

        public bool MatchPassword(string username, string enteredPassword)
        {
            bool loginSuccessful = false;
            byte[] returnedPasswordHash = null;
            DatabaseConnection databaseConnectionObj = new DatabaseConnection();
            databaseConnectionObj.CreateDBConnection(); //Sets the connection string and opens database connection
            string Query = "SELECT Password FROM dbo.LoginDetails WHERE Username='" + username + "';";
            SqlCommand sqlCommandObj = new SqlCommand();
            sqlCommandObj.CommandText = Query;
            sqlCommandObj.Connection = databaseConnectionObj.SqlConnectionObj1;
            try
            {
                SqlDataReader sqlDataReaderObj = sqlCommandObj.ExecuteReader();
                if (sqlDataReaderObj.HasRows)
                {
                    while (sqlDataReaderObj.Read())
                    {
                        returnedPasswordHash = (byte[])sqlDataReaderObj[0];
                    }
                }
                else
                {
                    return loginSuccessful;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            var enteredPasswordHash = PasswordHasher(enteredPassword);
            if (ByteArrayCompare(returnedPasswordHash, enteredPasswordHash))
            {
                loginSuccessful = true;
            }
            else
            {
                loginSuccessful = false;
            }
            return loginSuccessful;
        }

        private static bool ByteArrayCompare(byte[] array1, byte[] array2)
        {
            if (array1.Length != array2.Length)
            {
                return false;
            }

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    return false;
                }
            }
                return true;
        }
    }

    
}
