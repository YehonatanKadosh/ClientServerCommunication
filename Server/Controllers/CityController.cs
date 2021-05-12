using Microsoft.AspNetCore.Mvc;
using Server.Models;
using Server.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class CityController : Controller
    {
        private readonly CityService cityService;

        public CityController(CityService cityService)
        {
            this.cityService = cityService;
        }
        [HttpGet]
        public IEnumerable<City> Get() => cityService.GetCities;

        [HttpPost]
        public IActionResult Post(City city)
        {
            cityService.AddCity(city.Name);
            return Ok();
        }
    }
}
