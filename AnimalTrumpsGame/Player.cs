using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalTrumpsGame
{
    class Player
    {
        private Card[] hand;

        public Card[] Hand
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
