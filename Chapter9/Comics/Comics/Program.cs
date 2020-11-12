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
            //Exercise: Print a list of comics with a price > 500 in reverse order.
            IEnumerable<Comic> result =
                from comic in Comic.Catalog
                where Comic.Prices[comic.Issue] > 500
                orderby -Comic.Prices[comic.Issue]
                select comic;

            foreach (Comic c in result)
            {
                Console.WriteLine($"{c} is worth {Comic.Prices[c.Issue]:c}");
            }
        }
    }
}
