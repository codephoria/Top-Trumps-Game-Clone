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

        public GameManager(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
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
        }
    }
}
