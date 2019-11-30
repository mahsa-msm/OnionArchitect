using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnionArchitect.Core.ApplicationService;
using OnionArchitect.Core.Entities;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OnionArchitect.UI.SiteUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService productservice;

        public ProductController(ProductService product)
        {
            productservice = product;
        }
        // GET: /<controller>/

        public IActionResult Add()
        {
            string productName = $"Product {DateTime.Now.Ticks}";
            int categoryId = 0; 
            long price = 0;
            productservice.AddProduct(productName, price, categoryId);
            return View();
        }
        public IActionResult Remove()
        {
            return View();
        }
        public IActionResult FindById()
        {
            return View();
        }
        public IActionResult FindByName()
        {
            return View();
        }
        public IActionResult GetAll()
        {
            productservice.GetAll();
            return View();
        }
    }
}
