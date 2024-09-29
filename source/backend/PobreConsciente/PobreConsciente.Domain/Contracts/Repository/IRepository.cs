using System.Linq.Expressions;
using PobreConsciente.Domain.Entities;

namespace PobreConsciente.Domain.Contracts.Repository;

public interface IRepository<T> where T : Entity
{
    public IUnityOfWork UnityOfWork { get; }

    public Task<T?> FirstOrDefault(Expression<Func<T, bool>> expression);
    void Create(T entity);
    Task<T?> GetById(int? id);
    Task<List<T>> GetAll();
    void Update(T entity);
    void Delete(T entity);
}