using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyEstimator
{
    class BirthdayParty : Party
    {
        
        
        public string CakeWriting { get; set; }

        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
        {
            CakeWriting = cakeWriting;
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
        }

        private int ActualLength
        {
            get { return CakeWriting.Length > MaxWritingLength() ? MaxWritingLength() : CakeWriting.Length; }

        }

        private int CakeSize()
        {
            return NumberOfPeople <= 4 ? 8 : 16;
        }

        private int MaxWritingLength()
        {
            return CakeSize() == 8 ? 16 : 40;
        }

        public bool CakeWritingTooLong
        {
            get { return CakeWriting.Length > MaxWritingLength(); }
        }

        public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += CostOfFoodPerPerson * NumberOfPeople;
                decimal cakeCost;
                if (CakeSize() == 8)
                {
                    cakeCost = 40.0M + (ActualLength * 0.25M);
                }
                else
                {
                    cakeCost = 75.0M + (ActualLength * 0.25M);
                }
                return totalCost + cakeCost;
            }
        }
    }
}
