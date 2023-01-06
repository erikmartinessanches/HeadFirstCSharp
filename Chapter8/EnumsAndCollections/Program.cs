using System;
using System.Collections.Generic;

namespace ListOfDucks {
  internal class Program {
    private static void Main(string[] args) {
      LongTrickScore myScore = LongTrickScore.Beg;
      Console.WriteLine((long)myScore); //Casts to the enum's underlying value.

      //Comparing ducks, page 473, 4th ed. 
      Console.WriteLine(
        "\n... Comparing ducks exercise (p. 473, 4th ed) ...\n");
      List<Duck> ducks = new() {
        new Duck { Kind = KindOfDuck.Mallard, Size = 17 },
        new Duck { Kind = KindOfDuck.Muscovy, Size = 18 },
        new Duck { Kind = KindOfDuck.Loon, Size = 14 },
        new Duck { Kind = KindOfDuck.Muscovy, Size = 11 },
        new Duck { Kind = KindOfDuck.Mallard, Size = 14 },
        new Duck { Kind = KindOfDuck.Loon, Size = 13 }
      };
      Console.WriteLine(
        "Sorting ducks using CompareTo(Duck other) on Duck : IComparable<Duck>");
      ducks.Sort();
      PrintDucks(ducks);

      DuckComparer comparer = new();
      Console.WriteLine(
        "Sorting ducks using Compare(Duck x, Duck, y) on DuckComparer : IComparer<Duck>");
      Console.WriteLine("Sorting by kind then size");
      comparer.SortBy = SortCriteria.KindThenSize;
      ducks.Sort(comparer);
      PrintDucks(ducks);
      Console.WriteLine("Sorting by size then kind");
      comparer.SortBy = SortCriteria.SizeThenKind;
      ducks.Sort(comparer);
      PrintDucks(ducks);
    }

    public static void PrintDucks(List<Duck> ducks) {
      foreach (Duck duck in ducks) {
        Console.WriteLine($"{duck.Size} inch {duck.Kind}");
      }
    }
  }

  /* Long-based (for example) enums can be made like so.*/
  internal enum LongTrickScore : long {
    Sit = 7,
    Beg = 250000025
  }
}