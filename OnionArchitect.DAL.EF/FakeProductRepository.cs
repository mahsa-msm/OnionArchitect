using OnionArchitect.Core.Contracts;
using OnionArchitect.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnionArchitect.DAL.EF
{
    public class FakeProductRepository : IProductRepository
    {

        private static List<Product> products = new List<Product>();

        public void Add(Product product)
        {
            products.Add(product); 
        }

        public Product FindById(int id)
        {
            return products.Find(c => c.ProductID == id);
        }

        public Product FindByName(string name)
        {
            return products.FirstOrDefault(c => c.Name == name);
        }

        public List<Product> GetAll()
        {
            return products.ToList(); 
        }

        public void Remove(Product product)
        {
            products.Remove(product);
        }
    }

}
