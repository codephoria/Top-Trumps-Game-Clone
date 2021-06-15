using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalTrumpsGame
{
    static class HelperMethods
    {
        public static Random random = new Random();
        public static Card[] ShuffleCards(Card[] unshuffledCardArray)
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


        public static void DealCards(Card[] cardDeck, Player player, Player computer)
        {
            int handLength = cardDeck.Length / 2;
            player.Hand = new Card[handLength];
            computer.Hand = new Card[handLength];
            // if cardDeck.Length is uneven, last card is ignored

            for (int i = 0; i < handLength; i++)
            {
                player.Hand[i] = cardDeck[i];
                computer.Hand[i] = cardDeck[i + handLength];
            }

            // handlength 2 
            // i = 0   player(0) = cardDeck(0), computer(0) = cardDeck(2)
            // i = 1   player(1) = cardDeck(1), computer(1) = cardDeck(3)
            



            if (cardDeck.Length % 2 != 0)
            {
                
            }
        }



    }
}
