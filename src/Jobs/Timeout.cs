using System;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace Ssh2fa.Auth.Jobs
{
    public class Timeout
    {
    
        private short timeout;
        private Action action;

        public Timeout(Action action, short timeout)
        {
            this.timeout = timeout;
            this.action = action;
            PerformSync();
        }

        private async void PerformSync()
        {
            await Task.Run(() => Thread.Sleep(timeout));
            await Task.Run(() => action.Invoke());
        }
        
    }
}