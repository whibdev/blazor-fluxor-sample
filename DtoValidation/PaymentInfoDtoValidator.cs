using System;
using FluentValidation;
using Flux.Wasm.Dto;

namespace Flux.Wasm.DtoValidation
{
    public class PaymentInfoDtoValidator : AbstractValidator<PaymentInfoDto>
    {
        public PaymentInfoDtoValidator()
        {
            RuleFor(x => x.CardNumber).CreditCard();
            RuleFor(x => x.Cvv).Length(3).WithMessage("Invalid CVV");
            RuleFor(x => x.ExpMonth).Must(BeValid2DigitMonth).WithMessage("Month must be 2 digits");
            RuleFor(x => x.ExpYear).Must(BeValid2DigitYear).WithMessage("Year must be 2 digits");
        }

        private bool BeValid2DigitMonth(string monthValue)
        {
            if (int.TryParse(monthValue, out var monthIntValue))
            {
                return monthIntValue < 12;
            }

            return false;
        }

        private bool BeValid2DigitYear(string yearValue)
        {
            if (int.TryParse(string.Concat("20", yearValue), out var yearIntValue))
            {
                return yearIntValue >= DateTime.Now.Year;
            }
            return false;
        }
    }
}
