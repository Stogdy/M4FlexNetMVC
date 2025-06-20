namespace huisapi.Models;

public class Sensoren
{
    public DHT DHT { get; set; }
}

public class DHT
{
    public int Temperature { get; set; }
    public int Humidity { get; set; }
    public int HeatIndex { get; set; }
}