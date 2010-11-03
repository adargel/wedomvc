using System;
using System.Linq;
using Domain.Model;
using Domain.Storage;

namespace Storage
{
    public class EfRepository<T> : IRepository<T> where T: Entity
    {
        readonly EfDatabaseContext _context;

        public EfRepository(EfDatabaseContext context)
        {
            _context = context;
        }

        public T GetById(int id)
        {
            return _context.All<T>().Find(id);
        }

        public IQueryable<T> All()
        {
            return _context.All<T>();
        }
    }
}