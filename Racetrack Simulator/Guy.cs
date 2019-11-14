using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racetrack_Simulator
{
    public class Guy
    {
        public String Name { get; set; }
        public Bet MyBet { get; set; } = null;
        public decimal Cash { get; set; }
        public RadioButton MyRadioButton { get; set; }
        public Label MyLabel { get; set; }

        public Guy(String name, decimal cash, RadioButton myRadioButton, 
            Label myLabel)
        {
            Name = name;
            Cash = cash;
            MyRadioButton = myRadioButton;
            MyLabel = myLabel;
        }

        public void UpdateLabels() {
            if (MyBet != null)
            {
                MyLabel.Text = MyBet.GetDescription();
            } else
            {
                MyLabel.Text = Name + " hasn't placed a bet.";
            }
            MyRadioButton.Text = string.Format("{0:s} has {1:c}.", Name, Cash);
        }

        public bool PlaceBet(decimal BetAmount, int DogToWin) {
            if (Cash >= BetAmount)
            {
                MyBet = new Bet(BetAmount, DogToWin, this);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ClearBet()
        {
            if (MyBet == null)
            {    
            } else {
                MyBet = null;
            }
        }

        public void Collect(int Winner)
        {
            if (MyBet != null)
            {
                Cash += MyBet.PayOut(Winner);
            }
            ClearBet();
            UpdateLabels();
        }
    }
}
