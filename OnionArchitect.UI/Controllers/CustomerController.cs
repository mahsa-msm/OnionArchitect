using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnionArchitect.Core.ApplicationService;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OnionArchitect.UI.SiteUI.Controllers
{
    public class CustomerController : Controller
    {
        private readonly CustomerService customerService;

        // GET: /<controller>/

        public CustomerController(CustomerService customer)
        {
            customerService = customer;
        }
        public IActionResult Add()
        {
            string customerFristName = $"Customer {DateTime.Now.Ticks}";
            string customerLastName = $"Customer {DateTime.Now.Ticks}";
            string customerEmailAddress = $"Customer {DateTime.Now.Ticks}";
            customerService.AddCustomer(customerFristName , customerLastName , customerEmailAddress) ; 
            return View();
        }

        public IActionResult Remove()
        {
            int customerId = 0;
            customerService.RemoveCustomer(customerId); 
            return View();
        }

        public IActionResult FindById()
        {
            int customerId = 0;
            customerService.FindByIdCustomer(customerId);
            return View();
        }
        public IActionResult FindByName()
        {
            string customerFristName = "Customer"; 
            customerService.FindByNameCustomer(customerFristName);
            return View();
        }
        public IActionResult GetAll()
        {
            customerService.GetAllCustomer();
            return View();
        }


    }
}
