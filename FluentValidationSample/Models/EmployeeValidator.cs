using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentValidationSample.Models
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(z => z.Name).NotEmpty().WithMessage("boş yapma")
                .MinimumLength(3).WithMessage("en az 3")
                .MaximumLength(50).WithMessage("arabada 50");
            RuleFor(z => z.Adress).NotNull().MaximumLength(100);
            RuleFor(z => z.Email).EmailAddress();
            RuleFor(z => z.Age).InclusiveBetween(18, 70);
        }
    }
}
