namespace PobreConsciente.Domain.Contracts;

public interface IUnityOfWork
{
    Task<bool> Commit();
}