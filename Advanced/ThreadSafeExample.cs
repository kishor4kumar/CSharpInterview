using System;
using System.Threading;

namespace Advanced
{
    class ThreadSafeExample
    {
        readonly Random random = new Random();
        int num1, num2;

        public void Driver()
        {
            Thread thread1 = new Thread(DoThings);
            Thread thread2 = new Thread(DoThings);
            
            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();
        }

        private void DoThings()
        {
            for(int i=0; i<999999; i++)
            {
                lock (this)
                {
                    num1 = i;
                    num2 = i+1;
                    num1 = num1 / (num2 - num1); // if not thread safe, this will raise DivideByZero exception
                                                    // there is possibility that num2 == num1
                }
            }
        }

    }
}
