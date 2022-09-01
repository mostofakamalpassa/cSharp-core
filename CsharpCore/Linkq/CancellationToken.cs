using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCore.Linkq
{
    internal class CancellationToken
    {
        public bool IsCancellationRequested { get; private set; }
        public void Cancel() { IsCancellationRequested = true; }
        public void ThrowIfCancellationRequested()
        {
            if (IsCancellationRequested)
                throw new OperationCanceledException();
        }

        async Task Foo(CancellationToken cancellationToken)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                await Task.Delay(1000);
                cancellationToken.ThrowIfCancellationRequested();
            }
        }
    }
}
