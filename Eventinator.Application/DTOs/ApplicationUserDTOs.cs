namespace Eventinator.Application.DTOs
{
    public class ApplicationUserReadDTO : BaseAuditStringDTO
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? CustomField { get; set; }
    }

    public class ApplicationUserUpdateDTO : BaseAuditStringDTO
    {
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? CustomField { get; set; }
    }

    public class ApplicationUserDeleteDTO : BaseStringDTO
    {
    }

    public class ApplicationUserCreateDTO
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? PhoneNumber { get; set; }
        public string? CustomField { get; set; }
    }
}
