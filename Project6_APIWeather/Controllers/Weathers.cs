using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project6_APIWeather.Context;
using Project6_APIWeather.Entities;

namespace Project6_APIWeather.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Weathers : ControllerBase
    {
        WeatherContext weatherContext = new WeatherContext();

        [HttpGet] // listing

        public IActionResult WeatherCityList()
        {
            var values = weatherContext.Cities.ToList();
            return Ok(values);
        }


        [HttpPost]
        public IActionResult AddToCityForWeather(City city)
        {
            var value = weatherContext.Cities.Add(city);
            weatherContext.SaveChanges();
            return Ok("City added");
        }

        [HttpDelete]
        public IActionResult DeleteToCityForWeather(int id)
        {
            var value = weatherContext.Cities.Find(id);
            weatherContext.Cities.Remove(value);
            weatherContext.SaveChanges();
            return Ok("City deleted");
        }

        [HttpPut]
        public IActionResult UpdateToCityForWeather(City city)
        {
            var value = weatherContext.Cities.Find(city.CityId);
            value.CityName = city.CityName;
            value.Detail = city.Detail;
            value.Temp = city.Temp;
            value.Country = city.Country;
            weatherContext.SaveChanges();
            return Ok("City is updated");
        }

        [HttpGet("GetById")]

        public IActionResult GetCityWeatherById(int id)
        {
            var value = weatherContext.Cities.Find(id);
            return Ok(value);
        }

        [HttpGet("TotalCityCount")]

        public IActionResult GetTotalCityCount()
        {
            var value = weatherContext.Cities.Count();
            return Ok(value);
        }

        [HttpGet("HighestTempCityName")]

        public IActionResult HighestTempCityName()
        {
            var value = weatherContext.Cities
                .OrderByDescending(x=>x.Temp)
                .Select(x=>x.CityName)
                .FirstOrDefault();

            return Ok(value);
        }

        [HttpGet("LowestTempCityName")]

        public IActionResult LowestTempCityName()
        {
            var value = weatherContext.Cities
                .OrderBy(x => x.Temp)
                .Select(x => x.CityName)
                .FirstOrDefault();

            return Ok(value);
        }




    }
}
