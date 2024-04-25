namespace dnet_exception_handling.Domain.Interfaces;

public interface IRepository<T> where T : class
{
    void SaveAsync();
}