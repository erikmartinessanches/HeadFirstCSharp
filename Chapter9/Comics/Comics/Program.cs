using System;
using System.Collections.Generic;
using System.Linq;
using Comics;

namespace Comics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example p 535, 4th ed.
            int[] values = new int[] { 0, 12, 44, 36, 92, 54, 13, 8 };
            IEnumerable<int> result2 = 
            from v in values where v < 37 orderby v descending select v;
            foreach (int i in result2) Console.WriteLine($"{i} ");

            //Exercise p 535, 4th ed: Print a list of comics with a price > 500
            //in reverse order.
            IEnumerable<Comic> result =
                from comic in Comic.Catalog
                where Comic.Prices[comic.Issue] > 500
                orderby Comic.Prices[comic.Issue] descending
                //The result of the query is a sequence of Comics.
                //Return type is IEnumerable<Comic>. 
                select comic; 
            foreach (Comic c in result) 
              Console.WriteLine($"{c} is worth {Comic.Prices[c.Issue]:c}");

            //Changing the select clause to an interpolated string makes the
            //result of the query a sequence of strings: The return type (from
            //the query) becomes IEnumerable<string>. The select clause includes
            //an expression that gets applied to every item in the sequence and 
            //that sequence determines the type of output.
            var mostExpensiveComicDescriptions =
                //from clause selects collection and assigns a name for each
                //member of the collection queried (comic is a "range variable").
                from comic in Comic.Catalog
                where Comic.Prices[comic.Issue] > 500
                orderby Comic.Prices[comic.Issue] descending
                select $"{comic} is worth {Comic.Prices[comic.Issue]:c}";
            foreach (string comicDescription in mostExpensiveComicDescriptions) 
              Console.WriteLine(comicDescription);


            /** LINQ queries aren't tun until we access their results (deferred, 
             * lazy evaluation). */
            var listOfObjects = new List<PrintWhenGetting>();
            for (int i = 1; i < 5; i++)
            {
                listOfObjects.Add(new PrintWhenGetting() { InstanceNumber = i });
            }
            Console.WriteLine("Setting up the query.");
            var result3 =
                from o in listOfObjects
                select o.InstanceNumber;

            /**Notice how this line appears in the terminal BEFORE the get 
             * accessor executes. That's because the LINQ query is executed only 
             * once we reach the foreach loop.
             */
            Console.WriteLine("Run the foreach loop.");

            foreach (var number in result3)
            {
                Console.WriteLine($"Writing #{number}");
            }
            /** The out put is
            Setting up the query.
            Run the foreach loop.
            Getting instance number 1
            Writing #1
            Getting instance number 2
            Writing #2
            Getting instance number 3
            Writing #3
            Getting instance number 4
            Writing #4
            */

            /** LINQ query can be made to execute immediatly by using a LINQ 
             * method that enumerates the collection, such as ToList, which 
             * turns it into a List<T>:
             */
            var immediate = result3.ToList();
            Console.WriteLine("Run the foreach.");
            foreach (var number in immediate) 
              Console.WriteLine($"Writing #{number}");

            /** This time the get accessors are called before the foreach loop, 
             * because ToList needs to access every element in the sequence to 
             * convert it into a list. (Similarly for methods like Sum, Min,
             * Max.)
             *
             * The output is now
             *  Getting instance number 1
                Getting instance number 2
                Getting instance number 3
                Getting instance number 4
                Run the foreach.
                Writing #1
                Writing #2
                Writing #3
                Writing #4 
            */

        }
    }

    class PrintWhenGetting
    {
        private int instanceNumber;

        internal int InstanceNumber
        {
            get
            {
                Console.WriteLine($"Getting instance number {instanceNumber}");
                return instanceNumber;
            }
            set => instanceNumber = value;
        }
    }
}
