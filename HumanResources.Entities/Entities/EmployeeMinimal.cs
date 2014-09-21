using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Entities
{
    public class EmployeeMinimal : IIDentity
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmployeeCode
        {
            get
            {
                return this.Id.ToString("000000");
            }
        }
       

    }
}
