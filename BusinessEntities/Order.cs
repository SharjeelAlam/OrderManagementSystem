using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Order
    {
        int OrderID;
        string CustomerID;
        string EmployeeID;
        DateTime OrderDate;
        DateTime RequiredDate;
        DateTime ShippedDate;
        string ShipVia;
        string Freight;
        string ShipName;
        string ShipAddress;
        string ShipCity;
        string ShipRegion;
        string ShipPostalCode;
        string ShipCountry;

        public int OrderID1
        {
            get
            {
                return OrderID;
            }

            set
            {
                OrderID = value;
            }
        }

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

        public string EmployeeID1
        {
            get
            {
                return EmployeeID;
            }

            set
            {
                EmployeeID = value;
            }
        }

        public DateTime OrderDate1
        {
            get
            {
                return OrderDate;
            }

            set
            {
                OrderDate = value;
            }
        }

        public DateTime RequiredDate1
        {
            get
            {
                return RequiredDate;
            }

            set
            {
                RequiredDate = value;
            }
        }

        public DateTime ShippedDate1
        {
            get
            {
                return ShippedDate;
            }

            set
            {
                ShippedDate = value;
            }
        }

        public string ShipVia1
        {
            get
            {
                return ShipVia;
            }

            set
            {
                ShipVia = value;
            }
        }

        public string Freight1
        {
            get
            {
                return Freight;
            }

            set
            {
                Freight = value;
            }
        }

        public string ShipName1
        {
            get
            {
                return ShipName;
            }

            set
            {
                ShipName = value;
            }
        }

        public string ShipAddress1
        {
            get
            {
                return ShipAddress;
            }

            set
            {
                ShipAddress = value;
            }
        }

        public string ShipCity1
        {
            get
            {
                return ShipCity;
            }

            set
            {
                ShipCity = value;
            }
        }

        public string ShipRegion1
        {
            get
            {
                return ShipRegion;
            }

            set
            {
                ShipRegion = value;
            }
        }

        public string ShipPostalCode1
        {
            get
            {
                return ShipPostalCode;
            }

            set
            {
                ShipPostalCode = value;
            }
        }

        public string ShipCountry1
        {
            get
            {
                return ShipCountry;
            }

            set
            {
                ShipCountry = value;
            }
        }

        public Order()
        {
            OrderID = 0;
            CustomerID = null;
            EmployeeID = null;
            OrderDate = new DateTime();
            RequiredDate = new DateTime();
            ShippedDate = new DateTime();
            ShipVia = null;
            Freight = null;
            ShipName = null;
            ShipAddress = null;
            ShipCity = null;
            ShipRegion = null;
            ShipPostalCode = null;
            ShipCountry = null;
        }
    }
}
