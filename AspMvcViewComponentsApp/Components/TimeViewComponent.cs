using AspMvcViewComponentsApp.Types;
using Microsoft.AspNetCore.Mvc;

namespace AspMvcViewComponentsApp.Components
{
    //[ViewComponent]
    public class Time : ViewComponent
    {
        public IViewComponentResult Invoke(bool secondView, FormatTime format = FormatTime.Hours24)
        {
            string time = "";
            if(format == FormatTime.Hours24)
                time = $"Time: {DateTime.Now.ToString("HH:mm")}";
            else
                time = $"Time: {DateTime.Now.ToString("hh:mm")}";

            if (secondView)
                time += $":{DateTime.Now.Second}";

            return Content(time) ;

        }
    }
}
