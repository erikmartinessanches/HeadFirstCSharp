using Comics;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JimmyLinq
{
    public static class ComicAnalyzer
    {
         static PriceRange CalculatePriceRange(Comic comic)
        {
            if (Comic.Prices[comic.Issue] < 100)
            {
                return PriceRange.Cheap;
            }
            else
            {
                return PriceRange.Expensive;
            }
        }

         public static IEnumerable<IGrouping<PriceRange, Comic>> GroupComicsByPrice(IEnumerable<Comic> comics, IReadOnlyDictionary<int, decimal> prices)
        {
            var comicsResult =
                from price in prices
                join comic in comics
                    on price.Key equals comic.Issue
                orderby prices[comic.Issue]
                group comic by CalculatePriceRange(comic) into comicGroup
                select comicGroup;
            return comicsResult;
        }

        public static IEnumerable<string> GetReviews(IEnumerable<Comic> catalog, IEnumerable<Review> reviews)
        {
            var temp = 
                from comic in catalog
                orderby comic.Issue
                join review in reviews
                    on comic.Issue equals review.Issue
                select $"{review.Critic} rated #{comic.Issue} '{comic.Name}' {review.Score:0.00}";
            return temp;
        }
    }
}