using Domain.Model;

namespace Domain.Storage
{
    public interface IRepository<T> where T : Entity
    {
        T GetById(int id);
    }
}