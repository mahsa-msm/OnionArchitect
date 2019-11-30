using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitect.Core.Entities
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string FristName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public List<Contact> Contacts { get; set; } = new List<Contact>();
        public List<Order> Orders { get; set; } = new List<Order>();

    }
}
