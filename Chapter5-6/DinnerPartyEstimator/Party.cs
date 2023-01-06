using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyEstimator
{
    class Party
    {
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public decimal CostOfFoodPerPerson { get; set; } = 25.0M;

        public decimal CalculateCostOfDecorations()
        {
            decimal costOfDecorations;
            if (FancyDecorations)
            {
                costOfDecorations = (NumberOfPeople * 15.0M) + 50.0M;
            }
            else
            {
                costOfDecorations = (NumberOfPeople * 7.50M) + 30.0M;
            }

            return costOfDecorations;
        }
    }
}
