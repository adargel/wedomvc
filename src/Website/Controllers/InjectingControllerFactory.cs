using System;
using System.Web.Mvc;
using System.Web.Routing;
using StructureMap;

namespace Website.Controllers
{
    public class InjectingControllerFactory : DefaultControllerFactory
    {
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController) ObjectFactory.GetInstance(controllerType);
        }
    }
}