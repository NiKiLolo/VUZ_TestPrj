namespace TestPrj.API;
public class SubwayLine
{
    public int Line { get; set; }
    public List<SubwayStation> Stations { get; set; }
    public List<SubwayTrain> TrainsOnLine { get; set; }

    /*public SubwayLine(List<SubwayStation> stations, int line)
    { 
        this.stations = stations;
        this.line = line;
    }



    public SubwayStation GetSubwayStation(int index)
    {
        return stations[index];
    }
    public string GetSubwayStationName(int index)
    {
        return GetSubwayStation(index).GetNameStation();
    }
    public string GetSubwayStationAdress(int index)
    {
        return GetSubwayStation(index).GetAdress();
    }
    public string GetSubwayStationInfo(int index)
    {
        string str = line.ToString() + " линия " + GetSubwayStationName(index) + ' ' + GetSubwayStationAdress(index);
        return str;
    }


    public void AddStationToLine(SubwayStation subwayStation)
    {
        stations.Add(subwayStation);
    }
    public void RemoveStationFromLine(SubwayStation subwayStation)
    {
        stations.Remove(subwayStation);
    }*/
}