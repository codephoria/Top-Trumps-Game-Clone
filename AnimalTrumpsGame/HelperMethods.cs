using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalTrumpsGame
{
    static class HelperMethods
    {
        public static Random random = new Random();
        public static List<Card> ShuffleCards(List<Card> unshuffledCardArray)
        {
            List<Card> cardArray = unshuffledCardArray;

            // Knuth/Fisher-Yates shuffle
            for (int i = cardArray.Count - 1; i > 0; i--)
            {
                int randomIndex = random.Next(0, i + 1);

                Card temp = cardArray[i];
                cardArray[i] = cardArray[randomIndex];
                cardArray[randomIndex] = temp;
            }
            return cardArray;
        }


        public static void DealCards(List<Card> cardDeck, Player player, Player computer)
        {
            int handLength = cardDeck.Count / 2;
            player.Hand = new List<Card>();
            computer.Hand = new List<Card>();
            // if cardDeck.Length is uneven, last card is ignored

            for (int i = 0; i < handLength; i++)
            {
                player.Hand.Add(cardDeck[i]);
                computer.Hand.Add(cardDeck[i + handLength]);
            }

            // handlength 2 
            // i = 0   player(0) = cardDeck(0), computer(0) = cardDeck(2)
            // i = 1   player(1) = cardDeck(1), computer(1) = cardDeck(3)
            
        }



    }
}
