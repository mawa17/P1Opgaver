/*Må jeg SNART lave må mine EGNE C# projekter?*/

#region Opgave1
using Bøger;
{
    _ = new Bog(1);
}
#endregion


namespace Bøger
{
    public sealed class Bog
    {
        public int Id { get; set; }
        public Bog(int id)
        {
            this.Id = id;
        }
    }
}