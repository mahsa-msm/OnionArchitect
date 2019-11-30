using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnionArchitect.Core.ApplicationService;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OnionArchitect.UI.SiteUI.Controllers
{
    public class OrderLineController : Controller
    {
        private readonly OrderLineService orderLineService;

        // GET: /<controller>/
        public OrderLineController(OrderLineService orderLine)
        {
            orderLineService = orderLine;
        }

        public IActionResult Add()
        {
            int customerId =0;
            int orderId =0   ;
            int quality = 0;
            long price = 0;

            orderLineService.AddOrderLine(customerId, orderId, quality, price); 
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
        public IActionResult GetAll ()
        {
            orderLineService.GetAllOrderLine();
            return View(); 
        }
    }
}
