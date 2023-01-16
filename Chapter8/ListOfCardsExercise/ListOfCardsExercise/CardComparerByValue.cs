namespace ListOfCardsExercise {
  internal class CardComparerByValue : IComparer<Card> {
    public int Compare(Card x, Card y) {
      //Notice that we can compare enum values below without using casting (to int).
      if (x.Suit < y.Suit) { //First order by suit.
        return -1;
      }

      if (x.Suit > y.Suit) {
        return 1;
      }

      if (x.Value < y.Value) { //The order by value.
        return -1;
      }

      if (x.Value > y.Value) {
        return 1;
      }

      return 0;
    }
  }
}