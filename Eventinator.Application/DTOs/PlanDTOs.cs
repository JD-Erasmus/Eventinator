namespace Eventinator.Application.DTOs
{
    public class PlanReadDTO : BaseAuditDTO
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class PlanUpdateDTO : BaseAuditDTO
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class PlanDeleteDTO : BaseDTO
    {
    }

    public class PlanCreateDTO
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
