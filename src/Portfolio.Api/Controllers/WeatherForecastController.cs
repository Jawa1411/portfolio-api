using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class WeatherForecastController : Controller
    {
        [HttpGet]
        public ActionResult GetWeatherForecast()
        {
            var summaries = new[]
            {
                "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            };

            var forecast = Enumerable.Range(1, 5).Select(index =>
                new WeatherForecast
                (
                    DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                    Random.Shared.Next(-20, 55),
                    summaries[Random.Shared.Next(summaries.Length)]
                ))
                .ToArray();

            //return NotFound();
            return Ok(new { Data = forecast });
        }
    }
}

