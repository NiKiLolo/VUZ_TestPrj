using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TestPrj.API.Controllers;

[ApiController]
[Route("[controller]")]
public class SubwayTrainController : ControllerBase
{
    private readonly ILogger<SubwayTrainController> _logger;
    private static readonly string[] TrainNames = new[]
    {
        "ЕМ-605", "ВМ-903", "Витязь-909", "Витязь-808", "АС-99", "АС-93", "ПАР-23", "Чанстон-II"
    };

    public SubwayTrainController(ILogger<SubwayTrainController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetSubwayTrain")]
    public IEnumerable<SubwayTrain> Get()
    {
        return Enumerable.Range(0, 7).Select(index => new SubwayTrain() {TrainName = TrainNames[index], TrainCapacity = Random.Shared.Next(2000, 2500), Year = Random.Shared.Next(1980, 2016)}).ToArray();
    }
}
