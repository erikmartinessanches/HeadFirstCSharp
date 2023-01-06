//Exercise page 455, 4th ed:

namespace ListOfCardsExercise {
  internal class Card {
    public Values Value { get; private set; }
    public Suits Suit { get; private set; }
    public string Name => $"{Value} of {Suit}";

    public Card(Values value, Suits suit) {
      Value = value;
      Suit = suit;
    }

    public override string ToString() {
      return Name;
    }
  }
}