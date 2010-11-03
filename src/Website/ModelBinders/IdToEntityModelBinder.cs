using System;
using System.Web.Mvc;
using Domain.Model;
using Domain.Storage;
using StructureMap;

namespace Website.ModelBinders
{
    public class IdToEntityModelBinder<T> : IFilteredModelBinder where T : Entity
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var idString = controllerContext.RouteData.Values["id"].ToString();
            
            int id;
            if (int.TryParse(idString, out id))
            {
                return ObjectFactory.GetInstance<IRepository<T>>().GetById(id);
            }
            throw new InvalidOperationException("No integer value with name 'id' was found in the route data values collection.");
        }

        public bool IsMatch(Type modelType)
        {
            return modelType == typeof(T);
        }
    }
}