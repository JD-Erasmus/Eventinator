namespace Eventinator.Application.DTOs
{
    public abstract class BaseAuditDTO : BaseDTO
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool IsDeleted => DeletedAt.HasValue;
        public byte[] RowVersion { get; set; } // For concurrency
    }
}
