/*Må jeg SNART lave må mine EGNE C# projekter?*/




#region Opgave1
{
    int tal1 = 42, tal2 = (1 << 6), result = tal1 + tal2;
    if (result == 100) Console.WriteLine(" Summen er 100.");
    else if (result > 100) Console.WriteLine(" Summen er større end 100!.");
    else Console.WriteLine(" Summen er mindre end 100.");
}
#endregion

#region Opgave2
{
    Console.WriteLine("SKERIV DIN ALDER!");
    var _ = byte.TryParse(Console.ReadLine(), out var age);
    if (age > 57) Console.WriteLine(" Du er for gammel");
    else Console.WriteLine(" Du er ikke for gammel.");
}
#endregion

#region Opgave3
{
    Console.WriteLine("SKERIV DIN ALDER!");
    var _ = byte.TryParse(Console.ReadLine(), out var age);
    if (age > 60) Console.WriteLine(" Du er for gammel");
    else if(age > 50 && age < 60) Console.WriteLine("Du er hverken for gammel eller for ung.");
    else if (age < 50) Console.WriteLine(" Du er for ung. ");

}
#endregion

#region Opgave4
{
    const string navn = default, brugernavn = default, password = default;
    Console.WriteLine("SKRIV DIT BRUGERNAVN!!!!!!!!!");
    var name = Console.ReadLine();
    Console.WriteLine("SKRIV DIT KODEORD!!!!!!!!!");
    var pass = Console.ReadLine();

    if (name == brugernavn && pass == password) Console.WriteLine("Velkommen + brugerens navn.");
    else Console.WriteLine(": brugernavn eller password er forkert.");
}
#endregion

#region Opgave5
{
    const string navn = default, brugernavn = default, password = default;
    Console.WriteLine("SKRIV DIT BRUGERNAVN!!!!!!!!!");
    var name = Console.ReadLine();

    if (name != brugernavn) Console.WriteLine("brugernavnet er forkert.");
    else if (name == brugernavn)
    {
        Console.WriteLine("SKRIV DIT KODEORD!!!!!!!!!");
        var pass = Console.ReadLine();

        if (pass != password) Console.WriteLine(" Passwordet er forkert");
        else if (pass == password)
        {
            Console.WriteLine("Velkommen + brugerens navn");
        }
    }
}
#endregion

#region Opgave6
{
    Console.WriteLine("hvor mange km der køres hver dag til og fra arbejde.");
    var _ = ulong.TryParse(Console.ReadLine(), out var distance);
    if (distance < 24) Console.WriteLine(" Du får ikke noget fradrag");
    else if (distance >= 25 && distance <= 120)
    {
        var udregning = distance * 1.93;
        Console.WriteLine("(Formel = (km pr. dag – 24) * 1,93)");
    }
    else
    {
        var udregning = distance * 0.97;
        Console.WriteLine("(Formel = 96 * 1,93 + (km pr. dag – 120) * 0,97)");
    }
}
#endregion

#region Opgave7
{
    Console.Title = "Festen";
    string color, age;
    Console.WriteLine("SKRIV DIN FARVE!");
    color = Console.ReadLine();
    if (color != "rød" || color != "grøn" || color != "blå" || color != "gul") Console.WriteLine("DU VALGE EN TABER FARVE!");
    Console.WriteLine("SKRIV DIN ALDER!");
    age = Console.ReadLine();
    if (color == "rød") Console.BackgroundColor = ConsoleColor.Red;
    if (color == "grøn") Console.BackgroundColor = ConsoleColor.Green;
    if (color == "blå") Console.BackgroundColor = ConsoleColor.Blue;
    if (color == "gul") Console.BackgroundColor = ConsoleColor.Yellow;
    byte.TryParse(age, out var a);
    if (a > 18) Console.WriteLine("velkommen til cocktailbaren.");
    else Console.WriteLine(" velkommen til sodavandsbaren");
    Thread.Sleep(10000);
    Environment.Exit(0);
}
#endregion