using System;

namespace Advanced
{
    class Program
    {
        public static void Main(string[] args)
        {
            LinqBasics linqBasics = new LinqBasics();
            linqBasics.Top5FilesInADirectory();
            Console.ReadLine();
        }
    }
}
