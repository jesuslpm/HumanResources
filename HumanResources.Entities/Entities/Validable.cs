using FluentValidation;
using FluentValidation.Attributes;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Entities
{
    public abstract class Validable : IValidable
    {
        private static AttributedValidatorFactory validationFactory = new AttributedValidatorFactory();

        private readonly IValidator validator;

        protected Validable()
        {
            validator = validationFactory.GetValidator(this.GetType());
        }

        public string Error
        {
            get {
                var validationResults = validator.Validate(this);
                if (validationResults.Errors.Count == 0) return string.Empty;
                if (validationResults.Errors.Count == 1)
                {
                    return validationResults.Errors.Select(x => x.ErrorMessage).FirstOrDefault();
                }
                else
                {
                    return "The entity is no valid";
                }
            }
        }

        public ValidationResult Validate()
        {
            return validator.Validate(this);
        }

        public string this[string columnName]
        {
            get {
                return Validate().Errors.Where(x => x.PropertyName == columnName)
                    .Select(x => x.ErrorMessage).FirstOrDefault();
            
            }
        }
    }
}
