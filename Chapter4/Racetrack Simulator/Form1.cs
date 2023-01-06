using System;
using System.Globalization;
using System.Windows.Forms;

namespace Racetrack_Simulator
{
    public partial class Form1 : Form
    {
        Greyhound[] GreyhoundArray;
        Guy[] GuyArray;
        Random MyRandomizer;

        public Form1()
        {
            InitializeComponent();
            MyRandomizer = new Random();
            GreyhoundArray = new Greyhound[4];
            GuyArray = new Guy[3];
            PrepareHoundsAndGuys();
            minimumBetLabel.Text = $"Minimum bet: " +
                $"{BetAmountNumericUpDown.Minimum:c}.";
            label2.Text = $"{NumberFormatInfo.CurrentInfo.CurrencySymbol}" +
                $" on hound number ";

            /*´In order to make the hounds transparent, set the "Back Color"
             * of the parent container to Transparent. PictureBox doesn't have
             * a Parent property, therefore I set it: */
            Dog1PictureBox.Parent = TrackPictureBox;
            Dog2PictureBox.Parent = TrackPictureBox;
            Dog3PictureBox.Parent = TrackPictureBox;
            Dog4PictureBox.Parent = TrackPictureBox;

        }

        private void PrepareHoundsAndGuys()
        {
            GreyhoundArray[0] = new Greyhound(Dog1PictureBox,
                Dog1PictureBox.Left, TrackPictureBox.Width - 
                Dog1PictureBox.Width, MyRandomizer);
            GreyhoundArray[1] = new Greyhound(Dog2PictureBox,
                Dog2PictureBox.Left, TrackPictureBox.Width - 
                Dog2PictureBox.Width, MyRandomizer);
            GreyhoundArray[2] = new Greyhound(Dog3PictureBox,
                Dog3PictureBox.Left, TrackPictureBox.Width - 
                Dog3PictureBox.Width, MyRandomizer);
            GreyhoundArray[3] = new Greyhound(Dog4PictureBox,
                Dog4PictureBox.Left, TrackPictureBox.Width - 
                Dog4PictureBox.Width, MyRandomizer);

            GuyArray[0] = new Guy("Joe", 50, joeRadioButton, joeBetLabel);
            GuyArray[1] = new Guy("Bob", 75, bobRadioButton, bobBetLabel);
            GuyArray[2] = new Guy("Al", 45, alRadioButton, alBetLabel);

            foreach (Guy guy in GuyArray)
            {
                guy.UpdateLabels();
            }
        }

        private void joeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = "Joe";
            if (GuyArray[0].MyBet != null && GuyArray[0].MyBet.Amount != 0 && 
                GuyArray[0].MyBet.Dog != 0)
            {
                BetAmountNumericUpDown.Value = GuyArray[0].MyBet.Amount;
                DogNumberNumericUpDown.Value = GuyArray[0].MyBet.Dog;
            }
        }

        private void bobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = "Bob";
            if (GuyArray[1].MyBet != null && GuyArray[1].MyBet.Amount != 0 && 
                GuyArray[1].MyBet.Dog != 0)
            {
                BetAmountNumericUpDown.Value = GuyArray[1].MyBet.Amount;
                DogNumberNumericUpDown.Value = GuyArray[1].MyBet.Dog;
            }
        }

        private void alRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = "Al";
            if (GuyArray[2].MyBet != null && GuyArray[2].MyBet.Amount != 0 && 
                GuyArray[2].MyBet.Dog != 0)
            {
                BetAmountNumericUpDown.Value = GuyArray[2].MyBet.Amount;
                DogNumberNumericUpDown.Value = GuyArray[2].MyBet.Dog;
            }
        }

        private void betsButton_Click(object sender, EventArgs e)
        {
            if (joeRadioButton.Checked)
            {
                if(GuyArray[0].PlaceBet(BetAmountNumericUpDown.Value, 
                    (int)DogNumberNumericUpDown.Value))
                    GuyArray[0].UpdateLabels();
            }
            else if (bobRadioButton.Checked)
            {
                if(GuyArray[1].PlaceBet(BetAmountNumericUpDown.Value, 
                    (int)DogNumberNumericUpDown.Value))
                    GuyArray[1].UpdateLabels();
            }
            else if (alRadioButton.Checked)
            {
                if(GuyArray[2].PlaceBet(BetAmountNumericUpDown.Value, 
                    (int)DogNumberNumericUpDown.Value))
                    GuyArray[2].UpdateLabels();
            }
        }

        private void RaceButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < GreyhoundArray.Length; i++)
            {
                GreyhoundArray[i].TakeStartingPosition();
            }
            timer1.Start();
            bettingParlorGroup.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < GreyhoundArray.Length; i++)
            {
                if (GreyhoundArray[i].Run())
                {
                    timer1.Stop();
                    int winner = i + 1;
                    MessageBox.Show("Hound number " + winner + 
                        " won the race!", "We have a winner!");
                    foreach (Guy guy in GuyArray)
                    {
                        guy.Collect(winner);
                        guy.ClearBet();
                        guy.UpdateLabels();
                    }
                    bettingParlorGroup.Enabled = true;
                    foreach (Greyhound hound in GreyhoundArray)
                    {
                        hound.TakeStartingPosition();
                    }
                    break; //Prevent more than one winner
                    
                }
            }
        }
    }
}
