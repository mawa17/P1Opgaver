/*Må jeg SNART lave må mine EGNE C# projekter?*/

#region Opgave1
using Bøger;
{
    var instance1 = new Bog();
    var instance2 = new Bog();
    Console.WriteLine("\"(title) - koster (pris) kr.\" For\r\neksempel: \"Moby Dick - koster 240 kr.\"");
}
#endregion

/*JEG GIDER IKKE FLERE DUMMY OPGAVER MÅ JEG LAVE MINE TING SNART!?!?!?!"??!?!?*/

namespace Bøger
{
    public sealed class Bog
    {
        public void PrintInfo() => Console.WriteLine("Jeg er en bog.");
        public bool HarRåd(int antal) => antal > 240;
    }
}