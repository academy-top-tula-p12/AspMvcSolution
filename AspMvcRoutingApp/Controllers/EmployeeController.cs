using Microsoft.AspNetCore.Mvc;

namespace AspMvcRoutingApp.Controllers
{
    [Route("info")]
    public class EmployeeController : Controller
    {
        [Route("{controller}/{id}")]
        public IActionResult Index(int id)
        {
            return Content($"Employee Page Index Action, id: {id}");
        }

        [Route("{controller}/detail/{id}")]
        [Route("{controller}/context/{id}")]
        public IActionResult Detail(int id)
        {
            return Content($"Employee Page Detail Action, id: {id}");
        }
    }
}
