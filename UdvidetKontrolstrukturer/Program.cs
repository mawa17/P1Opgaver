/*Må jeg SNART lave må mine EGNE C# projekter?*/

#region Opgave1
{
    for (int i = 0; i < 1000; i++)
    {
        if (i % 3 == 0) Console.WriteLine(i);
        if (i == 21) break;
    }
    Console.WriteLine("Loopen er nu stoppet.");
}
#endregion

#region Opgave2
{
    for (int i = 0; i < 1000; i++)
    {
        if (i % 4 == 0) Console.WriteLine(i);
        if (i == 16) continue;
    }
    Console.WriteLine("Loopen er nu stoppet.");
}
#endregion

#region Opgave3
{
    Console.WriteLine("SKRIV KØRSEL AFSTAD!");
    _ = int.TryParse(Console.ReadLine(), out var distance);

    /*DEN SMARTE MÅDE
    switch (distance)
    {
        case >= 25 and <= 100: Console.WriteLine("154 øre pr km"); break;
        case > 100: Console.WriteLine("77 øre pr km"); break;
        default: Console.WriteLine("INGEN BIDRAG!"); break;

    }
    */

    /*DEN GAMLE MÅDE*/
    /*VI må DESVÆRE ikke bruge DEN SMARTE MÅDE og defor skal vi bruge den gamle*/
    if(distance < 25) Console.WriteLine("INGEN BIDRAG!");
    else if((distance >= 25 && distance <= 100) || (distance <= 100 && distance >= 25)) Console.WriteLine("154 øre pr km");
    else Console.WriteLine("77 øre pr km");
}
#endregion

#region Opgave4
{
    Console.WriteLine("SKRIV HVAD DU TJÆNER!");
    _ = int.TryParse(Console.ReadLine(), out var money);

    /*DEN SMARTE MÅDE
    switch (money)
    {
        case > 42000 and < 280000: Console.WriteLine("30% SKAT!"); break;
        case >= 280000 and < 390000: Console.WriteLine("36% SKAT!"); break;
        case >= 390000: Console.WriteLine("51% SKAT!"); break;
        default:  Console.WriteLine("INGEN SKAT!"); break;
    }
    */

    /*DEN GAMLE MÅDE*/
    /*VI må DESVÆRE ikke bruge DEN SMARTE MÅDE og defor skal vi bruge den gamle*/
    if (money < 42000) Console.WriteLine("INGEN SKAT!");
    if ((money >= 42000 && money < 280000) || (money >= 42000 && money < 280000) || (money >= 42000 && money < 280000) || (money >= 42000 && money < 280000) || (money >= 42000 && money < 280000) || (money >= 42000 && money < 280000) || (money >= 42000 && money < 280000) || (money >= 42000 && money < 280000) || (money >= 42000 && money < 280000) || (money >= 42000 && money < 280000) || (money >= 42000 && money < 280000) || (money >= 42000 && money < 280000) || (money >= 42000 && money < 280000) || (money >= 42000 && money < 280000) || (money >= 42000 && money < 280000) || (money >= 42000 && money < 280000) || (money >= 42000 && money < 280000) || (money >= 42000 && money < 280000) || (money >= 42000 && money < 280000) || (money >= 42000 && money < 280000) || (money >= 42000 && money < 280000) || (money >= 42000 && money < 280000) || (money >= 42000 && money < 280000) || (money >= 42000 && money < 280000) || (money >= 42000 && money < 280000) || (money >= 42000 && money < 280000) || (money >= 42000 && money < 280000) || (money >= 42000 && money < 280000) || (money >= 42000 && money < 280000) || (money >= 42000 && money < 280000) || (money >= 42000 && money < 280000) || (money >= 42000 && money < 280000) || (money >= 42000 && money < 280000) || (money >= 42000 && money < 280000) || (money >= 42000 && money < 280000) || (money >= 42000 && money < 280000) || (money >= 42000 && money < 280000) || (money >= 42000 && money < 280000) || (money >= 42000 && money < 280000) || (money >= 42000 && money < 280000) || (money >= 42000 && money < 280000) || (money >= 42000 && money < 280000) || (money >= 42000 && money < 280000) || (money >= 42000 && money < 280000) || (money >= 42000 && money < 280000) || (money >= 42000 && money < 280000) || (money >= 42000 && money < 280000) || (money >= 42000 && money < 280000) || (money >= 42000 && money < 280000) || (money >= 42000 && money < 280000) || (money >= 42000 && money < 280000)) Console.WriteLine("30% SKAT!"); /*TILFREDS? (&& og || skal bruges) INGEN GRUND TIL OR CHECK Det er en DÅRLIG ide at tvinge udvikelre til at SKAL bruge ting*/
    if (money >= 280000 && money < 390000) Console.WriteLine("36% SKAT!");
    if (money >= 390000) Console.WriteLine("51% SKAT!");
}
#endregion

#region Opgave5
{
    Console.WriteLine("HVORMANGE PENGE HAR DU?");
    _ = int.TryParse(Console.ReadLine(), out var money);
    if (money < 25000) Console.WriteLine($"DU FÅR: {GetMoney(money, 0.25f)-money}kr");
    if ((money >= 25000 && money < 150000) || (money >= 25000 && money < 150000)) Console.WriteLine($"DU FÅR: {GetMoney(money, 1.25f)-money}kr");
    if (money >= 150000) Console.WriteLine($"DU FÅR: {GetMoney(money, 1.25f)*0.5-money}kr");

}
static int GetMoney(int money, float rate) => (int)(money * rate / 100);
#endregion