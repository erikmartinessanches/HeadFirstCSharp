/*Covariance is when we take a collection, such as a List<T>, and upcast the
 entire collection at once. Covariance is implicitly converting a subclass
 reference to its superclass. Useful when we need o pass a collection to a method
 that only workd with the superclass type.

 Generic .NET collections implement IEnumerable. (So we can always look over 
 them.) Also, it is possible to create a List, Queue or Stack from any other 
 object that implements the IEnumerable<T> interface (by passing to the overloaded
constructor a collection we want to *copy* from). */

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
      /*Covariance allows us to simply use assignment = to upcast List<Subclass>
        to an IEnumerable<Superclass>.*/
      IEnumerable<Bird> upcastDucks = ducks;
      /*Now, using IEnumerable's ToList() converts the IEnumerable<Bird> to
        List<Bird>.*/
      Bird.FlyAway(upcastDucks.ToList(), "Minnesota");
      /*Bird.FlyAway() is a static method on the Bird class, hence it's
        availability here. */
    }
  }
}