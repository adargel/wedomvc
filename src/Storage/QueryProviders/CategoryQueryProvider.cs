using System;
using System.Linq;
using Domain.Model;
using Domain.Queries.Providers;

namespace Storage.QueryProviders
{
    public class CategoryQueryProvider : ICategoryQueryProvider
    {
        readonly IQueryable<Category> _source;

        public CategoryQueryProvider(IQueryable<Category> source)
        {
            _source = source;
        }

        public IQueryable<Category> NameEquals(string name)
        {
            return _source.Where(c => c.Name.Equals(name));
        }

        public IQueryable<Category> NameIsLike(string name)
        {
            return _source.Where(c => c.Name.Contains(name));
        }

        public IQueryable<Category> NameIsNotLike(string name)
        {
            return _source.Where(c => ! c.Name.Contains(name));
        }

        public IQueryable<Category> NameStartsWith(string name)
        {
            return _source.Where(c => c.Name.StartsWith(name));
        }

        public IQueryable<Category> NameEndsWith(string name)
        {
            return _source.Where(c => c.Name.EndsWith(name));
        }
    }
}