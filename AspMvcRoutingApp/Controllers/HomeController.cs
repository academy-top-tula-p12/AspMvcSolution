using AspMvcRoutingApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspMvcRoutingApp.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index(int id)
        {
            return Content($"Index Action id: {id}");
        }

        

        
    }
}
