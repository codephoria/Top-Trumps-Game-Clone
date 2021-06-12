using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalTrumpsGame
{
    class Card
    {
        public string Name { get; private set; }
        public string Prop1 { get; private set; }
        public string Prop2 { get; private set; }
        public string Prop3 { get; private set; }
        public string Prop4 { get; private set; }

        public Card(string name, string prop1, string prop2, string prop3, string prop4)
        {
            this.Name = name;
            this.Prop1 = prop1;
            this.Prop2 = prop2;
            this.Prop3 = prop3;
            this.Prop4 = prop4;
        }
    }
}
