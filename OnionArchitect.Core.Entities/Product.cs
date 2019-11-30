using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitect.Core.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public long Price { get; set; }
        public int CategoryID { get; set; }
        public List<OrderLine> Products { get; set; } = new List<OrderLine>();

    }
}
