using AspMvcViewComponentsApp.Models;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;


namespace AspMvcViewComponentsApp.Components
{
    public class FlightCardViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(Flight flight)
        {
            //string html = "<div>";
            //html += $"<h2>{flight.Name}</h2>";
            //html += $"<h3>{flight.ToCity}</h3>";
            //html += $"<h4>{flight.Date.ToShortDateString()}</h4></div>";

            //return new HtmlContentViewComponentResult(new HtmlString(html));

            return View(flight);
        }
    }
}
