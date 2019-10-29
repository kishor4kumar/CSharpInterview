using System;

/* 
    Output of this program is 

    Static Constructor : Derived
    Static Constructor : Base
    Instance Constructor : Base
    Instance Constructor : Derived
    Instance Destructor : Derived
    Instance Destructor : Base
*/

namespace Advanced
{
    class CallingSquence
    {
        public CallingSquence()
        {
            var derived = new Derived();
        }
    }

    class Base
    {
        static Base()
        {
            Console.WriteLine("Static Constructor : Base");
        }

        public Base()
        {
            Console.WriteLine("Instance Constructor : Base");
        }

        ~Base()
        {
            Console.WriteLine("Instance Destructor : Base");
        }
    }

    class Derived : Base
    {
        static Derived()
        {
            Console.WriteLine("Static Constructor : Derived");
        }

        public Derived()
        {
            Console.WriteLine("Instance Constructor : Derived");
        }

        ~Derived()
        {
            Console.WriteLine("Instance Destructor : Derived");
        }
    }
}
