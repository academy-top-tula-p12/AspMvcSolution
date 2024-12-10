using AspMvcModelsApp.Models;

namespace AspMvcModelsApp.ViewModels
{
    public class FlightsViewModel
    {
        public IEnumerable<AirlineViewModel> Airlines { get; set; } = new List<AirlineViewModel>();
        public IEnumerable<Flight> Flights { get; set; } = new List<Flight>();
    }
}
