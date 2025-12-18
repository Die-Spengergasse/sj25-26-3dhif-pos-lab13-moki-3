

using System.Text.Json;
using BusnetzLab13;

Console.WriteLine("Hello, World!");

JsonHandler con = new JsonHandler();
string file = con.readFile("busnetz.json");
Console.WriteLine(file);

Busnetz b1 = JsonSerializer.Deserialize<Busnetz>(file);
con.readBusnetz(b1);



