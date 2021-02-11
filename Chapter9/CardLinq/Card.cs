using System;
using System.Collections.Generic;
using System.Text;

namespace CardLinq
{
    class Card : IComparable<Card>
    {
        public Values Value { get; private set; }
        public Suits Suit { get; private set; }
        public string Name => $"{Value} of {Suit}";

        public Card(Values value, Suits suit)
        {
            Value = value;
            Suit = suit;
        }

        public int CompareTo(Card other)
        {
            return new CardComparerBySuitThenValue().Compare(this, other);
        }

        public override string ToString()
        {
            return Name;
        }
    }


}
