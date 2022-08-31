using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCore.Linkq
{
  public  class ThreadSafe
    {
        static bool _done;
        static readonly object _locker = new object();
        static void Main()
        {
            new Thread(Go).Start();
            Go();
        }
        static void Go()
        {
            lock (_locker)
            {
                if (!_done) { Console.WriteLine("Done"); _done = true; }
            }
        }
    }
}
