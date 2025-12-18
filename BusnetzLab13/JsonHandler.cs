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
}