using System;
using System.Threading.Tasks;
using Ssh2fa.Auth.Jobs;

namespace Ssh2fa
{
    class Program
    {
        static Task Main(string[] args)
        {

            Action test = () => Console.WriteLine("Async");
            Action later = () => Console.WriteLine("Later");

            var interval = new Interval(test, 2000);
            var doLater = new Timeout(later, 5000);

            while(true) {}
        }
    }
}