using AspMvcHtmlHelpersApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspMvcHtmlHelpersApp.Controllers
{
    public class HomeController : Controller
    {
        List<string> cities = new() { "Moscow", "Voroneg", "Kaluga" };
        List<string> names = new() { "Bobby", "Tommy", "Jimmy" };
        public IActionResult Index()
        {
            return View(new ListViewModel() { Title = "Cities", Items = cities, Order = true });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form(Employee e)
        {
            return Content($"Name: {e.Name}, Age: {e.Age}");
        }


    }
}
