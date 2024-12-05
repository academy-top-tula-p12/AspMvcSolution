using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AspMvcWelcomeApp.Controllers
{
    public class MyController : Controller
    {
        [NonAction]
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine($"Controller: {context.Controller.GetType()}");
            Console.WriteLine($"Action: {context.ActionDescriptor.DisplayName} start");
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine($"Action: {context.ActionDescriptor.DisplayName} finish");
        }
    }
}
