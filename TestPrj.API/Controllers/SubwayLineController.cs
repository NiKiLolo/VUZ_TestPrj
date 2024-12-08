using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TestPrj.API.Controllers;

[ApiController]
[Route("[controller]")]
public class SubwayLineController : ControllerBase
{

    private static readonly string[] StaionName = new[]
    {
        "ст.Маяковского", "ст.Крышесновского", "ст.Дыбенко", "ст.Приморская", "ст.Бабино", "ст.Девяткино", "ст.Древнерусское", "ст.Черная Речка-2", "ст.Черная Речка-1"
    };
    private static readonly string[] Adress = new[]
    {
        "ул.Линия-1 д1", "ул.Линия-81 д71", "ул.Линия-51 д16", "ул.Линия-91 д21", "ул.Линия-65 д14", "ул.Линия-661 д14", "ул.Линия-44 д23", "ул.Линия-78 д634", "ул.Линия-52 д34"
    };
    private static readonly string[] TrainNames = new[]
    {
        "ЕМ-605", "ВМ-903", "Витязь-909", "Витязь-808", "АС-99", "АС-93", "ПАР-23", "Чанстон-II"
    };

    static List<SubwayStation> Station_(int index)
    {
        List<SubwayStation> _stations = new List<SubwayStation>();
        for (int i = index; i < index + 3; i++)
            _stations.Add(new SubwayStation() { NameStation = StaionName[i], Adress = Adress[i] });
        return _stations;
    }
    static List<SubwayTrain> Trains_()
    {
        List<SubwayTrain> _trains = new List<SubwayTrain>();
        for (int i = 0; i < Random.Shared.Next(1, 4); i++)
            _trains.Add(new SubwayTrain() {TrainName = TrainNames[Random.Shared.Next(0,TrainNames.Length)], TrainCapacity = Random.Shared.Next(2000, 2500), Year = Random.Shared.Next(1980, 2016)});
        return _trains;

    }

    private readonly ILogger<SubwayLineController> _logger;

    public SubwayLineController(ILogger<SubwayLineController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetSubwayLine")]
    public IEnumerable<SubwayLine> Get()
    {
        return Enumerable.Range(0, 3).Select(index => new SubwayLine() {Line = index+1, Stations = Station_(index*3), TrainsOnLine = Trains_()}).ToArray();
    }
}

