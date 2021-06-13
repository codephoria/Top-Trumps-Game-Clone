using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalTrumpsGame
{
    interface ITrumpsGameData
    {
        string Topic { get; }

        int NumberOfCards { get; }

        string GetLabel(int index);
        string GetName(int index);
        string GetProp1(int index);
        string GetProp2(int index);
        string GetProp3(int index);
        string GetProp4(int index);
        string GetEmoji(int index);


    }
}
