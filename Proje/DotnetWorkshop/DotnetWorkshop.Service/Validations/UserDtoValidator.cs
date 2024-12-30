using DotnetWorkshop.Core.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetWorkshop.Service.Validations
{
    public class UserDtoValidator:AbstractValidator<UserDto>
    {
        public UserDtoValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("{PropertyName} boş geçilemez.")
                .NotNull().WithMessage("{PropertyName} null geçilemez.")
                .MaximumLength(50).WithMessage("Kullanıcı adı en fazla 50 karakter olmalıdır.");

            RuleFor(x => x.Email).NotEmpty().WithMessage("{PropertyName} boş geçilemez.")
                .NotNull().WithMessage("{PropertyName} null geçilemez.")
                .EmailAddress().WithMessage("Geçerli bir e-posta adresi giriniz.");
        }
    }
}
