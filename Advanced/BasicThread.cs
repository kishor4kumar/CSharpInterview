using System;
using System.Threading;

namespace Advanced
{
    public class BasicThread
    {
        private static readonly AutoResetEvent autoResetEvent1 = new AutoResetEvent(false);
        private static readonly AutoResetEvent autoResetEvent2 = new AutoResetEvent(false);

        public static void RunThreads()
        {
            Thread thread1 = new Thread(WriteToConsole);
            Thread thread2 = new Thread(WriteLines);

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

        }

        private static void WriteToConsole()
        {
            for(int i=0; i<20; i++)
            {
                autoResetEvent1.Set();
                Console.WriteLine("Func 1 - " + i);
                autoResetEvent2.WaitOne();
            }
        }

        private static void WriteLines()
        {
            for (int i = 0; i < 20; i++)
            {
                autoResetEvent1.WaitOne();
                Console.WriteLine("Func 2 - " + i);
                autoResetEvent2.Set();
            }
        }
    }
}
