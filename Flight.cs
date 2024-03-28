namespace Airline;

public class Flight
{
    private string? _flightType;

    private IArplane? _Airplane;
    public string FlightId { get; set; }
    public double Distance;
    public IArplane? Airplane 
    { 
        get { return _Airplane; } 
        set 
        { 
            if (value.GetType() == typeof(PassagerAirplane))
            {
                _flightType = "Comercial";
            }
            else 
            {
                _flightType = "Cargueiro";
            }
            Airplane = value; 
        } 
    }

    public Flight(string FlightId, double Distance)
    {
        this.FlightId = FlightId;
        this.Distance = Distance;
    }
    public double CalculateCost()
    {
        return Airplane.CalculateCoast();
    }
}