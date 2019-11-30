using OnionArchitect.Core.Contracts;
using OnionArchitect.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnionArchitect.DAL.EF
{
    public class FackOrderRepository : IOrderRepository
    {
        private static List<Order> orders = new List<Order> (); 
        public void Add(Order order)
        {
            orders.Add(order);
        }

        public Order FindById(int id)
        {
            return orders.Find(c => c.OrderID == id); 
        }

        public List<Order> GetAll()
        {
             return orders.ToList(); 
        }

        public void Remove(Order order)
        {
            orders.Remove(order);  
        } 
    }
}
