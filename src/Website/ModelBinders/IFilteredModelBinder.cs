using System;
using System.Web.Mvc;

namespace Website.ModelBinders
{
    public interface IFilteredModelBinder : IModelBinder
    {
        bool IsMatch(Type modelType);
    }
}