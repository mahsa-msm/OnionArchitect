using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnionArchitect.Core.ApplicationService;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OnionArchitect.UI.SiteUI.Controllers
{
    public class OrderController : Controller
    {
        private readonly OrderService orderService;

        public OrderController(OrderService order)
        {
           orderService = order;
        }

        // GET: /<controller>/
        public IActionResult Add()
        {
            DateTime orderDate = DateTime.Now;
            int orderCutomerId = 0;
            long OrderPrice = 0;

            orderService.AddOrder(orderCutomerId, orderDate, OrderPrice); 
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
        public IActionResult GetAll()
        {
            orderService.GetAllOrder();
            return View();
        }
    }
}
