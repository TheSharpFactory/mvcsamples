using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheSharpFactory.Entity.MainDb.Media;

namespace TheSharpFactory.Web.Validators
{
    public class PlaylistValidator : AbstractValidator<Playlist>
    {
        public PlaylistValidator()
        {
            RuleFor(c => c.Name).NotEmpty();
        }
    }
}
