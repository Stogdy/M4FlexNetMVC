using Microsoft.AspNetCore.Mvc;
using huisapi.Models;

namespace huisapi.Controllers;

[ApiController]
[Route("[controller]")]
public class SensorController : ControllerBase
{
    private readonly ILogger<SensorController> _logger;

    public SensorController(ILogger<SensorController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetSensoren")]
    public Sensoren Get()
    {
        Sensoren sensoren = new Sensoren
        {
            DHT = new DHT
            {
                Temperature = 25,
                Humidity = 11,
                HeatIndex = 6
            }
        };
        return sensoren;
    }
}