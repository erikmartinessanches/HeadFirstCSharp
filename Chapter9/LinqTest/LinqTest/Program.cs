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
      for (var i = 1; i <= 99; i++) numbers.Add(i);

      var firstAndLastFive =
        numbers.Take(5).Concat(numbers.TakeLast(5));
      foreach (var i in firstAndLastFive) Console.Write($"{i} ");

      //Lambda expression and linq example from chapter 9, 4th ed.
      /*Hovering over select says it takes a Func<int, int> parameter. When a 
       method has that parameter, we can call it with a lambda expression that
      takes an int as param and returns an int. */
      var array = new[] { 1, 2, 3, 4 };
      //var result = from i in array select i * 2;
      //Therefore we could rewrite the above as: 
      var result = array.Select(i => i * 2);
      foreach (var i in result) Console.WriteLine(i);

      //LINQ queries can be written as chained LINQ methods,example p. 573,
      //4th ed. and many can ues lambda expressions to determine the sequence
      //that they produce.
      int[] values = new int[] { 0, 12, 44, 36, 92, 54, 13, 8 };
      /*IEnumerable<int> result2 =
      from v in values
      where v < 37
      orderby -v
      select v;*/
      //The above can be rewritten as
      IEnumerable<int> result2 = values.Where(v => v < 37).OrderBy(v => -v);
      //.Select(v => v);//No need for a select since it doesn't modify the value.
      //Alternatively, .OrderByDescending(v => v) would have reversed the sequence
      //too.
      //GroupBy() is another function that could take a labda expression.
      Console.WriteLine("result2, after chained LINQ methods: ");
      foreach (var i in result2) Console.WriteLine(i);

      
    }
  }
}