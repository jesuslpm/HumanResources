using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Entities
{
    [Validator(typeof(EmployeeValidator))]
    public partial class Employee : Validable, IEntity
    {
        public string EmployeeCode
        {
            get
            {
                return  this.Id.ToString("000000");
            }
        }
    }

    internal class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            this.RuleFor(x => x.FirstName)
                .NotEmpty()
                .Length(5, 128)
                .WithLocalizedName(() => Properties.Resources.FirstName);

            this.RuleFor(x => x.LastName)
                .NotEmpty().Length(5, 256)
                .WithLocalizedName( () => Properties.Resources.LastName);

            this.RuleFor(x => x.Address)
                .NotEmpty().Length(5, 256)
                .WithLocalizedName( () => Properties.Resources.Address);

            this.RuleFor(x => x.CellPhoneNumber)
                .Length(6, 16)
                .WithLocalizedName(() => Properties.Resources.CellPhoneNumber)
                .Unless(x => string.IsNullOrEmpty(x.CellPhoneNumber));

            this.RuleFor(x => x.HomePhoneNumber)
                .Length(6, 16)
                .WithLocalizedName(() => Properties.Resources.HomePhoneNumber)
                .Unless(x => string.IsNullOrEmpty(x.HomePhoneNumber));
        }
    }
}
