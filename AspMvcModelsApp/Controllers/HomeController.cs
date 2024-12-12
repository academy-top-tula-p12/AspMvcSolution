using AspMvcModelsApp.Models;
using AspMvcModelsApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspMvcModelsApp.Controllers
{
    public class HomeController : Controller
    {
        static List<Airline> airlines = new List<Airline>()
        {
            new(){ Id = 1, Name = "Aeroflot" },
            new(){ Id = 2, Name = "Pobeda" },
        };

        static List<Flight> flights = new List<Flight>()
        {
            new(){ Id = 1, Name = "ASD-890", FromCity = "Moscow", ToCity = "St Peterbug", DateTime = DateTime.Now.AddDays(15), Airline = airlines[0]},
            new(){ Id = 2, Name = "TR-123", FromCity = "Irkutsk", ToCity = "Kazan", DateTime = DateTime.Now.AddDays(17), Airline = airlines[1] },
            new(){ Id = 3, Name = "HGT-556", FromCity = "Novosibirsk", ToCity = "Tomsk", DateTime = DateTime.Now.AddDays(9), Airline = airlines[0] },
        };

        //List<AirlineViewModel> airlinesView;

        //FlightsViewModel flightsView;
        public HomeController()
        {
            //airlines = new List<Airline>()
            //{
            //    new(){ Id = 1, Name = "Aeroflot" },
            //    new(){ Id = 2, Name = "Pobeda" },
            //};

            //flights = new List<Flight>()
            //{
            //    new(){ Id = 1, Name = "ASD-890", FromCity = "Moscow", ToCity = "St Peterbug", DateTime = DateTime.Now.AddDays(15), Airline = airlines[0]},
            //    new(){ Id = 2, Name = "TR-123", FromCity = "Irkutsk", ToCity = "Kazan", DateTime = DateTime.Now.AddDays(17), Airline = airlines[1] },
            //    new(){ Id = 3, Name = "HGT-556", FromCity = "Novosibirsk", ToCity = "Tomsk", DateTime = DateTime.Now.AddDays(9), Airline = airlines[0] },
            //};

            
        }

        public IActionResult Index(int? airlineId)
        {
            List<AirlineViewModel>  airlinesView
                = airlines.Select(
                    a => new AirlineViewModel() { Id = a.Id, Name = a.Name }
                ).ToList();
            airlinesView.Insert(0, new AirlineViewModel() { Id = 0, Name = "All" });

            FlightsViewModel flightsView = new() { Airlines = airlinesView, Flights = flights };

            if(airlineId is not null && airlineId > 0)
                flightsView.Flights = flights.Where(f => f.Airline?.Id == airlineId);

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
            var maxId = flights.Max(f => f.Id);
            flight.Id = maxId + 1;


            flights.Add(flight);
            return RedirectToAction("Index");
        }
    }
}
