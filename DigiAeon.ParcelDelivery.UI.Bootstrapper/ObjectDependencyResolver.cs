using DigiAeon.ParcelDelivery.Domain.Interfaces;
using DigiAeon.ParcelDelivery.Infrastructure.Repositories;
using DigiAeon.ParcelDelivery.UI.Services.Controllers;
using DigiAeon.ParcelDelivery.UI.Services.Interfaces;
using DigiAeon.ParcelDelivery.UI.Services.Interfaces.Controllers;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace DigiAeon.ParcelDelivery.UI.Bootstrapper
{
    public sealed class ObjectDependencyResolver : IDependencyResolver
    {
        public ObjectDependencyResolver(IConfig config)
        {
            Container = new Container(registry =>
            {
                registry.For<IConfig>().Use(config);

                registry.Scan(scanner =>
                {
                    scanner.AssemblyContainingType<IDeliveryCostRuleRepository>();
                    scanner.AssemblyContainingType<DeliveryCostRuleRepository>();
                    scanner.AssemblyContainingType<IDeliveryCostControllerService>();
                    scanner.AssemblyContainingType<DeliveryCostControllerService>();
                    scanner.WithDefaultConventions();
                });
            });
        }

        private IContainer Container { get; }

        public object GetService(Type serviceType)
        {
            return serviceType.IsAbstract || serviceType.IsInterface
                         ? Container.TryGetInstance(serviceType)
                         : Container.GetInstance(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return Container.GetAllInstances(serviceType).Cast<object>();
        }
    }
}
