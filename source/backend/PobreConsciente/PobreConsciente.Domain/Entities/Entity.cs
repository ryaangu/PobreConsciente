using PobreConsciente.Domain.Contracts;

namespace PobreConsciente.Domain.Entities;

public abstract class Entity : IEntity
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}