using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerPartyEstimator
{
    class DinnerParty
    {
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public bool HealthyOption { get; set; }
        private const decimal _costOfFoodPerPerson = 25.0M;

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            HealthyOption = healthyOption;
            FancyDecorations = fancyDecorations;
        }
        
        private decimal CalculateCostOfDecorations()
        {
            if (FancyDecorations)
            {
                return 15.0M * NumberOfPeople + 50.0M;
            }
            else
            {
                return 7.50M * NumberOfPeople + 30.0M;
            }

        }

        private decimal CalculateCostOfBeveragesPerPerson()
        {
            if (HealthyOption)
            {
                return 5.0M;
            }
            else
            {
                return 20.0M;
            }
        }

        public decimal Cost {
            get
            {
                decimal totalCost = _costOfFoodPerPerson * NumberOfPeople;
                totalCost += CalculateCostOfDecorations();
                totalCost += CalculateCostOfBeveragesPerPerson() * NumberOfPeople;
                if (HealthyOption)
                {
                    totalCost += totalCost * 0.95M; //Discount
                }
                return totalCost;
            }
        }
    }
}
