using System;
using Domain.Model;
using StructureMap.Configuration.DSL;
using StructureMap.Graph;
using Website.ModelBinders;

namespace Website.IoC.Conventions
{
    public class EntityModelBinderConventions : IRegistrationConvention
    {
        public void Process(Type type, Registry registry)
        {
            if (!type.IsSubclassOf(typeof(Entity))) return;

            var openQueryModelBinder = typeof (QueryableModelBinder<>);
            var closedQueryModelBinder = openQueryModelBinder.MakeGenericType(type);

            var openIdToEntityModelBinder = typeof (IdToEntityModelBinder<>);
            var closedIdToEntityModelBinder = openIdToEntityModelBinder.MakeGenericType(type);

            registry.For(typeof(IFilteredModelBinder)).Use(closedQueryModelBinder);
            registry.For(typeof(IFilteredModelBinder)).Use(closedIdToEntityModelBinder);
        }
    }
}