/*Må jeg SNART lave må mine EGNE C# projekter?*/
/*
#region Opgave1
{
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine(i);
    }
    int index = 1;
    while (index <= 10)
    {
        Console.WriteLine(index);
        ++index;
    }
}
#endregion

#region Opgave2
{
    for (int i = 100 - 1; i >= 1; i--)
    {
        Console.WriteLine(i);
    }
    int index = 100;
    while (index > 0)
    {
        Console.WriteLine(index);
        --index;
    }
}
#endregion

#region Opgave3
{
    for (int i = 0; i < 1000; i++)
    {
        if (i % 5 == 0) Console.WriteLine(i);
    }
}
#endregion

#region Opgave4
{
    do
    {
        for (int i = 0; i < 1; i++)
        {
            Console.WriteLine("20-0");
        }
    } while (false);
}
#endregion

#region Opgave5
{
    for (int i = 0; i < 1000; i++)
    {
        if (i % 7 == 0) Console.WriteLine(i);
    }
}
#endregion

#region Opgave6
{
    Console.WriteLine("SKRIV EN TABEL");
    _ = int.TryParse(Console.ReadLine(), out var table);
    for (int i = 0; i < 1000; i++)
    {
        if (i % table == 0) Console.WriteLine(i);
    }
}
#endregion
#region Opgave7
{
    const byte width = 10;
    const byte height = 4;
    Console.SetCursorPosition(20, 4);
    for (int y = 0; y < height; y++)
    {
        Console.CursorLeft = 20;
        if(y == 0 | y == height-1) Console.WriteLine(new String('=', width));
        else Console.WriteLine("="+new String(' ', width-2) +"=");
    }
}
#endregion


#region Opgave8
{
    const byte width = 10;
    const byte height = 4;
    Console.SetCursorPosition(20, 4);
    for (int y = 0; y < height; y++)
    {
        Console.CursorLeft = 20;
        if (y == 0 | y == height - 1) Console.WriteLine(new String('=', width));
        else Console.WriteLine("=" + new String(' ', width - 2) + "=");
    }
    Console.SetCursorPosition(22, 6);
    Console.Write("MARCUS");
    Console.WriteLine(new String(' ', 1));
}
#endregion
*/
#region Opgave9
{
    Console.WriteLine("SKRIV NAVN");
    var name = Console.ReadLine();
    Console.WriteLine("SKRIV HØJTE");
    _ = byte.TryParse(Console.ReadLine(), out var height);
    Console.WriteLine("SKRIV BREDDE");
    _ = byte.TryParse(Console.ReadLine(), out var width);
    _ = Console.ReadLine();

    Console.SetCursorPosition(20, 4);
    for (int y = 0; y < height; y++)
    {
        Console.CursorLeft = 20;
        if (y == 0 | y == height - 1) Console.WriteLine(new String('=', width));
        else Console.WriteLine("=" + new String(' ', width - 2) + "=");
    }
    Console.SetCursorPosition(22, 6);
    Console.Write(name);
    Console.WriteLine(new String(' ', 1));
}
#endregion