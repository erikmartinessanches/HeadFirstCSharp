/*Covariance is when we take a collection, such as a List<T>, and upcast the
 entire collection at once. Covariance is implicitly converting a subclass
 reference to its superclass. Useful when we need o pass a collection to a method
 that only workd with the superclass type.*/

using System;
using System.Collections.Generic;
using System.Linq;
using EnumsAndCollections;

namespace Covariance {
  internal class Program {
    private static void Main(string[] args) {
      List<Duck> ducks = new() {
        new Duck { Kind = KindOfDuck.Mallard, Size = 17 },
        new Duck { Kind = KindOfDuck.Muscovy, Size = 18 },
        new Duck { Kind = KindOfDuck.Loon, Size = 14 },
        new Duck { Kind = KindOfDuck.Muscovy, Size = 11 },
        new Duck { Kind = KindOfDuck.Mallard, Size = 14 },
        new Duck { Kind = KindOfDuck.Loon, Size = 13 }
      };
      /*We *can* use assignment = to upcast List<Duck> to an IEnumerable<Bird>.*/
      IEnumerable<Bird> upcastDucks = ducks;
      /*Now, using IEnumerable's ToList() converts the IEnumerable<Bird> to
       List<Bird>.*/
      Bird.FlyAway(upcastDucks.ToList(), "Minnesota");
      /* Bird.FlyAway() is a static method on the Bird class, hence it's
      availability here. */
    }
  }
}