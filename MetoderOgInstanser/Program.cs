/*Må jeg SNART lave må mine EGNE C# projekter?*/

#region Opgave1
using Bøger;
{
    var SherlockHolmes = new Bog();
    SherlockHolmes.PrintInfo();
}
#endregion

#region Opgave2
{
    var SherlockHolmes = new Bog();
    SherlockHolmes.HarRåd(150, 0); /*False*/
    SherlockHolmes.HarRåd(150, int.MaxValue); /*true*/
}
#endregion


namespace Bøger
{
    public sealed class Bog
    {
        public void PrintInfo() => Console.WriteLine("Jeg er en bog.");
        public bool HarRåd(int pris, int antal) => antal > pris;
    }
}