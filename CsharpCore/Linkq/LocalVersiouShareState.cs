using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCore.Linkq
{
    public class LocalVersiouShareState
    {
        bool _done = false;
  
        public void Local()
        {
            new Thread(Go).Start(); // Call Go() on a new thread
           // Go(); // Call Go() on the main thread
           
            new Thread (action).Start();

            Thread t = new Thread(() => Print("Hello from t!"));
            t.Start();
        }

        void Print(string message) => Console.WriteLine(message);

        public void Go()
        {
            // Declare and use a local variable - 'cycles'
            for (int cycles = 0; cycles < 5; cycles++) Console.Write('?');
        }

       
        ThreadStart action = () =>
        {
            bool done = false;
            if (!done) { done = true; Console.WriteLine("Done"); }
        };
       
    }
}
