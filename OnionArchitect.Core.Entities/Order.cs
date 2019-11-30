using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitect.Core.Entities
{
    public class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public List<OrderLine> orderLines { get; set; } = new List<OrderLine>();
        public DateTime Date { get; set; }
        public long Price { get; set; }
    }
}
