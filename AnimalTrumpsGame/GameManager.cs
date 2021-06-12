using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalTrumpsGame
{
    class GameManager
    {
        private TrumpsGameData gameData;
        private Card[] cardDeck;


        public void StartNewGame(TrumpsGameData gameData)
        {
            this.gameData = gameData;
            SetUpGame();
        }

        private void SetUpGame()
        {
            cardDeck = GameDataAdapter.CreateGameCards(gameData);
        }
    }
}
