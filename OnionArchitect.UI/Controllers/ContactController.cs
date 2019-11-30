using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnionArchitect.Core.ApplicationService;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OnionArchitect.UI.SiteUI.Controllers
{
    public class ContactController : Controller
    {
        private readonly ContactService contactService;

        // GET: /<controller>/
        public ContactController(ContactService contact )
        {
            contactService = contact;
        }

        public IActionResult Add()
        {
            string phonNumber = "Contact";
            int customerId = 0; 
            contactService.AddContact(phonNumber  , customerId);
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
            contactService.GetAllContact();
            return View();
        }
    }
}
