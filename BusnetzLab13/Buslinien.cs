namespace BusnetzLab13;

public class Busnetz
{
    public List<Buslinien> Busliniens { get; set; }
}

public class Buslinien
{
    public int LinienNummer { get; set; }
    public string Fahrer { get; set; }
    
}

public class Haltestelle
{
    public string Name { get; set; }
    public string Zeit { get; set; }
}