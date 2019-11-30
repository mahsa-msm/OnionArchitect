using OnionArchitect.Core.Contracts;
using OnionArchitect.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitect.Core.ApplicationService
{
    public class CustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public void AddCustomer(string fristname  , string lastname , string emailaddress )
        {
            if (!string .IsNullOrEmpty (fristname) && !string.IsNullOrEmpty(lastname) && !string.IsNullOrEmpty(emailaddress))
            {
                var customerInDb = _customerRepository.FindByName(fristname);
                if(customerInDb == null || customerInDb.CustomerID <  1)
                {
                    var customer = new Customer
                    {
                        FristName = fristname,
                        LastName = lastname,
                        EmailAddress = emailaddress
                    };
                    _customerRepository.Add(customer);
                }
            }
        }

        public void RemoveCustomer(int id)
        {
                var customer = _customerRepository.FindById(id);
                if (customer != null || customer.CustomerID >= 1)
                {
                    _customerRepository.Remove(customer);
                }
            
        }
        public List<Customer> GetAllCustomer ()
        {
            var customers = _customerRepository.GetAll();
            return customers; 
        }

        public Customer FindByNameCustomer(string name)
        {
                var customer = _customerRepository.FindByName(name);
                return customer;
            
        }
        public Customer FindByIdCustomer(int id)
        {
            var customer = _customerRepository.FindById(id);
            return customer;
        }


    }
}
