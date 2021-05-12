using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Services
{
    public class CityService
    {
        List<City> Cities;
        public CityService()
        {
            Cities = new List<City>()
            {
                new City(){ Name= "Heifa", Id = 1},
                new City(){ Name="Tel Aviv", Id = 2}
            };
        }

        public void AddCity(string name) => Cities.Add(new City() { Name = name, Id = Cities.Max(c => c.Id) + 1 });
        public IEnumerable<City> GetCities => Cities;

    }
}
