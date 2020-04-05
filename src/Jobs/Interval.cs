using System;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace Ssh2fa.Auth.Jobs
{
    public class Interval
    {

        private short timeout;
        private Action action;

        public Interval(Action action, short timeout)
        {
            this.action = action;
            this.timeout = timeout;
            PerformSync();
        }

        private async void PerformSync()
        {
            while (true)
            {
                await Task.Run(() => action.Invoke());
                await Task.Run(() => Thread.Sleep(timeout));
            }
        }
        
    }
}