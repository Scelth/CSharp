using IRead;
using Mag;
using System.Text.Json;

Console.Write("What do you want?\n" +
    "1 - Serialization\n" +
    "2 - DeSerialization\n" +
    "Your choice - ");
short ch = Int16.Parse(Console.ReadLine());

#region Serialization
if (ch == 1)
{
    Magazine magazine = new();
    IReadable readeable = magazine;

    Console.Write("\nEnter magazine name - ");
    readeable.Name = Console.ReadLine();

    Console.Write("Enter the publishing house name - ");
    readeable.Publishing_house = Console.ReadLine();

    Console.Write("Enter the magazine release year - ");
    readeable.Year = Int16.Parse(Console.ReadLine());

    Console.Write("Enter the number of pages - ");
    readeable.Pages = Int16.Parse(Console.ReadLine());

    Console.Write("Enter the title of the article - ");
    readeable.Article = Console.ReadLine();

    Console.Write("Enter the number of chars - ");
    readeable.Chars = Int32.Parse(Console.ReadLine());

    Console.Write("Enter the announcement of the article - ");
    readeable.Announcement = Int16.Parse(Console.ReadLine());

    using FileStream fs = new("Magazine #2.json", FileMode.OpenOrCreate);
    JsonSerializer.Serialize(fs, readeable);
}
#endregion

#region DeSerialization
else if (ch == 2)
{
    using FileStream fr = new("Magazine #2.json", FileMode.Open);

    var mag = JsonSerializer.Deserialize<Magazine>(fr);

    Console.WriteLine(mag);
}
#endregion