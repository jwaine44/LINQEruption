List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46,"Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
// IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
// PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!

// Find the first eruption in Chile and print the result
IEnumerable<Eruption> firstChileEruption = eruptions.Where(chileEruption => chileEruption.Location == "Chile");
Console.WriteLine(firstChileEruption.First());

// Find the first eruption from "Hawaiian Is" location and print it. If none is found, print "No Hawaiian Eruption Is Eruption found."
IEnumerable<Eruption> hawaiianIsEruption = eruptions.Where(hiEruption => hiEruption.Location == "Hawaiian Is");
if(hawaiianIsEruption != null){
    Console.WriteLine(hawaiianIsEruption.First());
} else {
    Console.WriteLine("No Hawaiian Is Eruption found.");
}

// Find the first eruption that is after the year 1900 and in New Zealand and print it
IEnumerable<Eruption> nineteenNZEruption = eruptions.Where(nNZE => nNZE.Year > 1900 && nNZE.Location == "New Zealand");
Console.WriteLine(nineteenNZEruption.First());

// Find all eruptions where the volcano's elevation is over 2000m and print them
IEnumerable<Eruption> over2K = eruptions.Where(o2K => o2K.ElevationInMeters > 2000);
PrintEach(over2K, "Eruptions with volcanoes over 2000m in elevation:");

// Find all eruptions where the volcano's name starts with "Z" and print them; also print the number of eruptions found
IEnumerable<Eruption> zEruptions = eruptions.Where(zErp => zErp.Volcano.StartsWith("Z"));
PrintEach(zEruptions, $"Number of eruptions found: {zEruptions.Count()}");

// Find the highest elevation and print only that integer
int highElevation = eruptions.Max(hiElev => hiElev.ElevationInMeters);
Console.WriteLine(highElevation);

// Use the highest elevation variable to find and print the name of the volcano with that elevation
foreach(var vol in eruptions)
{
    if(vol.ElevationInMeters == highElevation)
    {
        Console.WriteLine($"The volcano with the highest elevation is: {vol.Volcano}");
    }
}

// Print all volcano names alphabetically
IEnumerable<Eruption> alphaEruption = eruptions.OrderBy(abcE => abcE.Volcano);
foreach(var vol in alphaEruption)
{
    Console.WriteLine(vol.Volcano);
}

// Print all the eruptions that happened before the year 1000 CE alphabetically
IEnumerable<Eruption> oldEruptions = eruptions.Where(oldE => oldE.Year < 1000).OrderBy(oldE => oldE.Volcano);
foreach(var vol in oldEruptions)
{
    Console.WriteLine(vol);
}

// Redo the last query, but this time only print the volcano's name
foreach(var volName in oldEruptions)
{
    Console.WriteLine(volName.Volcano);
}

// Helper method to print each item in a List or IEnumerable.This should remain at the bottom of your class!
static void PrintEach(IEnumerable<dynamic> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (var item in items)
    {
        Console.WriteLine(item.ToString());
    }
}
