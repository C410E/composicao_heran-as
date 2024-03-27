namespace Airline;

public class Airplane
{
    public string Prefix;

    public Airplane(string Prefix)
    {
        this.Prefix = Prefix;
    }
    public double CalculateCost()
    {
        return 1200;
    }
}