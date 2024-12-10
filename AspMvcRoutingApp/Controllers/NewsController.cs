using Microsoft.AspNetCore.Mvc;

namespace AspMvcRoutingApp.Controllers
{
    public class NewsController : Controller
    {
        [Route("news/{category:alpha}")]
        public IActionResult Index(string category)
        {
            return Content($"News at catogory {category}");
        }

        public IActionResult Sports()
        {
            return Content($"News at catogory Sports");
        }
    }
}
