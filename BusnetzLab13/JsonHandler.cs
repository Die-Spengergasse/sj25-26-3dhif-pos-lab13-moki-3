using System.Text.Json;

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

    public Busnetz addFahrerUndHaltestelle(string fahrer, Haltestellen h, Busnetz b, string buslinie)
    {
        bool found = false;
        //wenn es die linie gibt, dann wird sie geändert
        foreach (Buslinien bl in b.Buslinien)
        {
            if (!found && bl.LinienNummer.Equals(buslinie))
            {
                bl.Haltestellen.Add(h);
                bl.Fahrer = fahrer;
                found = true;
            }
        }

        //wenn es die linie nicht gibt, wird sie hinzugefügt
        if (!found)
        {
            List<Haltestellen> tmp = new List<Haltestellen>();
            tmp.Add(h);
            b.Buslinien.Add(new Buslinien(buslinie, fahrer,tmp));
        }

        return b;
    }

    public void writeInJSON(Busnetz b, string fileName)
    {
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string filePath = Path.Combine(desktopPath, fileName);

        string jsonForFile = JsonSerializer.Serialize(b, new JsonSerializerOptions { WriteIndented = true });
        
        File.WriteAllText(filePath, jsonForFile);

        Console.WriteLine($"File saved to {desktopPath}");
    }
    
    
}