using OnionArchitect.Core.Contracts;
using OnionArchitect.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitect.Core.ApplicationService
{
    public  class OrderLineService
    {
        private readonly IOrderLineRepository _orderLineRepository;

        public OrderLineService (IOrderLineRepository orderLineRepository)
        {
            _orderLineRepository = orderLineRepository;
        }

        public void AddOrderLine (int productID , int orderID  , int quality , long price )
        {
            if(productID != null && orderID != null && quality != null && price != null)
            {
                var orderLine = new OrderLine
                {
                    ProductID = productID,
                    OrderID = orderID,
                    Quality = quality,
                    Price = price
                };
                _orderLineRepository .Add(orderLine);
            }
        }
        public void RemoveOrderLine (int id )
        {
            var orderLine = _orderLineRepository.FindById(id);
            _orderLineRepository.Remove(orderLine);
        }

        public List <OrderLine> GetAllOrderLine()
        {
            var orderLines = _orderLineRepository.GetAll();
            return orderLines;
        }
        public OrderLine FindByIdOrderLine (int id )
        {
            var orderLine = _orderLineRepository.FindById(id);
            return orderLine; 
        }
    }
}
