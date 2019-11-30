using OnionArchitect.Core.Contracts;
using OnionArchitect.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnionArchitect.DAL.EF
{
    public class FakeOrderLineRepository : IOrderLineRepository
    {
        private static List<OrderLine> orderlines = new List<OrderLine>();
        public void Add(OrderLine orderLine)
        {
            orderlines.Add(orderLine); 
        }

        public OrderLine FindById(int id)
        {
            return orderlines.Find(c => c.OrderID == id); 
        }

        public List<OrderLine> GetAll()
        {
            return orderlines.ToList(); 
        }

        public void Remove(OrderLine orderLine)
        {
            orderlines.Remove(orderLine);
        }
    }
}
