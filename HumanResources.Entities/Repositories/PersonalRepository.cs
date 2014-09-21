using HumanResources.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Repositories
{
    internal class PersonalRepository : Repository<Employee>, IPersonalRepository 
    {
        private new HumanResourcesDbContext context
        {
            get { return base.context as HumanResourcesDbContext; }
        }

        public PersonalRepository(HumanResourcesDbContext context) : base(context)
        {
        }

        public List<EmployeeMinimal> GetMinimalList()
        {
            return this.context.Personal.OrderBy(x => x.LastName)
                .Select(x => new EmployeeMinimal { 
                    Id = x.Id, 
                    FirstName = x.FirstName, 
                    LastName = x.LastName
                })
                .ToList();
        }
    }
}
