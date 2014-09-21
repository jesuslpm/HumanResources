using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Entities
{
    public interface IValidable : IDataErrorInfo
    {
        ValidationResult Validate();
    }
}
