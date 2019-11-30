using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnionArchitect.Core.ApplicationServies;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OnionArchitect.UI.SiteUI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryService categoryService;

        public CategoryController (CategoryService category)
        {
            categoryService = category;
        }
        // GET: /<controller>/
        public IActionResult Add()
        {
            string categoryName = $"Category {DateTime.Now.Ticks}";
            categoryService.AddCategory(categoryName);
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
            categoryService.GetAllCategory();
            return View();
        }
    }
}
