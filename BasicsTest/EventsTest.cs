using NUnit.Framework;
using Basics.Events;

namespace BasicsTest
{
    class EventsTest
    {
        [Test]
        public void BasicEventsTest()
        {
            GameLibrary gameLibrary = new GameLibrary();
            GamerCustomer gamerCustomer = new GamerCustomer(gameLibrary);

            gameLibrary.AddGame(new Game("Uncharted", "Naughty Dog", "PS4"));
            Assert.AreEqual(0, gamerCustomer.InterestedGames.Count);

            gameLibrary.AddGame(new Game("God of War 3", "Santa Monica", "PS4"));
            Assert.AreEqual(1, gamerCustomer.InterestedGames.Count);

            gameLibrary.AddGame(new Game("Last of US", "Naughty Dog", "PS4"));
            Assert.AreEqual(1, gamerCustomer.InterestedGames.Count);

            gameLibrary.AddGame(new Game("God of War 2018", "Santa Monica", "PS4"));
            Assert.AreEqual(2, gamerCustomer.InterestedGames.Count);

            gameLibrary.AddGame(new Game("Last of US", "Naughty Dog", "PS4"));
            Assert.AreEqual(2, gamerCustomer.InterestedGames.Count);

            gameLibrary.AddGame(new Game("Odessy", "Ubisoft", "PS4"));
            Assert.AreEqual(3, gamerCustomer.InterestedGames.Count);
        }
    }
}
