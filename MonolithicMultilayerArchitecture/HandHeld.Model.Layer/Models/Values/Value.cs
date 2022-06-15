
namespace HandHeld.Model.Layer.Models.Values
{
    public class Value : Base
    {
        public string Name { get; set; }
        public Value(string name)
        {
            Name = name;
        }
        public Value()
        {
            Name = "Unknown";
        }
    }
}
