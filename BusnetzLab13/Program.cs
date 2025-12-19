

using System.Text.Json;
using BusnetzLab13;

Console.WriteLine("Hello, World!");

JsonHandler con = new JsonHandler();
string file = con.readFile("busnetz.json");
Console.WriteLine(file);

Busnetz b1 = JsonSerializer.Deserialize<Busnetz>(file);

con.readBusnetz(b1);


Haltestellen h1 = new Haltestellen("Alt Erlaa", "07:15");





Console.WriteLine("b1:");
con.readBusnetz(b1);


Haltestellen h2 = new Haltestellen("Pilgramgasse", "15:30");
b1 = con.addFahrerUndHaltestelle("Herr Maier", h2, b1, "42");



con.writeInJSON(b1, "busnetz_neu_01.json");




