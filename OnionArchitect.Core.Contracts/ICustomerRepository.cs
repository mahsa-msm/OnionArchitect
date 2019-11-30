using OnionArchitect.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitect.Core.Contracts
{
    public interface ICustomerRepository
    {
        List<Customer> GetAll();
        void Add(Customer customer);
        void Remove(Customer customer);
        Customer FindById(int id);
        Customer FindByName(string name);


    }
}
