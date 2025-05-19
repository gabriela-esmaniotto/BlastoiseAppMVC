namespace BlastoiseApp.Domain.Interfaces.Entities
{
    public interface IBaseEntity
    {
        int Id { get; }

        DateTime CreatedAt { get; }
        DateTime? UpdatedAt { get; }
    }
}
