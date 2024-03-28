namespace Airline;

public class Airplane : IArplane
{
    public string Prefix { get; set; }

    public Airplane(string Prefix)
    {
        this.Prefix = Prefix;
    }
    public virtual void Load(){}

    public virtual void Load(double weight){}

    public virtual double CalculateCoast() 
    {
        return 0;
    }
    public double CalculateStandardCost()
    {
        return 1352.45;
    }
}