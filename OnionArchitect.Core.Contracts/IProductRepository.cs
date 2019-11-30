using OnionArchitect.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitect.Core.Contracts
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        void Add(Product product);
        void Remove(Product product);
        Product FindById(int id);
        Product FindByName(string name);

    }
}
