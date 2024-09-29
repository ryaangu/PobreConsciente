using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PobreConsciente.Domain.Contracts;

namespace PobreConsciente.Infrastructure.Configuration;

public static class ModelBuilderExtensions
{
    public static void ApplyEntityIdConfiguration(this ModelBuilder modelBuilder)
    {
        var entities = modelBuilder.GetEntities<IEntity>();

        var properties = entities.SelectMany(entity => entity.GetProperties())
                                 .ToList();

        foreach (var property in properties.Where(property => property.ClrType == typeof(int) && 
                                                              property.Name == "Id"))
        {
            property.IsKey();
        }
    }

    private static List<IMutableEntityType> GetEntities<T>(this ModelBuilder modelBuilder)
    {
        var entities = modelBuilder.Model.GetEntityTypes()
            .Where(entity => entity.ClrType.GetInterface(typeof(T).Name) != null)
            .ToList();

        return entities;
    }
}