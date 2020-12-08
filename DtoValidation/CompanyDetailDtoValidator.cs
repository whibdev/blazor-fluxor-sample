using FluentValidation;
using Flux.Wasm.Dto;

namespace Flux.Wasm.DtoValidation
{
    public class CompanyDetailDtoValidator : AbstractValidator<CompanyDetailDto>
    {
        public CompanyDetailDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
        }
    }
}
