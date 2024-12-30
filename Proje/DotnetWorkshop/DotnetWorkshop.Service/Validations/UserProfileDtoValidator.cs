using DotnetWorkshop.Core.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetWorkshop.Service.Validations
{
    public class UserProfileDtoValidator : AbstractValidator<UserProfileDto>
    {
        public UserProfileDtoValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("{PropertyName} boş geçilemez.")
                .NotNull().WithMessage("{PropertyName} null geçilemez.");

            RuleFor(x => x.LastName).NotEmpty().WithMessage("{PropertyName} boş geçilemez.")
         .NotNull().WithMessage("{PropertyName} null geçilemez.");
        }
    }
}
