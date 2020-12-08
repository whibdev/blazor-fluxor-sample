using FluentValidation;
using Flux.Wasm.Dto;

namespace Flux.Wasm.DtoValidation
{
    public class UserDtoValidator : AbstractValidator<UserDto>
    {
        public UserDtoValidator()
        {
            RuleFor(x => x.NameFirst).NotEmpty();
            RuleFor(x => x.NameLast).NotEmpty();
            RuleFor(x => x.Email).EmailAddress();
        }
    }
}
