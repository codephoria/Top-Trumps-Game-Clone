using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalTrumpsGame
{
    class Player
    {
        private List<Card> hand;

        public List<Card> Hand
        {
            set
            {
                hand = value;
            }

            get
            {
                return hand;
            }
        }
    }
}
