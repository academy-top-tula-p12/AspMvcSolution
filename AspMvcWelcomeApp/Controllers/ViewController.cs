using Microsoft.AspNetCore.Mvc;

namespace AspMvcWelcomeApp.Controllers
{
    public class ViewController : Controller
    {
        public IActionResult Index()
        {
            return View("StartPage");
        }
    }
}
