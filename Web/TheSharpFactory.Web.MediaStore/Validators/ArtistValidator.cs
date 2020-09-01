using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheSharpFactory.Entity.MainDb.Media;

namespace TheSharpFactory.Web.Validators
{
    public class ArtistValidator : AbstractValidator<Artist>
    {
        public ArtistValidator()
        {
            RuleFor(c => c.Name).NotEmpty();
        }
    }
}
