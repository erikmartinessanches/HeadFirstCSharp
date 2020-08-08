using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyEstimator
{
    class DinnerParty : Party
    {
       
        
        public bool HealthyOption { get; set; }

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            HealthyOption = healthyOption;
            FancyDecorations = fancyDecorations;
        }
        


        private decimal CalculateCostOfBeveragesPerPerson()
        {
            return HealthyOption ? 5.0M : 20.0M;
        }

        public decimal Cost {
            get
            {
                decimal totalCost = CostOfFoodPerPerson * NumberOfPeople;
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
