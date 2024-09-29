using System.Reflection;
using Microsoft.EntityFrameworkCore;
using PobreConsciente.Infrastructure.Configuration;
using PobreConsciente.Domain.Contracts;

namespace PobreConsciente.Infrastructure.Context;

public sealed class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options), IUnityOfWork
{
    public async Task<bool> Commit() => await SaveChangesAsync() > 0;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        modelBuilder.ApplyEntityIdConfiguration();

        base.OnModelCreating(modelBuilder);
    }
}