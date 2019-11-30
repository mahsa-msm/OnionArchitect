using OnionArchitect.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitect.Core.Contracts
{
    public interface IOrderLineRepository
    {
        List<OrderLine> GetAll();
        void Add(OrderLine orderLine);
        void Remove(OrderLine orderLine);
        OrderLine FindById(int id);
    }
}
