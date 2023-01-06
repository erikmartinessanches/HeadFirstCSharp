using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Text;

namespace EnumsAndCollections {
  internal class Duck : IComparable<Duck> {
    public int Size { get; set; }
    public KindOfDuck Kind { get; set; }

    public int CompareTo([AllowNull] Duck other) {
      if (Size > other.Size) {
        return 1;
      }
      else if (Size < other.Size) {
        return -1;
      }
      else {
        return 0;
      }
    }
  }

  internal enum KindOfDuck {
    Mallard,
    Muscovy,
    Loon
  }
}