namespace Eventinator.Domain.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        /// <summary>When not null, entity is considered soft-deleted.</summary>
        public DateTime? DeletedAt { get; private set; }
        public bool IsDeleted => DeletedAt.HasValue;

        public void SoftDelete()
        {
            DeletedAt = DateTime.UtcNow;
        }

        public void Restore()
        {
            DeletedAt = null;
        }
    }
}
