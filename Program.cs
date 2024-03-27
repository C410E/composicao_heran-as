namespace  Airline;

public class MainClass
{
    public static void Main(string[] args)
    {
        PassagerAirplane embraer = new PassagerAirplane("PR-ABC", 110);
        Flight flightA = new Flight("001", 500);
        flightA.Airplane = embraer;

        Console.WriteLine(flightA.Airplane.Prefix + " - " + flightA.CalculateCost().ToString());
    }
}   
