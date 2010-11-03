using System;
using System.Linq;
using System.Web.Mvc;
using Domain.Model;
using Domain.Storage;
using StructureMap;

namespace Website.ModelBinders
{
    public class QueryableModelBinder<T> : IFilteredModelBinder where T : Entity
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var repository = ObjectFactory.GetInstance<IRepository<T>>();
            return repository.All();
        }

        public bool IsMatch(Type modelType)
        {
            return modelType == typeof(IQueryable<T>);
        }
    }
}