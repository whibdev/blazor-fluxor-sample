using Flux.Wasm.Dto;

namespace Flux.Wasm.Store.Registration
{
    public class UpdateRegistrationDetailAction
    {
        public RegistrationDto RegistrationDto { get; set; }
    }
    public class UpdateUserAction
    {
        public UserDto User { get; set; }
    }
    public class UpdatePaymentInfoAction
    {
        public PaymentInfoDto PaymentInfo { get; set; }
    }
    public class UpdateCompanyDetailAction
    {
        public CompanyDetailDto CompanyDetail { get; set; }
    }
    public class UpdateCurrentStepAction
    {
        public RegistrationStepEnum Step { get; set; }
    }
}
