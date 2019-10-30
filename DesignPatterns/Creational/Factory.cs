using System;

namespace DesignPatterns
{
    class Factory
    {
        public Factory()
        {
            var factory = new UIFactory();
            var clientApplication = new ClientApplication(factory);
            clientApplication.DrawUI();
            clientApplication.ClickUI();
        }
    }

    interface IButton
    {
        void Click();
        void Render();
    }

    class CustomButton : IButton
    {
        public void Click()
        {
            Console.WriteLine("Custom button Click");
        }

        public void Render()
        {
            Console.WriteLine("Custom button Render");
        }
    }

    class UIFactory
    {
        public IButton GetUIButton()
        {
            return new CustomButton();
        }
    }

    class ClientApplication
    {
        private readonly IButton button;

        public ClientApplication(UIFactory factory)
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
