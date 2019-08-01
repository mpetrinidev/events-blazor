using System.Collections.Generic;
using System.Threading.Tasks;
using events.Models;

namespace events.Services
{
    public class EventsService
    {
        private static readonly List<Event> Events = new List<Event> {
            new Event {
                Country = "Argentina",
                Address = "Av. Gouchard 2015",
                Description = "Welcome to the xamarin event",
                ShortDescription = "Welcome to the xamarin event!",
                Title = "Blazor Workshop",
                PictureUrl = "/images/buenos_aires.jpg"
            },
            new Event {
                Country = "Brasil",
                Address = "R. Marquês de São Vicente, 225 - Gávea, Rio de Janeiro - RJ, 22451-900",
                Description = "Evento dentro de la Universidad",
                ShortDescription = "Evento dentro de la universidad",
                Title = "Blazor Workshop",
                PictureUrl = "/images/rio_janeiro.jpg"
            },
            new Event {
                Country = "Perú",
                Address = "Urb. kennedy A psj. los brillantes A15, Cusco 08002",
                Description = "Welcome to the Blazor workshop",
                ShortDescription = "Welcome to the Blazor workshop",
                Title = "Blazor Workshop",
                PictureUrl = "/images/cusco.jpg"
            }
        };

        public Task<List<Event>> GetEventsAsync()
        {
            return Task.FromResult(Events);
        }
    }
}