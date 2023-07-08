/* We can extend a sealed class (one that we can't inherit from) by using 
 * extension methods. The class we add has to be static and all extension methods 
 * are static. When we have added a class with extension methods to the project,
 * the new methods appear on classes that already exist.*/

namespace ExtentionMethodsExample {
   static class AmazeballsSerum {
      /*The first param tells which class we extend. The second param is the 
       parameter for the extension method. */
      public static string BreakWalls(this OrdinaryHuman h, double wallDensity) {
         return ($"I broke through a wall of {wallDensity} density.");
      }

      /**In addition to extending methods on classes we can also extend interfaces
       * by using an interface name in place of a class, after the 'this' keyword
       * in the extension method's first parameter. The extension method will be
       * added to every class that implements the interface. (This is what LINQ
       * is based on, all of the LINQ methods are static extension methods for the
       * IEnumerable<T> interface.) Extension methods to not have access to class
       * internals and act as outsiders.
       */

   }
}
