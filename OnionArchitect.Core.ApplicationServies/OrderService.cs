using OnionArchitect.Core.Contracts;
using OnionArchitect.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnionArchitect.Core.ApplicationService
{
    public class OrderService 
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void AddOrder ( int customerID ,DateTime date , long price )
        {
            if (customerID != null && date != null && price != null)
            {
                // var orderInDb = _orderRepository.FindById();

                var order = new Order
                {
                    CustomerID = customerID,
                    Date = date,
                    Price = price

                };

                _orderRepository.Add(order);
            }
        }
        public void RemoveOrder (int id )
        {
            var order = _orderRepository.FindById(id); 
            if (order != null || order.OrderID >=  1 )
            {
                _orderRepository.Add(order);
            }
        }

        public List<Order> GetAllOrder ()
        {
            var orders = _orderRepository.GetAll();
            return orders.ToList(); 
        }
        public Order FindByIdOrder(int id )
        {
            var order = _orderRepository.FindById(id);
            return order; 
        }

    }
}
