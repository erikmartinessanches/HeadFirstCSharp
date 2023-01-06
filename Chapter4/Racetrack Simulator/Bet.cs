using System;

namespace Racetrack_Simulator
{
    public class Bet
    {
        public decimal Amount { get; set; } = 0;
        public int Dog { get; set; }
        public Guy Bettor { get; set; }

        public Bet(decimal amount, int dog, Guy bettor)
         {
            Amount = amount;
            Dog = dog;
            Bettor = bettor;
        }

        public String GetDescription()
        {
            if (Bettor != null && !Dog.Equals(0) && !Amount.Equals(0))
            { //Placed bet
                return $"{Bettor.Name} bets {Amount:c} on hound number {Dog}.";
            }
            return null;
        }

        public decimal PayOut(int Winner) => 
            Dog.Equals(Winner) ? Amount : -Amount;
    }
}
