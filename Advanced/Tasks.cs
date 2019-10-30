using System;
using System.Threading;
using System.Threading.Tasks;

namespace Advanced
{
    class Tasks
    {
        public Tasks()
        {
            Parallel.Invoke(
                () => { Console.WriteLine("A Thread #{0}", Thread.CurrentThread.ManagedThreadId); },
                () => { Console.WriteLine("B Thread #{0}", Thread.CurrentThread.ManagedThreadId); },
                () => { Console.WriteLine("C Thread #{0}", Thread.CurrentThread.ManagedThreadId); },
                () => { Console.WriteLine("D Thread #{0}", Thread.CurrentThread.ManagedThreadId); },
                () => { Console.WriteLine("E Thread #{0}", Thread.CurrentThread.ManagedThreadId); },
                () => { Console.WriteLine("F Thread #{0}", Thread.CurrentThread.ManagedThreadId); }
                );

            
            Task task = new Task(() => { Console.WriteLine("Inside task"); });
            task.Start();
            Console.WriteLine("Outside Task");

            task.Wait();

        }
    }
}
