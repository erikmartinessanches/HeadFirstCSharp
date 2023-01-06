namespace ListOfCardsExercise {
  internal class Program {
    private static void Main(string[] args) {
      Suits mySuit = Suits.Diamonds;
      //Exercise page 455, 4th ed:
      Card myCard = new(Values.Ace, Suits.Spades);
      Console.WriteLine(myCard.Name);

      Random random = new();
      int numberBetween0and3 = random.Next(4);
      int numberBetween1and13 = random.Next(1, 14);
      int anyRandomInteger = random.Next();
      //Print the name of a random card:
      Console.WriteLine(new Card((Values)numberBetween1and13,
        (Suits)numberBetween0and3).Name);

      //Exercise page 479 (4th edition):
      //Build a console app that creates a list of cards in random order, prints them to the console, uses a
      //comparer object to sort the cards, and then prints the sorted list.
      List<Card> cards = new();
      Console.Write("Enter number of cards: ");
      if (int.TryParse(Console.ReadLine(), out int numberOfCards)) {
        for (int i = 0; i < numberOfCards; i++) {
          cards.Add(RandomCard());
        }
      }

      PrintCards(cards);
      cards.Sort(new CardComparerByValue());
      Console.WriteLine("\n... sorting the cards ...\n");
      PrintCards(cards);
    }

    private static Card RandomCard() {
      Random random = new();
      int numberBetween0and3 = random.Next(4);
      int numberBetween1and13 = random.Next(1, 14);
      return new Card((Values)numberBetween1and13, (Suits)numberBetween0and3);
    }

    private static void PrintCards(ICollection<Card> cards) {
      foreach (Card card in cards) {
        Console.WriteLine(
          $"Card suit: {card.Suit}, card value: {card.Value}, card name: {card.Name}");
      }
    }
  }
}