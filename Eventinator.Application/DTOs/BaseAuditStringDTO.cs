namespace Eventinator.Application.DTOs
{
    public abstract class BaseAuditStringDTO : BaseStringDTO
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool IsDeleted => DeletedAt.HasValue;
    }
}
