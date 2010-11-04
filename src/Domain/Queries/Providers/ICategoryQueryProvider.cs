using System.Linq;
using Domain.Model;

namespace Domain.Queries.Providers
{
    public interface ICategoryQueryProvider
    {
        IQueryable<Category> NameEquals(string name);
        IQueryable<Category> NameIsLike(string name);
        IQueryable<Category> NameIsNotLike(string name);
        IQueryable<Category> NameStartsWith(string name);
        IQueryable<Category> NameEndsWith(string name);
    }
}