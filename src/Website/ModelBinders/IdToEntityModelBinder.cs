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
            var idValue = controllerContext.RouteData.Values["id"];
            if(idValue == null)
                throw new InvalidOperationException(
                    string.Format("Cannot bind to entity {0} because no id was found in the route data values collection.", 
                    typeof(T).Name));

            int id;
            if (int.TryParse(idValue.ToString(), out id))
            {
                return ObjectFactory.GetInstance<IRepository<T>>().GetById(id);
            }
            throw new InvalidOperationException(string.Format(
                "Cannot bind to {0} because no integer value with name 'id' was found in the route data values collection.", 
                typeof(T).Name));
        }

        public bool IsMatch(Type modelType)
        {
            return modelType == typeof(T);
        }
    }
}