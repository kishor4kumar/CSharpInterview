using System;

/*
    C# | Action Delegate
    Action delegate is an in-built generic type delegate. 
    This delegate saves you from defining a custom delegate
    as shown in the below examples and make your program more
    readable and optimized. It is defined under System namespace.
    It can contain minimum 1 and maximum of 16 input parameters
    and does not contain any output parameter. The Action delegate
    is generally used for those methods which do not contain 
    any return value, or in other words, Action delegate is used
    with those methods whose return type is void. It can also 
    contain parameters of the same type or of different types.
 */

namespace Advanced
{
    class Actions
    {
        public void ShowSomethingOnConsole(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                Console.WriteLine("Going commando!!!");
            }

            Console.WriteLine(message);
        }

        public void Driver()
        {
            Action<string> action = ShowSomethingOnConsole;
            action(null);
            action("Wohooo!!!");

            Action<char> charAction = delegate(char c)
            {
                Console.WriteLine(c.ToString());
            };

            Action<int> intAction = value => Console.WriteLine(value.ToString());

            charAction('F');
            intAction(121);
        }
    }
}
