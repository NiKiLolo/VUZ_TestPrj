using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TestPrj.API.Controllers;

[ApiController]
[Route("[controller]")]
public class SubwayStationController : ControllerBase
{
    private static readonly string[] StaionName = new[]
    {
        "ст.Маяковского", "ст.Крышесновского", "ст.Дыбенко", "ст.Приморская", "ст.Бабино", "ст.Девяткино", "ст.Древнерусское", "ст.Черная Речка-2"
    };
    private static readonly string[] Adress = new[]
    {
        "ул.Линия-1 д1", "ул.Линия-81 д71", "ул.Линия-51 д16", "ул.Линия-91 д21", "ул.Линия-65 д14", "ул.Линия-661 д14", "ул.Линия-44 д23", "ул.Линия-78 д634"
    };

    private readonly ILogger<SubwayStationController> _logger;

    public SubwayStationController(ILogger<SubwayStationController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetSubwayStation")]
    public IEnumerable<SubwayStation> Get()
    {
        return Enumerable.Range(1, 7).Select(index => new SubwayStation() {NameStation = StaionName[index],Adress = Adress[index] } ).ToArray();
    }

}
