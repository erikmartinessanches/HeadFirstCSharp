using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using EnumsAndCollections;

namespace Decks_of_cards
{
    class CardComparerBySuitThenValue : IComparer<Card>
    {
        public int Compare([AllowNull] Card x, [AllowNull] Card y)
        {
            if (x.Suit > y.Suit)
                return 1;
            if (x.Suit < y.Suit)
                return -1;
            if (x.Value > y.Value)
                return 1;
            if (x.Value < y.Value)
                return -1;
            return 0;
        }
    }
}
