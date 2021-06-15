using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalTrumpsGame
{
    class GameManager
    {
        MainWindow mainWindow;
        private ITrumpsGameData gameData;
        private Card[] cardDeck;

        bool yourTurn = false;
        int numberOfPlayers = 2;

        Player player;
        Player computer;

        public static Random random = new Random();

        public GameManager(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            player = new Player();
            computer = new Player();
        }


        public void StartNewGame(ITrumpsGameData gameData)
        {
            this.gameData = gameData;
            mainWindow.ChangeTitle(gameData.Topic);
            SetUpGame();
        }

        private void SetUpGame()
        {
            cardDeck = GameDataAdapter.CreateGameCards(gameData);
            
            ShuffleCards(cardDeck);

            // random player has first turn
            yourTurn = Convert.ToBoolean(random.Next(2));

            

           
            
        }

        private Card[] ShuffleCards (Card[] unshuffledCardArray)
        {
            Card[] cardArray = unshuffledCardArray;

            // Knuth/Fisher-Yates shuffle
            for (int i = cardArray.Length - 1; i > 0; i--)
            {
                int randomIndex = random.Next(0, i + 1);

                Card temp = cardArray[i];
                cardArray[i] = cardArray[randomIndex];
                cardArray[randomIndex] = temp;
            }
            return cardArray;
        }
    }
}
