/*Må jeg SNART lave må mine EGNE C# projekter?*/

#region Opgave1
{
    new Computer().PrintShit();
}
#endregion

public abstract class Furniture
{
   public int _ = default;

}

public abstract class Chair : Furniture
{
    public int __ = default;

}
public sealed class Computer : Chair
{
    public int ___ = default;
    public void PrintShit() => Console.WriteLine(_ + __ + ___);
}
