using System;
using System.Threading;
using System.Threading.Tasks;

namespace BattleNetApi.Client.Utilities
{
    public class TimeThrottledQueue
    {
        private readonly TimeSpan _maxPeriod;
        private readonly SemaphoreSlim _throttleActions;
        private readonly SemaphoreSlim _throttlePeriod;

        public TimeThrottledQueue(int maxActions, TimeSpan maxPeriod)
        {
            _maxPeriod = maxPeriod;
            _throttleActions = new SemaphoreSlim(maxActions, maxActions);
            _throttlePeriod = new SemaphoreSlim(maxActions, maxActions);
        }

        public Task<T> Enqueue<T>(Func<T> action, CancellationToken cancellationToken)
        {
            return _throttleActions.WaitAsync(cancellationToken).ContinueWith<T>(t =>
            {
                try
                {
                    _throttlePeriod.Wait(cancellationToken);
                    Task.Delay(_maxPeriod, cancellationToken).ContinueWith(dt =>
                    {
                        _throttlePeriod.Release(1);
                    }, cancellationToken);

                    return action();
                }
                finally
                {
                    _throttleActions.Release(1);
                }
            }, cancellationToken);
        }
    }
}
