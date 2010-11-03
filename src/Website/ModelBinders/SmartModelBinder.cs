using System.Web.Mvc;

namespace Website.ModelBinders
{
    public class SmartModelBinder : DefaultModelBinder
    {
        readonly IFilteredModelBinder[] _filteredModelBinders;

        public SmartModelBinder(IFilteredModelBinder[] filteredModelBinders)
        {
            _filteredModelBinders = filteredModelBinders;
        }

        public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            foreach(var binder in _filteredModelBinders)
            {
                if(binder.IsMatch(bindingContext.ModelType))
                {
                    return binder.BindModel(controllerContext, bindingContext);
                }
            }
            return base.BindModel(controllerContext, bindingContext);
        }
    }
}