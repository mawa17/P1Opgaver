/*Må jeg SNART lave må mine EGNE C# projekter?*/

var _ = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
var __ = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
#region Opgave1
{
    Console.WriteLine(_.Sum());
	for (int i = 0; i < __.Length; i++)
	{
        Console.WriteLine(__[i]);
    }
}
#endregion