namespace BusnetzLab13;

public class ConToJson
{
    public string readFile(string filename)
    {
        return File.ReadAllText(filename);
        
    }
}