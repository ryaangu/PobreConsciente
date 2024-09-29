using Microsoft.EntityFrameworkCore;
using PobreConsciente.Domain.Contracts;

namespace PobreConsciente.Infrastructure.Context;

public sealed class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options), IUnityOfWork
{
    public async Task<bool> Commit() => await SaveChangesAsync() > 0;
}