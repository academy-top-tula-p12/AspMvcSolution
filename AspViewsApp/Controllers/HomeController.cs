using AspViewsApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspViewsApp.Controllers
{
    public class HomeController : MyController
    {

        
        public IActionResult Index()
        {
            MyViewData["Title"] = "Index";
            return View(MyViewData);
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
