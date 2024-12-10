using Microsoft.AspNetCore.Mvc;

namespace AspMvcRoutingApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class NewsController : Controller
    {

        [Route("{area}/news/{category:alpha}")]
        public IActionResult Index(string category)
        {
            return Content("Edit news in admin panel");
        }
    }
}
