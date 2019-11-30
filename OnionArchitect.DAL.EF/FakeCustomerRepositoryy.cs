using OnionArchitect.Core.Contracts;
using OnionArchitect.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnionArchitect.DAL.EF
{
    public class FakeCustomerRepositoryy : ICustomerRepository
    {
        private static  List<Customer> customers =  new List<Customer>();
        public void Add(Customer customer)
        {
            customers.Add(customer); 
        }

        public Customer FindById(int id)
        {
            return customers.Find(c => c.CustomerID == id);
        }

        public Customer FindByName(string name)
        {
            return customers.FirstOrDefault(c => c.FristName == name);
        }

        public List<Customer> GetAll()
        {
            return customers.ToList(); 
        }

        public void Remove(Customer customer)
        {
            customers.Remove(customer); 
        }
    }
}
