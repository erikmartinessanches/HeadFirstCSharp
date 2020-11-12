using System;

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

        }
    }

    /* Long-based (for example) enums can be made like so.*/
    enum LongTrickScore : long
    {
        Sit = 7,
        Beg = 250000025
    }
}
