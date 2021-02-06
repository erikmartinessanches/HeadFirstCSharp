using System;
using System.Collections;
using System.Collections.Generic;

namespace EnumsAndCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Suits mySuit = Suits.Diamonds;
            LongTrickScore myScore = LongTrickScore.Beg;
            Console.WriteLine((long)myScore); //Casts to the enum's underlying value.

            //Exercise page 455:
            Card myCard = new Card(Values.Ace, Suits.Spades);
            Console.WriteLine(myCard.Name);
            Random random = new Random();
            int numberBetween0and3 = random.Next(4);
            int numberBetween1and13 = random.Next(1, 14);
            int anyRandomInteger = random.Next();
            //Print the name of a random card:
            Console.WriteLine(new Card((Values)numberBetween1and13, (Suits)numberBetween0and3).Name);

            //Exercise page 479 (4th edition):
            //Build a console app that creates a list of cards in random order, prints them to the console, uses a
            //comparer object to sort the cards, and then prints the sorted list.
            List<Card> cards = new List<Card>();
            Console.Write("Enter number of cards: ");
            if (int.TryParse(Console.ReadLine(), out int numberOfCards))
                for (int i = 0; i < numberOfCards; i++)
                    cards.Add(RandomCard());
            PrintCards(cards);
            cards.Sort(new CardComparerByValue());
            Console.WriteLine("\n... sorting the cards ...\n");
            PrintCards(cards);



            //Comparing ducks, page 474.
            Console.WriteLine("\n... Comparing ducks (p. 475) ...\n");
            List<Duck> ducks = new List<Duck>() {
                new Duck() { Kind = KindOfDuck.Mallard, Size = 17 },
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 18 },
                new Duck() { Kind = KindOfDuck.Loon, Size = 14 },
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 11 },
                new Duck() { Kind = KindOfDuck.Mallard, Size = 14 },
                new Duck() { Kind = KindOfDuck.Loon, Size = 13 },
            };
            Console.WriteLine("Sorting ducks using CompareTo(Duck other) on Duck : IComparable<Duck>");
            ducks.Sort();
            PrintDucks(ducks);

            DuckComparer comparer = new DuckComparer();
            Console.WriteLine("Sorting ducks using Compare(Duck x, Duck, y) on DuckComparer : IComparer<Duck>");
            Console.WriteLine("Sorting by kind then size");
            comparer.SortBy = SortCriteria.KindThenSize;
            ducks.Sort(comparer);
            PrintDucks(ducks);
            Console.WriteLine("Sorting by size then kind");
            comparer.SortBy = SortCriteria.SizeThenKind;
            ducks.Sort(comparer);
            PrintDucks(ducks);

        }

        public static void PrintDucks(List<Duck> ducks)
        {
            foreach (var duck in ducks)
            {
                Console.WriteLine($"{duck.Size} inch {duck.Kind}");
            }
        }

        static Card RandomCard()
        {
            Random random = new Random();
            int numberBetween0and3 = random.Next(4);
            int numberBetween1and13 = random.Next(1, 14);
            return new Card((Values)numberBetween1and13, (Suits)numberBetween0and3);
        }

        static void PrintCards(ICollection<Card> cards)
        {
            foreach (var card in cards)
            {
                Console.WriteLine($"Card suit: {card.Suit}, card value: {card.Value}, card name: {card.Name}");
            }
        }
    }

    /* Long-based (for example) enums can be made like so.*/
    enum LongTrickScore : long
    {
        Sit = 7,
        Beg = 250000025
    }
}
