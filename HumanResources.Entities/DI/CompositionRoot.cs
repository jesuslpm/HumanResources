using HumanResources.Entities;
using HumanResources.Repositories;
using LightInject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.DI
{
    public class CompositionRoot : ICompositionRoot
    {
        public void Compose(IServiceRegistry serviceRegistry)
        {
            serviceRegistry.Register<HumanResourcesDbContext>(new PerScopeLifetime());
            serviceRegistry.Register<IPersonalRepository, PersonalRepository>(new PerScopeLifetime());
        }
    }
}
