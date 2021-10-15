using ParksApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParksApp.Services
{
    class ParkDataStore : IParkDataStore<Park>
    {
        private List<Park> parks;
        async Task Init()
        {
            await Task.Delay(100);
        }
        public async Task<IEnumerable<Park>> GetParks()
        {
            await Init();
            parks = new List<Park>
            {
            new Park { Id = 1, Name = "Park A", Description = "Description of park a." },
            new Park { Id = 2, Name = "Park B", Description = "Description of park b." },
            new Park { Id = 3, Name = "Park C", Description = "Description of park c." },
            new Park { Id = 4, Name = "Park D", Description = "Description of park d." }
            };

            return parks;
        }

        public async Task<Park> GetPark(int parkId)
        {
            await Init();

            return parks.Find(park => park.Id == parkId);
        }
    }
}
