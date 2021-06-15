using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalTrumpsGame
{
    static class GameDataAdapter
    {
        public static List<Card> CreateGameCards(ITrumpsGameData gameData)
        {
            int numberOfCards = gameData.NumberOfCards;
            List<Card> cards = new List<Card>();

            for (int i = 0; i < numberOfCards; i++)
            {
                Card card = new Card(gameData.GetEmoji(i), gameData.GetName(i), gameData.GetProp1(i), gameData.GetProp2(i), gameData.GetProp3(i), gameData.GetProp4(i));
                cards.Add(card);
            }


            return cards;
        }
    }
}
