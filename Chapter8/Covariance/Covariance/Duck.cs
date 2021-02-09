using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Text;
using Covariance;

namespace EnumsAndCollections
{
    class Duck : Bird, IComparable<Duck>
    {
        public int Size { get; set; }
        public KindOfDuck Kind { get; set; }
        public int CompareTo([AllowNull] Duck other)
        {
            if (this.Size > other.Size)
                return 1;
            else if (this.Size < other.Size)
                return -1;
            else
                return 0;
        }
        public override string ToString()
        {
            return $"A {Size} inch {Kind}";
        }
    }

    enum KindOfDuck
    {
        Mallard,
        Muscovy,
        Loon
    }
}
