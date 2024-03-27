namespace Airline;

public class CargeAirplane : Airplane
{
    private double Payload { get; set; }
    private double Loadweight { get; set; }

    public CargeAirplane(string Prefix, double Payload) : base(Prefix)
    {
        this.Payload = Payload;
    }

    public void Load(double weight)
    {
        if ((Loadweight + weight) > Payload) 
        {
            throw new ArgumentException("Payload Achivied");
        }
        Loadweight += weight;
    }
}