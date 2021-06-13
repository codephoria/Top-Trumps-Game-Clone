using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalTrumpsGame
{
    class GameManager
    {
        MainWindow mainWindow;
        private TrumpsGameData gameData;
        private Card[] cardDeck;

        public GameManager(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
        }


        public void StartNewGame(TrumpsGameData gameData)
        {
            this.gameData = gameData;
            mainWindow.ChangeTitle(gameData.Topic);
            SetUpGame();
        }

        private void SetUpGame()
        {
            cardDeck = GameDataAdapter.CreateGameCards(gameData);
        }
    }
}
