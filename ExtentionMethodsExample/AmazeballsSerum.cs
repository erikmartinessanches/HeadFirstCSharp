using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ExtentionMethodsExample
{
    static class AmazeballsSerum
    {
        public static string BreakWalls(this OrdinaryHuman h, double wallDensity) {
            return ($"I broke through a wall of {wallDensity} density.");
        }

        /**In addition to extending methods on classes we can also extend interfaces
         * by using an interface name in place of a class, after the 'this' keyword
         * in the extension method's first parameter. The extension method will be
         * added to every class that implements the interface. (This is what LINQ
         * is based on, all of the LINQ methods are static extension methods for the
         * IEnumerable<T> interface.) 
         */

    }
}
