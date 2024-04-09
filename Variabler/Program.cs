/*Må jeg SNART lave må mine EGNE C# projekter?*/


#region Opgave1 
{
    const int tal1 = 5, tal2 = 3;
    Console.WriteLine($"tal1: {tal1}, tal2: {tal2}");
} 
#endregion
#region Opgave2
{
    const int tal1 = 5, tal2 = 3;
    Console.WriteLine($"tal1: ER {tal1}, \n\rtal2: ER {tal2}");
}
#endregion
#region Opgave3 
{
    const string Navn = "Søren";
    const byte Alder = 16;
    const decimal Penge = 1234.34m;
    Console.WriteLine("”Jeg hedder {0}, er {1} år gammel og har tjent {2} kr. på at lappe cykler", Navn, Alder, Penge);
}
#endregion
#region Opgave4 
{
    /*Opgaven siger VI SKAL bruge "Double" med STORT D og det gør vi*/
    const Double Kage = 23.56;
    const Double Øl = 34.67;
    const Double Pølse = 65.34;
    Console.WriteLine($"Kage\t\t{Kage} Øl\t{Øl}\n\rPølse\t{Pølse}\n\rI alt\tberegning");
}
#endregion
#region Opgave5
{
    Console.WriteLine("SKriv navn");
    var name = Console.ReadLine();
    Console.WriteLine("SKriv Alder");
    var alder = Console.ReadLine();
    Console.WriteLine($"Jeg hedder {name} og er {alder} år gammel.");
}
#endregion
#region Opgave6
{
    Console.WriteLine("SKriv Radius");
    var radius = Console.ReadLine();
    Console.WriteLine("Formel: Formel: Areal = PI * r²");
    Console.WriteLine($"PI: {Math.PI}");
    Console.WriteLine($"R²: {Math.Pow(Double.TryParse(radius, out var r) ? r : 0, 2)}");
}
#endregion