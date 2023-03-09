using EnumsAndCollections;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text.Json;

namespace Decks_of_cards {

   class Deck : ObservableCollection<Card> {
      private static Random random = new Random();

      public Deck() {
         Reset();
      }

      public Deck(string fileName) {
         using (var sr = new StreamReader(fileName)) {
            //Using JsonSerializer Exercise p 627, ch 10, 4th ed:
            //Alternative soultion: var jsonString = File.ReadAllText(fileName);
            var deserializedDeck = JsonSerializer.Deserialize<List<Card>>(sr.ReadToEnd());
            foreach (var card in deserializedDeck) {
               Add(card);
            }


            //while (!sr.EndOfStream) {
            //   var nextCard = sr.ReadLine();
            //   /*Split() takes an array of separator characters. Returns an array
            //     of strings containing each part. */
            //   var cardParts = nextCard.Split(new char[] { ' ' });
            //   var suit = cardParts[2] switch {
            //      "Spades" => Suits.Spades,
            //      "Clubs" => Suits.Clubs,
            //      "Diamonds" => Suits.Diamonds,
            //      "Hearts" => Suits.Heart,
            //      _ => throw new InvalidDataException($"Unrecongised card suit: {cardParts[2]}"),
            //   };
            //   var value = cardParts[0] switch {
            //      "Ace" => Values.Ace,
            //      "Two" => Values.Two,
            //      "Three" => Values.Three,
            //      "Four" => Values.Four,
            //      "Five" => Values.Five,
            //      "Six" => Values.Six,
            //      "Seven" => Values.Seven,
            //      "Eight" => Values.Eight,
            //      "Nine" => Values.Nine,
            //      "Ten" => Values.Ten,
            //      "Jack" => Values.Jack,
            //      "Queen" => Values.Queen,
            //      "King" => Values.King,
            //      _ => throw new InvalidDataException($"Unrecognized card value: {cardParts[0]}")
            //   };
            //   Add(new Card(value, suit));
            //}
         }
      }

      public void Reset() {
         this.Clear();
         for (int suit = 0; suit <= 3; suit++) {
            for (int value = 1; value <= 13; value++) {
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
         //Using JsonSerializer Exercise p 627, ch 10, 4th ed: My attempt
         using (var sw = new StreamWriter(fileName)) {
            //   foreach (var item in this) {
            sw.WriteLine(JsonSerializer.Serialize(this));
            //   }
         }
         //Alternatively: File.WriteAllText(fileName, JsonSerializer.Serialize(this));
      }
   }
}
