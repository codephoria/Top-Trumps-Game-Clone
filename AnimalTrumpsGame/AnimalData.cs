using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalTrumpsGame
{
    class AnimalData : TrumpsGameData
    {

        public string Topic { 
            get
            {
                return "Top Animals";
            }
        }

        public int NumberOfCards
        {
            get
            {
                return AnimalValues.Length;
            }
        }

        private string[] Labels =
        {
            "Name", "Height", "Weight", "Age", "Legs"
        };

        private string[,] AnimalValues = {
            {"Name", "Height", "Weight", "Age", "Legs", "🐸"},
            {"Name", "Height", "Weight", "Age", "Legs", "🐸"},
            {"Name", "Height", "Weight", "Age", "Legs", "🐸"},
            {"Name", "Height", "Weight", "Age", "Legs", "🐸"},
            {"Name", "Height", "Weight", "Age", "Legs", "🐸"}
        };

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
            if (index >= 0 && index < (AnimalValues.Rank - 1))
            {
                return AnimalValues[index, 0];
            } else
            {
                return "";
            }
            
        }

        public string GetProp1(int index)
        {
            if (index >= 0 && index < AnimalValues.Rank - 1)
            {
                return AnimalValues[index, 1];
            }
            else
            {
                return "";
            }
        }

        public string GetProp2(int index)
        {
            if (index >= 0 && index < AnimalValues.Rank - 1)
            {
                return AnimalValues[index, 2];
            }
            else
            {
                return "";
            }
        }

        public string GetProp3(int index)
        {
            if (index >= 0 && index < AnimalValues.Rank - 1)
            {
                return AnimalValues[index, 3];
            }
            else
            {
                return "";
            }
        }

        public string GetProp4(int index)
        {
            if (index >= 0 && index < AnimalValues.Rank - 1)
            {
                return AnimalValues[index, 4];
            }
            else
            {
                return "";
            }
        }

        public string GetEmoji(int index)
        {
            if (index >= 0 && index < AnimalValues.Rank - 1)
            {
                return AnimalValues[index, 5];
            }
            else
            {
                return "";
            }
        }


    }
}
