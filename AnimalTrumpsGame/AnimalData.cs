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
            {"Name", "Height", "Weight", "Age", "Legs", "🐸"},
            {"Name", "Height", "Weight", "Age", "Legs", "🐸"},
            {"Name", "Height", "Weight", "Age", "Legs", "🐸"},
            {"Name", "Height", "Weight", "Age", "Legs", "🐸"},
            {"Name", "Height", "Weight", "Age", "Legs", "🐸"}
        })
        { }



    }
        

}
