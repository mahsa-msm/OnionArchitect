using OnionArchitect.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitect.Core.Contracts
{
    public interface IOrderRepository
    {
        List<Order> GetAll();
        void Add(Order order);
        void Remove(Order order);
        Order FindById(int id);
    }
}
