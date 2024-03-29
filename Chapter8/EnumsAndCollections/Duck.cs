﻿using System;
using System.Diagnostics.CodeAnalysis;

namespace ListOfDucks {
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