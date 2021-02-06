using System;
using System.Collections.Generic;
using System.Text;

namespace EnumsAndCollections
{
    /// <summary>
    /// A comparer object that we can pass as a parameter to List.Sort
    /// to make it sort our ducks.
    /// 
    /// Clearly, multiple IComparer<Duck> can be created to sort in different ways.
    /// We can also add members to determine how the list gets sorted.
    /// </summary>
    class DuckComparer : IComparer<Duck>
    {
        public SortCriteria SortBy = SortCriteria.SizeThenKind;
        public int Compare(Duck x, Duck y)
        {
            if (SortBy == SortCriteria.SizeThenKind)
            {
                if (x.Size > y.Size)
                    return 1;
                else if (x.Size < y.Size)
                    return -1;
                else 
                    if (x.Kind > y.Kind)
                        return 1;
                    else if (x.Kind < y.Kind)
                        return -1;
                    else
                        return 0;
            }
            else
            {
                if (x.Kind > y.Kind)
                    return 1;
                else if (x.Kind < y.Kind)
                    return -1;
                else 
                    if (x.Size > y.Size)
                        return 1;
                    else if (x.Size < y.Size)
                        return -1;
                    else
                        return 0;
            }
        }
    }

    enum SortCriteria
    {
        SizeThenKind,
        KindThenSize,
    }
}
