using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheSharpFactory.Entity.MainDb.People;

namespace TheSharpFactory.Web.Validators
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.FirstName).NotEmpty().WithName("First Name");
            //RuleFor(c => c.FirstName).NotEmpty().WithName("First Name");
            RuleFor(c => c.LastName).NotEmpty();
            //RuleFor(c => c.SupportRepId).GreaterThan(10);
        }
    }
}
