using System;
using System.Collections.Generic;

namespace DesignPatterns.Structural
{

    class MemeLord
    {
        public MemeLord()
        {
            var persons = new List<IPerson>
            {
                new Millennials(),
                new BoomersAdapter(new Boomers()),
                new Millennials(),
                new BoomersAdapter(new Boomers())
            };

            Console.WriteLine("Dark meme reaction:");
            
            //darker meme
            foreach(var person in persons)
            {
                Console.WriteLine(person.GetMemeReaction(true));
            }

            Console.WriteLine("Normal meme reaction:");
            //normal meme
            foreach (var person in persons)
            {
                Console.WriteLine(person.GetMemeReaction(false));
            }

        }
    }

    class Boomers
    {
        public string GetCartoonReaction(bool isDark)
        {
            if(isDark)
                return "Offended";
            return "Laughing";
        }
    }

    interface IPerson
    {
        string GetMemeReaction(bool isDark);
    }

    class BoomersAdapter : IPerson
    {
        private readonly Boomers boomers;

        public BoomersAdapter(Boomers boomers)
        {
            this.boomers = boomers;
        }
        
        public string GetMemeReaction(bool isDark)
        {
            return boomers.GetCartoonReaction(isDark);
        }
    }

    class Millennials : IPerson
    {
        public string GetMemeReaction(bool isDark)
        {
            return "Laughing";
        }
    }
}
