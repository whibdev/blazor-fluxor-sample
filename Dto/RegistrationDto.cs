using System;
using Flux.Wasm.Components.Registration;

namespace Flux.Wasm.Dto
{
    public class RegistrationDto
    {
        public UserDto User { get; set; } = new UserDto();
        public CompanyDetailDto CompanyDetail { get; set; } = new CompanyDetailDto();
        public PaymentInfoDto PaymentInfo { get; set; } = new PaymentInfoDto();
        public bool IsOnConfirmationStep { get; set; }
        public RegistrationStepEnum CurrentStep { get; set; }

        public RegistrationStepEnum NextRegistrationStep
        {
            get
            {
                if (!User.IsStepComplete)
                    return RegistrationStepEnum.UserForm;
                if (!CompanyDetail.IsStepComplete)
                    return RegistrationStepEnum.CompanyDetailForm;
                if (!PaymentInfo.IsStepComplete)
                    return RegistrationStepEnum.PaymentInfoForm;

                return IsOnConfirmationStep ? RegistrationStepEnum.Confirmation : RegistrationStepEnum.Complete;
            }
        }

        //  if step is greater than requested step > ensure current and steps between are valid before moving ahead
        public bool IsRequestedNavigationStepOk(RegistrationStepEnum requestedStep)
        {
            if (CurrentStep > requestedStep)
            {
                return true;
            }
            
            switch (requestedStep)
            {
                case RegistrationStepEnum.UserForm:
                    return true;
                case RegistrationStepEnum.CompanyDetailForm:
                    return User.IsStepComplete;
                case RegistrationStepEnum.PaymentInfoForm:
                    return User.IsStepComplete && PaymentInfo.IsStepComplete;
                case RegistrationStepEnum.Confirmation:
                    return User.IsStepComplete && CompanyDetail.IsStepComplete && PaymentInfo.IsStepComplete;
                case RegistrationStepEnum.Complete:
                    return User.IsStepComplete && CompanyDetail.IsStepComplete && PaymentInfo.IsStepComplete && IsOnConfirmationStep;
                default:
                    throw new ArgumentOutOfRangeException(nameof(requestedStep), requestedStep, null);
            }
        }
    }

    public enum RegistrationStepEnum
    {
        UserForm,
        CompanyDetailForm,
        PaymentInfoForm,
        Confirmation,
        Complete
    }
}
