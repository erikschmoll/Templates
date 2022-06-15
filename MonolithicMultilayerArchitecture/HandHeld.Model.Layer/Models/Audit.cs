
namespace HandHeld.Model.Layer.Models
{
    public class Audit
    {
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Updated { get; set; }

        public Audit(string createdBy, string updatedBy, DateTimeOffset created, DateTimeOffset updated)
        {
            CreatedBy = createdBy;
            UpdatedBy = updatedBy;
            Created = created;
            Updated = updated;
        }
        public Audit()
        {
            CreatedBy = UpdatedBy = "Unknown";
        }
    }
}
