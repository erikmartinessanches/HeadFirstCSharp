using System;
using System.Collections.Generic;
using System.Text;

namespace EnumsAndCollections
{
    class Card
    {
        public Values Value { get; private set; }
        public Suits Suit { get; private set; }
        public string  Name => $"{Value} of {Suit}";

        public Card(Values value, Suits suit)
        {
            Value = value;
            Suit = suit;
        }
    }


}
