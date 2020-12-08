using Fluxor;

namespace Flux.Wasm.Store.Counter
{
    public static class CounterReducer
    {
        [ReducerMethod]
        public static CounterState OnAddCounter(CounterState state, AddCounterAction action)
        {
            return new CounterState(state.Count + action.Count);
        }

        [ReducerMethod]
        public static CounterState OnAdd2Counter(CounterState state, AddCounter2Action action)
        {
            return new CounterState(state.Count + 2);
        }

        [ReducerMethod]
        public static CounterState OnSubstractCounter(CounterState state, SubtractCounterAction action)
        {
            return new CounterState(state.Count - action.Count);
        }
    }
}
