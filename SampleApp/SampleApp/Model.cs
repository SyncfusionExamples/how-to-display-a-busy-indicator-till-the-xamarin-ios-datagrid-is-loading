using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SampleApp
{
    public class Model
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public int OrderID { get; set; }
        public string Country { get; set; }

        public Model()
        {

        }
        public Model(int customerID, string customerName, int orderID, string country)
        {
            CustomerID = customerID;
            CustomerName = customerName;
            OrderID = orderID;
            Country = country;
        }
    }
}