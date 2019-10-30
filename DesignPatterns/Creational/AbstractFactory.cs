/*
Abstract Factory is a creational design pattern that lets you produce 
families of related objects without specifying their concrete classes.
*/

using System;

namespace DesignPatterns.Creational
{
    public class AbstractFactory
    {
        public AbstractFactory()
        {
            Console.WriteLine("Enter Option: 1. Windows 2. Linux");
            uint os = Convert.ToUInt32(Console.ReadLine());

            IFactory factory;

            if(os == 1)
            {
                factory = new WindowsFactory();
            }
            else if(os == 2)
            {
                factory = new LinuxFactory();
            }
            else
            {
                throw new Exception("Unsupported OS");
            }

            var clientApplication = new ClientApplication(factory);
        }
    }

    interface IFactory
    {
        void LaunchTextEditor();
    }

    class WindowsFactory : IFactory
    {
        public void LaunchTextEditor()
        {
            Console.WriteLine("Open Notepad");
        }
    }

    class LinuxFactory : IFactory
    {
        public void LaunchTextEditor()
        {
            Console.WriteLine("Open GNU Text Editor");
        }
    }

    class ClientApplication
    {
        private readonly IFactory factory;

        public ClientApplication(IFactory factory)
        {
            this.factory = factory;
            factory.LaunchTextEditor();
        }
    }
}
