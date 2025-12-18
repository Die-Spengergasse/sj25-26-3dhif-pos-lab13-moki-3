

using BusnetzLab13;

Console.WriteLine("Hello, World!");

ConToJson sebastian = new ConToJson();
//Console.WriteLine(sebastian.readFile("busnetz.json"));
var path = Path.Combine(AppContext.BaseDirectory, "busnetz.json");
var json = File.ReadAllText(path);