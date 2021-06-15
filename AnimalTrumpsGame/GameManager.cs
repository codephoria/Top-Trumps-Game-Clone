using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace AnimalTrumpsGame
{
    class GameManager
    {
        MainWindow mainWindow;
        private ITrumpsGameData gameData;
        private List<Card> cardDeck;

        private bool yourTurn = false;
        static int numberOfPlayers = 2;

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
            HelperMethods.ShuffleCards(cardDeck);
            HelperMethods.DealCards(cardDeck, player, computer);

            // random player has first turn
            yourTurn = Convert.ToBoolean(random.Next(2));

            

           
            
        }

        
    }
}
