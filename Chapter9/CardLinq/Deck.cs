using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CardLinq
{
    class Deck : ObservableCollection<Card>
    {
        private static Random random = new Random();

        public Deck()
        {
            Reset();
        }

        public void Reset()
        {
            this.Clear();
            for (int suit = 0; suit < 4; suit++)
            {
                for (int value = 0; value < 14; value++)
                {
                    this.Add(new Card((Values)value,(Suits)suit));
                }
            }
        }

        public Card Deal(int index)
        {
            Card cardToRemove = base[index];
            RemoveAt(index);
            return cardToRemove;
        }

        public Deck Shuffle()
        {
            List<Card> deckCopy = new List<Card>(this);
            Clear();
            while (deckCopy.Count > 0)
            {
                int index = random.Next(deckCopy.Count);
                Card card = deckCopy[index];
                deckCopy.RemoveAt(index);
                Add(card);
            }
            //Returning an instance to a shuffled Deck allows for method chaining.
            //We can call it and chain additional method calls to the result.
            return this;
        }

        public void Sort()
        {
            List<Card> sortedCards = new List<Card>(this);
            sortedCards.Sort( new CardComparerBySuitThenValue());
            Clear();
            foreach (var card in sortedCards)
            {
                Add(card);
            }
        }
    }
}
