using System;
using System.Linq;
using Domain.Model;
using Domain.Queries.Providers;
using StructureMap;

namespace Domain.Queries
{
    public static class CategoryQueryExtensions
    {
        static CategoryQueryExtensions()
        {
            Provider = source => ObjectFactory.With(source).GetInstance<ICategoryQueryProvider>();
        }

        public static Func<IQueryable<Category>, ICategoryQueryProvider> Provider { get; set; }

        public static ICategoryQueryProvider Where(this IQueryable<Category> source)
        {
            return Provider(source);
        }
    }
}