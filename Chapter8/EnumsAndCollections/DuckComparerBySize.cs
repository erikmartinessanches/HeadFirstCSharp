using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfDucks {
  /// <summary>
  /// This is a comparer object that can I can pass as a parameter to List.Soet()
  /// to make is sort Ducks by size.
  /// </summary>
  internal class DuckComparerBySize : IComparer<Duck> {
    public int Compare(Duck x, Duck y) {
      if (x.Size > y.Size) {
        return 1;
      }

      if (x.Size < y.Size) {
        return -1;
      }

      return 0;
    }
  }
}