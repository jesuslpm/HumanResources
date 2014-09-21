using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Entities
{
    public class ValidationException : Exception
    {

        public readonly ValidationResult ValidationResults;

        public ValidationException(ValidationResult validationResults): base()
        {
            this.ValidationResults = validationResults;
        }

    }
}
