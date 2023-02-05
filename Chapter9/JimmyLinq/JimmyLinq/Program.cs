﻿using System;
using System.Runtime.CompilerServices;

namespace JimmyLinq
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var done = false;
            while (!done) {
                Console.WriteLine(
                    "\nPress G to group comics by price, R to get reviews, any other key to quit\n");
                switch (Console.ReadKey(true).KeyChar.ToString().ToUpper()) {
                    case "G":
                        done = GroupComicsByPrice();
                        break;
                    case "R":
                        done = GetReviews();
                        break;
                    default:
                        done = true;
                        break;
                }
            }
        }

        public static bool GroupComicsByPrice()
        {
            //The outer foreach loop prints info about each group,
            //the inner foreach enumerates the group.
            var groups = ComicAnalyzer.GroupComicsByPrice(Comic.Catalog, Comic.Prices);
            foreach (var group in groups)
            {
                Console.WriteLine($"{group.Key} comics:");
                foreach (var comic in group)
                {
                    Console.WriteLine($"#{comic.Issue} {comic.Name}: {Comic.Prices[comic.Issue]:c}");
                }
            }
            return false;
        }

        public static bool GetReviews()
        {
            var reviews = ComicAnalyzer.GetReviews(Comic.Catalog, Comic.Reviews);
            foreach (var review in reviews)
                Console.WriteLine(review);
            return false;
        }
    }
}
