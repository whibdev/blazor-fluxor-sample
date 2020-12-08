using Fluxor;

namespace Flux.Wasm.Store.Counter
{
    public class CounterState
    {
        public CounterState(int count)
        {
            Count = count;
        }
        public int Count { get; }
    }

    //  this is needed to identify state in the store
    public class CounterFeatureState : Feature<CounterState>
    {
        public override string GetName() => nameof(CounterState);

        protected override CounterState GetInitialState()
        {
            return new CounterState(0);
        }
    }
}
