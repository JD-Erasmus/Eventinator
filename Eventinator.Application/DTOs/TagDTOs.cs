namespace Eventinator.Application.DTOs
{
    public class TagReadDTO : BaseAuditDTO
    {
        public string Name { get; set; }
    }

    public class TagUpdateDTO : BaseAuditDTO
    {
        public string Name { get; set; }
    }

    public class TagDeleteDTO : BaseDTO
    {
    }

    public class TagCreateDTO
    {
        public string Name { get; set; }
    }
}
