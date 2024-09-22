using Microsoft.EntityFrameworkCore;

namespace PobreConsciente.Infrastructure.Context;

public sealed class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    
}