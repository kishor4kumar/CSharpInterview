using System;

namespace Advanced
{
    class Predicates
    {
        public bool ShowSomethingOnConsole(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                Console.WriteLine("Going commando!!!");
                return false;
            }

            Console.WriteLine(message);
            return true;
        }

        public void Driver()
        {
            Predicate<string> predicate = ShowSomethingOnConsole;
            ShowSomethingOnConsole("Assasin's Creed");

            Predicate<int> intPredicate = delegate(int value)
            {
                Console.WriteLine(value);
                return true;
            };

            Predicate<char> charPredicate = c => {
                                                    Console.WriteLine(c);
                                                    return false;
                                                  };

            intPredicate(1);
        }

    }
}
