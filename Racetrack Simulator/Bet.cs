using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if (Bettor != null && !Dog.Equals(0) && !Amount.Equals(0)) //Placed bet
            {
                return Bettor.Name + " bets " + Amount + " bucks on hound number " + Dog + ".";
            }
            //else 
            //{
            //    return Bettor.Name + " hasn't placed a bet.";
            //}
            return null;
        }
        public decimal PayOut(int Winner) => 
            Dog.Equals(Winner) ? Amount : -Amount;
    }
}
