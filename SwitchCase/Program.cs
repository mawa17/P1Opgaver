/*Må jeg SNART lave må mine EGNE C# projekter?*/

#region Opgave1
{
    Console.WriteLine("SKRIV ET TAL 1-6");
    _ = byte.TryParse(Console.ReadLine(), out var num);
    if (num < 1 || num > 6) Console.WriteLine("KUN TAL MELLME 1-6 ER KODKENDT!!!!!!!!!!");
    switch (num)
    {
        case 4:
            string text = "TILLYKKE DU HAR VUNDET";
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(new string(' ', (Console.WindowWidth/2)-text.Length/2)+text);
            break;
        default:
            Console.WriteLine("Du har tastet + tallet {0}", num);
            break;
    }
}
#endregion

#region Opgave2
{
    Random rand = new Random();
    (string, ushort)[] StuffToDrink =
    {
        new("Isbjørn", (ushort)rand.Next(0, ushort.MaxValue)),
        new("Champagnebrus", (ushort)rand.Next(0, ushort.MaxValue)),
        new("Tequila Sunrise", (ushort)rand.Next(0, ushort.MaxValue)),
        new("Mojito", (ushort)rand.Next(0, ushort.MaxValue)),
        new("Brandbil", (ushort)rand.Next(0, ushort.MaxValue)),
        new("Filur", (ushort)rand.Next(0, ushort.MaxValue)),
    };
    Console.WriteLine("SKRIV EN DRINK");
    var drink = Console.ReadLine();
    if (!StuffToDrink.Any(x => x.Item1.Contains(drink))) Console.WriteLine("DEN DRINK FINDES IKKE");
    var seletedDrink = StuffToDrink.FirstOrDefault(x => x.Item1.Contains(drink));
    Console.WriteLine($"DU HAR VALGT: {seletedDrink.Item1} OG DEN KOSTER {seletedDrink.Item2}kr HVIS DU IKKE HAR RÅD BARE ÆRGERLIGT PENGENE ER ALLEREDE TRUKKET");
}
#endregion