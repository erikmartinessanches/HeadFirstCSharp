using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Text;
using Covariance;

namespace EnumsAndCollections {
  internal class Duck : Bird, IComparable<Duck> {
    public int Size { get; set; }
    public KindOfDuck Kind { get; set; }

    public int CompareTo([AllowNull] Duck other) {
      if (Size > other.Size) {
        return 1;
      }

      if (Size < other.Size) {
        return -1;
      }

      return 0;
    }

    public override string ToString() {
      return $"A {Size} inch {Kind}";
    }
  }

  internal enum KindOfDuck {
    Mallard,
    Muscovy,
    Loon
  }
}