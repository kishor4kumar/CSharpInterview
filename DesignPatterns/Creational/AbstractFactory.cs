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

    interface IButton
    {
        void Click();
        void Render();
    }

    class WindowsButton : IButton
    {
        public void Click()
        {
            Console.WriteLine("Windows Click");
        }

        public void Render()
        {
            Console.WriteLine("Windows Render");
        }
    }

    class LinuxButton : IButton
    {
        public void Click()
        {
            Console.WriteLine("Linux Click");
        }

        public void Render()
        {
            Console.WriteLine("Linux Render");
        }
    }

    interface IFactory
    {
        IButton GetUIButton();
    }

    class WindowsFactory : IFactory
    {
        public IButton GetUIButton()
        {
            return new WindowsButton();
        }
    }

    class LinuxFactory : IFactory
    {
        public IButton GetUIButton()
        {
            return new LinuxButton();
        }
    }

    class ClientApplication
    {
        private readonly IButton button;

        public ClientApplication(IFactory factory)
        {
            button = factory.GetUIButton();
        }

        public void DrawUI()
        {
            button.Render();
        }

        public void ClickUI()
        {
            button.Click();
        }
    }
}
