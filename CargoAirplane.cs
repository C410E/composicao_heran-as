namespace Airline;

public class CargoAirplane : Airplane
{
    private double Payload { get; set; }
    private double Loadweight { get; set; }

    public CargoAirplane(string Prefix, double Payload) : base(Prefix)
    {
        this.Payload = Payload;
    }

    public override void Load(double weight)
    {
        if ((Loadweight + weight) > Payload) 
        {
            throw new ArgumentException("Payload Achivied");
        }
        Loadweight += weight;
    }
    public override double CalculateCoast() 
    {
        return 0;
    }
}