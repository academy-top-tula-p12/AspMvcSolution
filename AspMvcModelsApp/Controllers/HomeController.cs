using AspMvcModelsApp.Models;
using AspMvcModelsApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspMvcModelsApp.Controllers
{
    public class HomeController : Controller
    {
        List<Airline> airlines;

        List<Flight> flights;

        List<AirlineViewModel> airlinesView;

        FlightsViewModel flightsView;
        public HomeController()
        {
            airlines = new List<Airline>()
            {
                new(){ Name = "Aeroflot" },
                new(){ Name = "Pobeda" },
            };

            flights = new List<Flight>()
            {
                new(){ Name = "ASD-890", FromCity = "Moscow", ToCity = "St Peterbug", DateTime = DateTime.Now.AddDays(15), Airline = airlines[0]},
                new(){ Name = "TR-123", FromCity = "Irkutsk", ToCity = "Kazan", DateTime = DateTime.Now.AddDays(17), Airline = airlines[1] },
                new(){ Name = "HGT-556", FromCity = "Novosibirsk", ToCity = "Tomsk", DateTime = DateTime.Now.AddDays(9), Airline = airlines[0] },
            };

            airlinesView
                = airlines.Select(
                    a => new AirlineViewModel() { Id = a.Id, Name = a.Name }
                ).ToList();
            airlinesView.Insert(0, new AirlineViewModel() { Id = 0, Name = "All" });
        }

        public IActionResult Index(int? airlineId)
        {
            flightsView = new() { Airlines = airlinesView, Flights = flights };

            if(airlineId is not null && airlineId > 0)
                flightsView.Flights = flights.Where(f => f.Airline?.Id == airlineId).ToList();

            return View(flightsView);
        }

        public IActionResult Add()
        {
            List<AirlineViewModel> airlinesView
                = airlines.Select(
                    a => new AirlineViewModel() { Id = a.Id, Name = a.Name }
                ).ToList();

            return View(airlinesView);
        }

        [HttpPost]
        public IActionResult Add(Flight flight)
        {
            flights.Add(flight);
            return RedirectToAction("Index");
        }
    }
}
