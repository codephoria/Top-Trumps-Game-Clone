using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalTrumpsGame
{
    class AnimalData : StandardGameData
    {
        public AnimalData() : base(
            "Top Animals",
            new string[] {
                "Name", "Height", "Weight", "Age", "Legs"
            },
            new string[,] {
            {"Frog", "Height", "Weight", "Age", "4", "🐸"},
            {"Spider", "Height", "Weight", "Age", "8", "🕷"},
            {"Zebra", "Height", "Weight", "Age", "4", "🦓"},
            {"Chicken", "Height", "Weight", "Age", "2", "🐔"},
            {"Snake", "Height", "Weight", "Age", "0", "🐍"}
        })
        { }



    }
        

}
