using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Api.Shops.Controllers;

[ApiController]
[Route("[controller]")]
public class ShopsController : ControllerBase
{

    public IEnumerable<WeatherForecast> Get()
    { 
        return Ok("")
    }
}
