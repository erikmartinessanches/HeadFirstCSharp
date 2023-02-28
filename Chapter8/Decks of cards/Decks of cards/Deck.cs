using EnumsAndCollections;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;

namespace Decks_of_cards {
   class Deck : ObservableCollection<Card> {
      private static Random random = new Random();

      public Deck() {
         Reset();
      }

      public Deck(string fileName) {
         using (var sr = new StreamReader(fileName)) {
            while (!sr.EndOfStream) {
               var nextCard = sr.ReadLine();
               /*Split() takes an array of separator characters. Returns an array
                 of strings containing each part. */
               var cardParts = nextCard.Split(new char[] { ' ' });
               var suit = cardParts[2] switch {
                  "Spades" => Suits.Spades,
                  "Clubs" => Suits.Clubs,
                  "Diamonds" => Suits.Diamonds,
                  "Hearts" => Suits.Heart,
                  _ => throw new InvalidDataException($"Unrecongised card suit: {cardParts[2]}"),
               };
               var value = cardParts[0] switch {
                  "Ace" => Values.Ace,
                  "Two" => Values.Two,
                  "Three" => Values.Three,
                  "Four" => Values.Four,
                  "Five" => Values.Five,
                  "Six" => Values.Six,
                  "Seven" => Values.Seven,
                  "Eight" => Values.Eight,
                  "Nine" => Values.Nine,
                  "Ten" => Values.Ten,
                  "Jack" => Values.Jack,
                  "Queen" => Values.Queen,
                  "King" => Values.King,
                  _ => throw new InvalidDataException($"Unrecognized card value: {cardParts[0]}")
               };
               Add(new Card(value, suit));
            }
         }
      }

      public void Reset() {
         this.Clear();
         for (int suit = 0; suit < 4; suit++) {
            for (int value = 0; value < 14; value++) {
               this.Add(new Card((Values)value, (Suits)suit));
            }
         }
      }

      public Card Deal(int index) {
         Card cardToRemove = base[index];
         RemoveAt(index);
         return cardToRemove;
      }

      public void Shuffle() {
         List<Card> deckCopy = new List<Card>(this);
         Clear();
         while (deckCopy.Count > 0) {
            int index = random.Next(deckCopy.Count);
            Card card = deckCopy[index];
            deckCopy.RemoveAt(index);
            Add(card);
         }

      }

      public void Sort() {
         List<Card> sortedCards = new List<Card>(this);
         sortedCards.Sort(new CardComparerBySuitThenValue());
         Clear();
         foreach (var card in sortedCards) {
            Add(card);
         }
      }

      public void WriteCards(string fileName) {
         using (var sw = new StreamWriter(fileName)) {
            foreach (var item in this) {
               sw.WriteLine(item.Name);
            }
         }
      }
   }
}
