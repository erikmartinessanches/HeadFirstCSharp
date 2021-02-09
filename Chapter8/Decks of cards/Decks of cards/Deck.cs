﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Resources;
using System.Text;
using EnumsAndCollections;

namespace Decks_of_cards
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

        public void Shuffle()
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
