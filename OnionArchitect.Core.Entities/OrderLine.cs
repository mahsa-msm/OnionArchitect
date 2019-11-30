using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitect.Core.Entities
{
    public class OrderLine
    {
        public int OrderLineID { get; set; }
        public int ProductID { get; set; }
        public int OrderID { get; set;  }
        public int Quality { get; set; }
        public long Price { get; set; }

    }
}
