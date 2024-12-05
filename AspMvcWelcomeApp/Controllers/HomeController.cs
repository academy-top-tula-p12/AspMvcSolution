using System.Diagnostics;
using AspMvcWelcomeApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using AspMvcWelcomeApp.Services;

namespace AspMvcWelcomeApp.Controllers
{
    public class HomeController : MyController
    {
        //IDateService _service;

        //public HomeController(IDateService service)
        //{
        //    _service = service;
        //}

        [HttpGet]
        public IActionResult Index()
        {
            Console.WriteLine($"Action: Index work");
            return View();
        }

        [HttpPost]
        public IActionResult Info()
        {
            string name = Request.Form["name"];
            int age = Int32.Parse(Request.Form["age"]);

            //return new MyResult($"Query name: {name}, age: {age}");
            //return Content($"<h2>Query name: {name}, age: {age}</h2>");
            Employee employee = new() { Name = name, Age = age };
            return Json(employee, new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true,
                WriteIndented = true,
            });
        }

        public IActionResult Old()
        {
            //return Redirect("/Home");
            //return RedirectToAction("Index", "Home");
            return RedirectToRoute("default", new { action = "Privacy" });
        }

        public IActionResult SendFile()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "resources/ada.jpg");
            string fileType = "image/jpg";
            string fileName = "ada.jpg";

            byte[] buffer = System.IO.File.ReadAllBytes(filePath);
            FileStream stream = new FileStream(filePath, FileMode.Open);

            //return PhysicalFile(filePath, fileType, fileName);
            //return File(buffer, fileType, fileName);

            return File(stream, fileType, fileName);

        }

        //public IActionResult Date([FromServices] IDateService _service)
        public IActionResult Date()
        {
            IDateService? _service = HttpContext.RequestServices.GetService<IDateService>();
            return Content(_service?.GetDate()!);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        
    }
}
