using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using PobreConsciente.Domain.Contracts;
using PobreConsciente.Domain.Contracts.Repository;
using PobreConsciente.Domain.Entities;
using PobreConsciente.Infrastructure.Context;

namespace PobreConsciente.Infrastructure.Repository;

public abstract class Repository<T> : IRepository<T>
    where T : Entity
{
    protected ApplicationDbContext Context;
    private DbSet<T> _dbSet;

    public IUnityOfWork UnityOfWork => Context;

    public Repository(ApplicationDbContext context)
    {
        Context = context;
        _dbSet = Context.Set<T>();
    }

    public async Task<T?> FirstOrDefault(Expression<Func<T, bool>> expression)
    {
        return await _dbSet.AsNoTrackingWithIdentityResolution().Where(expression).FirstOrDefaultAsync();
    }

    public async Task<List<T>> GetAll()
    {
        return await _dbSet.AsNoTracking().ToListAsync();
    }

    public async Task<T?> GetById(int? id)
    {
        return await _dbSet.FindAsync(id);
    }

    public void Create(T entity)
    {
        _dbSet.Add(entity);
    }

    public void Update(T entity)
    {
        _dbSet.Update(entity);
    }

    public void Delete(T entity)
    {
        _dbSet.Remove(entity);
    }
}