using AspMvcTagHelpersApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace AspMvcTagHelpersApp.Controllers
{
    public class HomeController : Controller
    {
        List<Company> companies;

        List<Employee> employees;
        public HomeController()
        {
            companies = new()
            {
                new(){ Id = 1, Title = "Yandex" },
                new(){ Id = 2, Title = "Ozon" },
                new(){ Id = 3, Title = "Avito" },
            };

            employees = new()
            {
                new() { Id = 1, Name = "Bobby", Age = 29, CompanyId = 1 },
                new() { Id = 2, Name = "Sammy", Age = 32, CompanyId = 2 },
                new() { Id = 3, Name = "Jimmy", Age = 19, CompanyId = 3 },
                new() { Id = 4, Name = "Tommy", Age = 24, CompanyId = 1 },
                new() { Id = 5, Name = "Benny", Age = 31, CompanyId = 2 },
                new() { Id = 6, Name = "Lenny", Age = 27, CompanyId = 1 },
            };
        }
        public IActionResult Index()
        {
            return View();
        }

        

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Form()
        {
            ViewBag.Companies = new SelectList(companies, "Id", "Title");
            return View();
        }

        [HttpPost]
        public IActionResult Form(Employee employee)
        {
            string? companyTitle = companies.FirstOrDefault(c => c.Id == employee.CompanyId)?.Title;
            
            return Content($"Name: {employee.Name}, Age: {employee.Age}, Company: {companyTitle}, Position: {employee.PositionId}");
        }

        public IActionResult Info()
        {
            ViewBag.Names = new[] { "Bobby", "Sammy", "Jimmy" };
            ViewBag.Employee = new Employee() { Id = 10, Name = "Poppy", Age = 31 };
            return View();
        }
    }
}
