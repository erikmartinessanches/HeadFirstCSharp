using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racetrack_Simulator
{
    public class Greyhound
    {
        public int StartingPosition;  //Where MyPictureBox starts.
        public int RacetrackLength; 
        public PictureBox MyPictureBox = null;
        public int Location = 0; //My location on the track
        public Random Randomizer; //Should this not be static if each Greyhound's
        //Randomizer reference should point to the same Random object?

        public Greyhound(PictureBox pictureBox, int startingPosition, 
            int racetrackLength, Random randomizer)
        {
            MyPictureBox = pictureBox;
            StartingPosition = startingPosition;
            RacetrackLength = racetrackLength;
            Randomizer = randomizer;
        }

        public bool Run()
        {
            Location += Randomizer.Next(1, 5);
            MyPictureBox.Left = StartingPosition + Location;
            return Location.Equals(RacetrackLength) ? true : false;
        }

        public void TakeStartingPosition()
        {
            Location = 0;
            MyPictureBox.Left = StartingPosition + Location;
        }
    }
}
