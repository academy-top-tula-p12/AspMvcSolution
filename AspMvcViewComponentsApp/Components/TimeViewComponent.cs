using Microsoft.AspNetCore.Mvc;

namespace AspMvcViewComponentsApp.Components
{
    //[ViewComponent]
    public class Time : ViewComponent
    {
        public string Invoke()
        {
            return $"Time: {DateTime.Now.ToShortTimeString()}";
        }
    }
}
