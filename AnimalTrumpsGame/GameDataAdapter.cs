using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalTrumpsGame
{
    static class GameDataAdapter
    {
        public static Card[] CreateGameCards(ITrumpsGameData gameData)
        {
            int numberOfCards = gameData.NumberOfCards;
            Card[] cards = new Card[numberOfCards];

            for (int i = 0; i < numberOfCards - 1; i++)
            {
                Card card = new Card(gameData.GetEmoji(i), gameData.GetName(i), gameData.GetProp1(i), gameData.GetProp2(i), gameData.GetProp3(i), gameData.GetProp4(i));
                cards[i] = card;
            }


            return cards;
        }
    }
}
