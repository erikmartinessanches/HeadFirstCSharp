/*When adding "using System.Linq", LINQ methods get added to any object that
  extends (implements) IEnumerable<T>. Most LINQ methods return IEnumerable<T> 
  and this allows for method chaining. When a class implements IEnumerable<T>, 
any instance is a sequence. 

 *Enumerating the sequence* means doing an operation on that sequence in order. 
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTest {
  internal class Program {
    private static void Main(string[] args) {
      IList<int> numbers = new List<int>();
      for (int i = 1; i <= 99; i++) {
        numbers.Add(i);
      }

      IEnumerable<int> firstAndLastFive =
        numbers.Take(5).Concat(numbers.TakeLast(5));
      foreach (int i in firstAndLastFive) {
        Console.Write($"{i} ");
      }
    }
  }
}