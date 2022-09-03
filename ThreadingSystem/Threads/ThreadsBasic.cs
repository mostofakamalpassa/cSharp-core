using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadingSystem.Threads
{
    public class ThreadsBasic
    {
        public void ThreadingInitializer()
        {
            Thread t = new Thread(WriteY);
            
            t.Start();

            for(int i = 0; i<1000; i++)
            {
                Console.Write("X");
            }
        }

        public void WriteY()
        {
            for(int i = 0; i< 1000; i++)
            {
                Console.Write("y");
            }
        }

        public void ThreadJoinSleap()
        {
            Thread thread = new Thread(Go);
           
            
            //Thread.Sleep(TimeSpan.FromHours(1)); // Sleep for 1 hour
            Thread.Sleep(10000);
            thread.Start();
            thread.Join();

        }

        void Go() { for (int i = 0; i < 1000; i++) Console.Write("y"); }
    }
}
