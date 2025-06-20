using Microsoft.AspNetCore.Mvc;
using huisapi.Models;

namespace huisapi.Controllers;

[ApiController]
[Route("[controller]")]
public class LampController : ControllerBase
{
    private readonly Ilogger<LampController> _logger;

    public LampController(Ilogger<LampController> logger)
    {
    _logger = logger;
    }

    [HttpGet(Name = "GetLampen")]
    public Lampen Get()
    {
    Lampen Lampen = new Lampen();
    
    return Lampen;
    }
}