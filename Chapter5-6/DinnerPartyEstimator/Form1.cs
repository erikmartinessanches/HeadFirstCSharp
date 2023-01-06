using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyEstimator {
  public partial class Form1 : Form {
    private DinnerParty dinnerParty;
    private BirthdayParty birthdayParty;

    public Form1() {
      InitializeComponent();
      dinnerParty = new DinnerParty((int)numberDinner.Value,
        healthyDinnerBox.Checked, fancyDinnerBox.Checked);
      birthdayParty = new BirthdayParty((int)numberBirthday.Value,
        fancyBirthday.Checked, cakeWriting.Text);
      DisplayBirthdayPartyCost();
      DisplayDinnerPartyCost();
    }

    private void DisplayDinnerPartyCost() {
      decimal Cost = dinnerParty.Cost;
      costLabel.Text = Cost.ToString("c");
    }

    private void DisplayBirthdayPartyCost() {
      tooLongLabel.Visible = birthdayParty.CakeWritingTooLong;
      decimal Cost = birthdayParty.Cost;
      birthdayCost.Text = Cost.ToString("c");
    }


    private void numberBirthday_ValueChanged(object sender, EventArgs e) {
      birthdayParty.NumberOfPeople = (int)numberBirthday.Value;
      DisplayBirthdayPartyCost();
    }

    private void fancyBirthday_CheckedChanged(object sender, EventArgs e) {
      birthdayParty.FancyDecorations = fancyBirthday.Checked;
      DisplayBirthdayPartyCost();
    }

    private void cakeWriting_TextChanged(object sender, EventArgs e) {
      birthdayParty.CakeWriting = cakeWriting.Text;
      DisplayBirthdayPartyCost();
    }


    private void numberDinner_ValueChanged(object sender, EventArgs e) {
      dinnerParty.NumberOfPeople = (int)numberDinner.Value;
      DisplayDinnerPartyCost();
    }

    private void fancyDinnerBox_CheckedChanged(object sender, EventArgs e) {
      dinnerParty.FancyDecorations = fancyDinnerBox.Checked;
      DisplayDinnerPartyCost();
    }

    private void healthyDinnerBox_CheckedChanged(object sender, EventArgs e) {
      dinnerParty.HealthyOption = healthyDinnerBox.Checked;
      DisplayDinnerPartyCost();
    }
  }
}