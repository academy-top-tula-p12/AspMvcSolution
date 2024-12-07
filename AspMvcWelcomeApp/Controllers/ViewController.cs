using AspMvcWelcomeApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspMvcWelcomeApp.Controllers
{
    public class ViewController : Controller
    {
        public IActionResult Index()
        {
            return View("StartPage");
        }

        public IActionResult Data()
        {
            string message = "Hello world";
            ViewData["Message"] = message;

            Employee employee = new Employee() { Name = "Olly", Age = 28 };
            ViewData["Employee"] = employee;

            string info = "Employee info:";
            ViewBag.Info = info;

            return View();
        }

        public IActionResult Products()
        {
            //ViewModel viewModel = new ViewModel();
            //viewModel.Title = "Internet shop";
            //viewModel.Description = "Products for sale";
            //viewModel.Footer = "2024 Copyright";
            //viewModel.Products.AddRange(new[]{ "Notebook", "Computer", "Phone"} );

            Dictionary<string, object> dataModel = new();
            dataModel.Add("Title", "Internet shop");
            Employee employee = new Employee() { Name = "Olly", Age = 28 };
            dataModel.Add("Employee", employee);

            return View(dataModel);
        }
    }
}
