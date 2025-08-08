namespace Eventinator.Application.DTOs
{
    public class ApplicationRoleReadDTO : BaseAuditStringDTO
    {
        public string Name { get; set; }
        public string? CustomField { get; set; }
    }

    public class ApplicationRoleUpdateDTO : BaseAuditStringDTO
    {
        public string? Name { get; set; }
        public string? CustomField { get; set; }
    }

    public class ApplicationRoleDeleteDTO : BaseStringDTO
    {
    }

    public class ApplicationRoleCreateDTO
    {
        public string Name { get; set; }
        public string? CustomField { get; set; }
    }
}
