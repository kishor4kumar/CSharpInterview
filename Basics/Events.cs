using System;
using System.Collections.Generic;

namespace Basics 
{  
    namespace Events 
    {
        public struct Game
        {
            public string Name;
            public string Developer;
            public string Platform;

            public Game(string name, string developer, string platform)
            {
                Name = name;
                Developer = developer;
                Platform = platform;
            }
        }

        public class GameEventArgs : EventArgs
        {
            public Game Game;
            public GameEventArgs(Game game)
            {
                Game = game;
            }
        }

        public class GameLibrary
        {
            private readonly IList<Game> games = new List<Game>();

            public delegate void GameAddedHandler(object sender, GameEventArgs eventArgs);
            public event GameAddedHandler GameAdded;

            public void AddGame(Game game)
            {
                games.Add(game);
                GameAdded?.Invoke(this, new GameEventArgs(game));
            }
        }

        public class GamerCustomer
        {
            private readonly GameLibrary library;
            
            public IList<Game> InterestedGames
            {
                get; private set;
            }

            private GamerCustomer() { }

            public GamerCustomer(GameLibrary gameLibrary)
            {
                InterestedGames = new List<Game>();
                library = gameLibrary;
                library.GameAdded += GameAddedInLibrary;
            }

            private void GameAddedInLibrary(object sender, GameEventArgs eventArgs)
            {
                if(eventArgs.Game.Name.Contains("God of War") || eventArgs.Game.Developer == "Ubisoft")
                {
                    InterestedGames.Add(eventArgs.Game);
                }
            }
        }

    }
}
