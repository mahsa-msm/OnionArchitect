using OnionArchitect.Core.Contracts;
using OnionArchitect.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitect.Core.ApplicationService
{
    public class ProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void AddProduct (string name  , long price , int categoryId)
        {
            if (!string.IsNullOrEmpty(name)  &&  price != null && categoryId != null  )
            {
                var productInDb = _productRepository.FindByName(name); 
                if(productInDb == null || productInDb.ProductID< 1 )
                {
                    var product = new Product
                    {
                        Name = name ,
                        Price = price , 
                        CategoryID = categoryId 
                    };
                    _productRepository.Add(product );
                }
            }
        }   

        public void RemoveProduct (int id )
        {
            var product = _productRepository.FindById(id);
            _productRepository.Remove(product);
        }
        public Product FindByName (string name)
        {
            var product = _productRepository.FindByName(name);
            return product; 
        }
        public Product FindById(int id)
        {
            var product = _productRepository.FindById(id);
            return product;
        }
        public List<Product> GetAll ()
        {
            var products = _productRepository.GetAll();
            return products; 
        }

    }
}
