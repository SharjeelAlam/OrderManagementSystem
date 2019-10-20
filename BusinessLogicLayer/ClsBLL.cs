using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessEntities;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class ClsBLL
    {
        public DataAccessLayer.ClsDataAccessLayer ClsDalObj;

        public ClsBLL()
        {
            ClsDalObj = new ClsDataAccessLayer();
        }

        public int CreateCustomer(Customer customerObj)
        {
            return ClsDalObj.CreateCustomer(customerObj);
        }

        public int UpdateCustomer(Customer customerObj)
        {
            return ClsDalObj.UpdateCustomer(customerObj);
        }

        public int DeleteCustomer(string customerID)
        {
            return ClsDalObj.DeleteCustomer(customerID);
        }

        public Customer SearchCustomer(string customerID)
        {
            return ClsDalObj.SearchCustomer(customerID);
        }

        public DataTable ViewAllCustomers()
        {
            return ClsDalObj.ViewAllCustomers();
        }

        public bool Login(string username, string password)
        {
            return ClsDalObj.Login(username, password);
        }

    }
}
