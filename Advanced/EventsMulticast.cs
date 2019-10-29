using System;

namespace Advanced
{
    class EventsMulticast
    {
        public event EventHandler SomethingHappened;
        public EventsMulticast()
        {
            SomethingHappened += Method1;
            SomethingHappened += Method2;
            SomethingHappened += Method3;
            SomethingHappened += Method4;
            SomethingHappened += Method5;

            SomethingHappened.Invoke(new object(), null);

            //On encounter of exception at Method3, Method4 and Method5 are not called
        }

        public void Method1(object sender, EventArgs e)
        {
            Console.WriteLine("In method 1");
        }

        public void Method2(object sender, EventArgs e)
        {
            Console.WriteLine("In method 2");
        }

        public void Method3(object sender, EventArgs e)
        {
            Console.WriteLine("In method 3");
            throw new InvalidOperationException();
        }

        public void Method4(object sender, EventArgs e)
        {
            Console.WriteLine("In method 4");
        }

        public void Method5(object sender, EventArgs e)
        {
            Console.WriteLine("In method 5");
        }
    }
}
