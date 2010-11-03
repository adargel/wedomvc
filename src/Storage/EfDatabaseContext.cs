using System.Data.Entity;
using Domain.Model;

namespace Storage
{
    public class EfDatabaseContext : DbContext
    {
        public DbSet<T> All<T>() where T: Entity
        {
            return Set<T>();
        }

        private DbSet<Category> Categories { get; set; }
    }
}