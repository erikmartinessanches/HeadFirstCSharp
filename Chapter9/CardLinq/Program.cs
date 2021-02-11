using System;
using System.Linq;

namespace CardLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var deck = new Deck().Shuffle().Take(16);

            /*Split the cards into groups using card.Suit as a Key to split on.
            The group clause enumerates the sequence, creating new
            groups as it gets to each new key. So the groups
            are in the same order as the first occurrences of
            the Suits that were in the random sample.*/
            var grouped =
                from card in deck
                group card by card.Suit
                into suitGroup
                orderby suitGroup.Key descending
                select suitGroup;
            foreach (var group in grouped)
            {
                //Each group has a Key property that returns its key, in this case a suit.
                Console.WriteLine(@$"Group: {group.Key}
Count: {group.Count()}
Minimum: {group.Min()}
Maximum: {group.Max()}");
            }
        }
    }
}
