namespace Eventinator.Domain.Entities
{
    public class Plan : BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
