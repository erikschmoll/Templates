
namespace HandHeld.Model.Layer.Models
{
    public class Base : Audit
    {
        public object Id { get; set; }

        public Base()
        {
            Id = Guid.NewGuid().ToString();
        }
        public Base(object id)
        {
            Id = id;
        }
    }
}
