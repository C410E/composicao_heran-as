namespace Airline;

public class PassagerAirplane : Airplane
{
    private int PassagerCapacity { get; set; }

    private int PassagerQuantity = 0;

    public PassagerAirplane(string Prefix, int PassagerCapacity) : base(Prefix)
    {
        this.PassagerCapacity = PassagerCapacity;
    }
    public void Load()
    {   
        if (PassagerQuantity == PassagerCapacity)
        {
            throw new ArgumentException("No seats left");
        }
        PassagerQuantity += 1;
    }
}