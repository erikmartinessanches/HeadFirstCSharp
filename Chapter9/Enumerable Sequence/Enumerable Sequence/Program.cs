using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Enumerable_Sequence {

  /*Building an enumerable sequence by hand, p. 580, 4th ed.*/
  enum Sport {Football, Baseball, Hockey, Boxing, Rugby, Fencing};

  /*A custom sequence IEnumerable<Sport>.*/
  class ManualSportSequence : IEnumerable<Sport> {
    public IEnumerator<Sport> GetEnumerator() {
      return new ManualSportEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator() {
      return GetEnumerator();
    }
  }

  /*A custo enumerator IEnumerator<Sport>. */
  class ManualSportEnumerator : IEnumerator<Sport> {
    int current = -1;

    public Sport Current => (Sport)current;

    object IEnumerator.Current => Current;

    public void Dispose() {
      return;
    }

    public bool MoveNext() {
      var maxEnumValue = Enum.GetValues(typeof(Sport)).Length;
      if ((int)current >= maxEnumValue-1) {return false;}
      current++;
      return true;
    }

    public void Reset() {
      current = 0;
    }
  }

  internal class Program {
    static void Main(string[] args) {
      var sports = new ManualSportSequence();
      foreach (var sport in sports) Console.WriteLine(sport);
      
      /*Using yield return to create sequences much easier. Example p. 581, 4th ed.*/
      foreach (var s in SimpleEnumerable()) Console.WriteLine(s);

      
      /*Creating and enumerating BetterSportSequence.*/
      Console.WriteLine("Creating and enumerating BetterSportSequence: ");
      var betterSportSequence = new BetterSportSequence();
      foreach (var s in betterSportSequence) Console.WriteLine(s);
      Console.WriteLine("Testing the indexer on betterSportSequence [3]: ");
      Console.WriteLine($"{betterSportSequence[3]}");
    }

    /*yield return makes a method return an Enumerable Sequence by returning 
     the next element each time it is called, it remembers where it returned
    from last time so that it may continue returning the next thing.
    
     When a compiler sees a method with a yield return that returns an 
    IEnumerable<T>, it automatically adds the Movenext() method and Current
    property. */
    static IEnumerable<string> SimpleEnumerable(){
      yield return "apples";
      yield return "oranges";
      yield return "bananas";
      yield return "unicorns";
     }

  }

    /*We can create yield return to create a slightly simple Sport Sequence:*/
    class BetterSportSequence : IEnumerable<Sport> {
      /*Note that indexers are allowed to take different kinds of types...*/
      public Sport this[int index] {
        get => (Sport)index;
      }
      //Indexers also support setting with 'set'.

      public IEnumerator<Sport> GetEnumerator() {
        int maxEnumValue = Enum.GetValues(typeof(Sport)).Length -1;
      
      for (int i = 0; i <= maxEnumValue; i++)
        yield return (Sport)i;
      }

      IEnumerator IEnumerable.GetEnumerator() {
        return GetEnumerator();
      }
  }
}