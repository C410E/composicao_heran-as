namespace Airline;

public interface IArplane
{
    string Prefix { get; set; }
    void Load();

    void Load(double weight);

    double CalculateCoast();
}