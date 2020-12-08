using Flux.Wasm.Dto;
using Fluxor;

namespace Flux.Wasm.Store.Registration
{
    public static class Reducer
    {
        [ReducerMethod]
        public static RegistrationState OnUpdateRegistration(RegistrationState registrationState, UpdateRegistrationDetailAction action)
        {
            return registrationState;
        }

        [ReducerMethod]
        public static RegistrationState OnUpdateUser(RegistrationState registrationState, UpdateUserAction action)
        {
            return new RegistrationState(new RegistrationDto{CompanyDetail = registrationState.RegistrationDto.CompanyDetail, PaymentInfo = registrationState.RegistrationDto.PaymentInfo, User = action.User, CurrentStep = registrationState.RegistrationDto.CurrentStep });
        }

        [ReducerMethod]
        public static RegistrationState OnUpdateCompanyDetail(RegistrationState registrationState, UpdateCompanyDetailAction action)
        {
            return new RegistrationState(new RegistrationDto { CompanyDetail = action.CompanyDetail, PaymentInfo = registrationState.RegistrationDto.PaymentInfo, User = registrationState.RegistrationDto.User, CurrentStep = registrationState.RegistrationDto.CurrentStep });
        }

        [ReducerMethod]
        public static RegistrationState OnUpdatePaymentInfo(RegistrationState registrationState, UpdatePaymentInfoAction action)
        {
            return new RegistrationState(new RegistrationDto { CompanyDetail = registrationState.RegistrationDto.CompanyDetail, PaymentInfo = action.PaymentInfo, User = registrationState.RegistrationDto.User, CurrentStep = registrationState.RegistrationDto.CurrentStep });
        }

        [ReducerMethod]
        public static RegistrationState OnUpdateRegistrationStep(RegistrationState registrationState, UpdateCurrentStepAction action)
        {
            return new RegistrationState(new RegistrationDto { CompanyDetail = registrationState.RegistrationDto.CompanyDetail, PaymentInfo = registrationState.RegistrationDto.PaymentInfo, User = registrationState.RegistrationDto.User, CurrentStep = action.Step});
        }
    }
}
