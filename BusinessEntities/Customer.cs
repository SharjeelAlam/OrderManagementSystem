using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Customer
    {
        private string CustomerID;
        private string CompanyName;
        private string ContactName;
        private string ContactTitle;
        private string Address;
        private string City;
        private string Region;
        private string PostalCode;
        private string Country;
        private string Phone;
        private string Fax;

        public string CustomerID1
        {
            get
            {
                return CustomerID;
            }

            set
            {
                CustomerID = value;
            }
        }

        public string CompanyName1
        {
            get
            {
                return CompanyName;
            }

            set
            {
                CompanyName = value;
            }
        }

        public string ContactName1
        {
            get
            {
                return ContactName;
            }

            set
            {
                ContactName = value;
            }
        }

        public string ContactTitle1
        {
            get
            {
                return ContactTitle;
            }

            set
            {
                ContactTitle = value;
            }
        }

        public string Address1
        {
            get
            {
                return Address;
            }

            set
            {
                Address = value;
            }
        }

        public string City1
        {
            get
            {
                return City;
            }

            set
            {
                City = value;
            }
        }

        public string Region1
        {
            get
            {
                return Region;
            }

            set
            {
                Region = value;
            }
        }

        public string PostalCode1
        {
            get
            {
                return PostalCode;
            }

            set
            {
                PostalCode = value;
            }
        }

        public string Country1
        {
            get
            {
                return Country;
            }

            set
            {
                Country = value;
            }
        }

        public string Phone1
        {
            get
            {
                return Phone;
            }

            set
            {
                Phone = value;
            }
        }

        public string Fax1
        {
            get
            {
                return Fax;
            }

            set
            {
                Fax = value;
            }
        }

        public Customer()
        {
            CustomerID = null;
            CompanyName = null;
            ContactName = null;
            ContactTitle = null;
            Address = null;
            City = null;
            Region = null;
            PostalCode = null;
            Country = null;
            Phone = null;
            Fax = null;
        }
    }
}
