/*Må jeg SNART lave må mine EGNE C# projekter?*/

#region Opgave1
using Program2;
{
var _ = new Bil();
    _.Write(" Motoren er startet.");
    _.Write2("Motoren er slukket.");
}
#endregion

#region Opgave2
{
    var _ = new Bil();
    _.FillGas(2.5);

}
#endregion

#region Opgave3
{
    bool isDie = true;
    var _ = new Bil();

    if (isDie) _.FillGas(54738);
    isDie = !isDie;
    if (!isDie) _.isDiesel();
}
#endregion

#region Opgave4
{
    var _ = new Bil();
    _.Write(_.RemainingGas().ToString());
}
#endregion

namespace Program2 /*STUPID NAME RIGHT? Program is reserved by the SYSTEM*/
{
    public sealed class Bil
    {
        public void Write(string text) => Console.WriteLine(text);
        public void Write2(string text) => Console.WriteLine(text);
        public void FillGas(double liters) => this.Write2("” Filled tank with: \" + liters + \" liters”");
        public void isDiesel() => this.Write("”Filled tank with: \" + liters + \" liters of ”+ isDiesel.");
        public double RemainingGas() => new Random().NextDouble();
    }
}