using Flux.Wasm.Dto;
using Fluxor;

namespace Flux.Wasm.Store.Registration
{
    public class RegistrationState
    {
        public RegistrationState(RegistrationDto registrationDto)
        {
            RegistrationDto = registrationDto;
        }

        public RegistrationDto RegistrationDto { get; set; }
    }

    //  this is needed to identify state in the store
    public class FeatureState : Feature<RegistrationState>
    {
        public override string GetName() => nameof(RegistrationState);

        protected override RegistrationState GetInitialState()
        {
            return new RegistrationState(new RegistrationDto());
        }
    }
}
