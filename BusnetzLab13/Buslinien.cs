using System.Globalization;

namespace BusnetzLab13;

public class Busnetz
{
    public List<Buslinien> Buslinien { get; set; }
}

public class Buslinien
{
    public string LinienNummer { get; set; }
    public string Fahrer { get; set; }
    public List<Haltestellen> Haltestellen { get; set; }


    public Buslinien(string linienNummer, string fahrer, List<Haltestellen> haltestellen)
    {
        LinienNummer = linienNummer;
        Fahrer = fahrer;
        Haltestellen = haltestellen;
    }

    public override string ToString()
    {
        return $"Liniennummer: {LinienNummer}\nFahrer: {Fahrer}";
    }
}

public class Haltestellen
{
    public string Name { get; set; }
    public string Zeit { get; set; }

    public Haltestellen(string name, string zeit)
    {
        Name = name;
        Zeit = zeit;
    }

    public override string ToString()
    {
        return $"Name: {Name}\nZeit: {Zeit}";
    }
}
