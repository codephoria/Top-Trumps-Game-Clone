using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalTrumpsGame
{
    class StandardGameData : ITrumpsGameData
    {
        private string topic;
        public string Topic
        {
            get
            {
                return topic;
            }
        }

        public int NumberOfCards
        {
            get
            {
                return CardValues.Rank;
            }
        }

        private string[] Labels =
        {
            "Label for specific card name", "Label for first value", "Label for second value", "Label for third value", "Label for fourth value"
        };

        private string[,] CardValues = {
            {"Name", "First value", "Second value", "Third value", "Fourth value", "🐸"}, // values for first card
            {"Name", "Height", "Weight", "Age", "Legs", "🐸"}, // values for second card (examples)
            // add as many cards as you wish
        };

        public StandardGameData(string topic, string[] labels, string[,] cardvalues)
        {
            this.topic = topic;
            Labels = labels;
            CardValues = cardvalues;
        }

        public string GetLabel(int index)
        {
            if (index >= 0 && index < Labels.Length - 1)
            {
                return Labels[index];
            }
            else
            {
                return "";
            }
        }

        public string GetName(int index)
        {
            if (index >= 0 && index < (CardValues.Rank - 1))
            {
                return CardValues[index, 0];
            }
            else
            {
                return "";
            }

        }

        public string GetProp1(int index)
        {
            if (index >= 0 && index < CardValues.Rank - 1)
            {
                return CardValues[index, 1];
            }
            else
            {
                return "";
            }
        }

        public string GetProp2(int index)
        {
            if (index >= 0 && index < CardValues.Rank - 1)
            {
                return CardValues[index, 2];
            }
            else
            {
                return "";
            }
        }

        public string GetProp3(int index)
        {
            if (index >= 0 && index < CardValues.Rank - 1)
            {
                return CardValues[index, 3];
            }
            else
            {
                return "";
            }
        }

        public string GetProp4(int index)
        {
            if (index >= 0 && index < CardValues.Rank - 1)
            {
                return CardValues[index, 4];
            }
            else
            {
                return "";
            }
        }

        public string GetEmoji(int index)
        {
            if (index >= 0 && index < CardValues.Rank - 1)
            {
                return CardValues[index, 5];
            }
            else
            {
                return "";
            }
        }


    }
}

