namespace BusnetzLab13;

public class JsonHandler
{
    public string readFile(string filename)
    {
        return File.ReadAllText(filename);
    }

    public void readBusnetz(Busnetz b1)
    {
        Console.WriteLine("\n");
        foreach (var linie in b1.Buslinien)
        {
            Console.WriteLine(linie);

            foreach (var h in linie.Haltestellen)
            {
                Console.WriteLine("  " + h);
            }

            Console.WriteLine();
        }
    }


    public Haltestellen createHalteStellen(string name, string zeit)
    {
        return new Haltestellen(name, zeit);
    }

    public void addFahrerUndHaltestelle(string fahrer, Haltestellen h, Busnetz b, string buslinie)
    {
        bool found = false;
        foreach (Buslinien bl in b.Buslinien)
        {
            if (bl.LinienNummer.Equals(buslinie))
            {
                bl.Haltestellen.Add(h);
                bl.Fahrer = fahrer;
                found = true;
            }
        }

        if (!found)
        {
            List<Haltestellen> tmp = new List<Haltestellen>();
            tmp.Add(h);
            b.Buslinien.Add(new Buslinien(buslinie, fahrer,tmp));
        }
        
    }
}