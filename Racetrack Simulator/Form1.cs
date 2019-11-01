using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racetrack_Simulator
{
    public partial class Form1 : Form
    {
        Greyhound[] GreyhoundArray = new Greyhound[4];
        Guy[] GuyArray = new Guy[3];
        Random MyRandomizer;

        public Form1()
        {
            InitializeComponent();
            MyRandomizer = new Random();
            PrepareHoundsAndGuys();
            minimumBetLabel.Text = "Minimum bet: " +
                BetAmountNumericUpDown.Minimum + " bucks.";
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
            GuyArray[0].ClearBet();
            GuyArray[0].UpdateLabels();
            GuyArray[1] = new Guy("Bob", 75, bobRadioButton, bobBetLabel);
            GuyArray[1].ClearBet();
            GuyArray[1].UpdateLabels();
            GuyArray[2] = new Guy("Al", 45, alRadioButton, alBetLabel);
            GuyArray[2].ClearBet();
            GuyArray[2].UpdateLabels();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void joeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //joeRadioButton.Checked = true;
            nameLabel.Text = "Joe";
            //if (GuyArray[0].MyBet != null && GuyArray[0].MyBet.Amount != 0 && GuyArray[0].MyBet.Dog != 0)
            //{
            //    BetAmountNumericUpDown.Value = GuyArray[0].MyBet.Amount;
            //    DogNumberNumericUpDown.Value = GuyArray[0].MyBet.Dog;
            //}
            
        }
        private void bobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //bobRadioButton.Checked = true;
            nameLabel.Text = "Bob";
            //if (GuyArray[1].MyBet != null && GuyArray[1].MyBet.Amount != 0 && GuyArray[1].MyBet.Dog != 0)
            //{
            //    BetAmountNumericUpDown.Value = GuyArray[1].MyBet.Amount;
            //    DogNumberNumericUpDown.Value = GuyArray[1].MyBet.Dog;
            //}
        }

        private void alRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //alRadioButton.Checked = true;
            nameLabel.Text = "Al";
            //if (GuyArray[2].MyBet != null && GuyArray[2].MyBet.Amount != 0 && GuyArray[2].MyBet.Dog != 0)
            //{
            //    BetAmountNumericUpDown.Value = GuyArray[2].MyBet.Amount;
            //    DogNumberNumericUpDown.Value = GuyArray[2].MyBet.Dog;
            //}
        }

        private void betsButton_Click(object sender, EventArgs e)
        {
            if (joeRadioButton.Checked)
            {
                GuyArray[0].PlaceBet(BetAmountNumericUpDown.Value, 
                    (int)DogNumberNumericUpDown.Value);
                GuyArray[0].UpdateLabels();
            }
            else if (bobRadioButton.Checked)
            {
                GuyArray[1].PlaceBet(BetAmountNumericUpDown.Value,
                    (int)DogNumberNumericUpDown.Value);
                GuyArray[1].UpdateLabels();
            }
            else if (alRadioButton.Checked)
            {
                GuyArray[2].PlaceBet(BetAmountNumericUpDown.Value,
                    (int)DogNumberNumericUpDown.Value);
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
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < GreyhoundArray.Length; i++)
            {
                if (GreyhoundArray[i].Run())
                {
                    timer1.Stop();
                    int winner = i + 1;
                    MessageBox.Show("Hound number " + winner + " won the race!",
                        "We have a winner!");
                    GuyArray[0].Collect(winner);
                    GuyArray[1].Collect(winner);
                    GuyArray[2].Collect(winner);
                }
            }
        }
    }
}
