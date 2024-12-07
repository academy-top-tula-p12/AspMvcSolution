using Microsoft.AspNetCore.Mvc;

namespace AspViewsApp.Controllers
{
    public class MyController : Controller
    {
        protected Dictionary<string, object> MyViewData = new();
        public MyController()
        {
            MyViewData.Add("AsideMenu",
            new Dictionary<string, string>()
            {
                { "Home", "/Home/Index" },
                { "Privacy", "/Home/Privacy" },
            });
        }
    }
}
