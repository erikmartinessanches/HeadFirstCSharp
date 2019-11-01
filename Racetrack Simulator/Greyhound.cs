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
        public int StartingPosition { get; set; }  //Where MyPictureBox starts.
        public int RacetrackLength { get; set; }
        public PictureBox MyPictureBox { get; set; } = null;
        public int Location { get; set; } = 0; //My location on the track
        public Random Randomizer; //Each Greyhound's Randomizer reference
        //should point to the same Random object.

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
            return (Location >= RacetrackLength) ? true : false;
        }

        public void TakeStartingPosition()
        {
            Location = 0;
            MyPictureBox.Left = StartingPosition + Location;
        }
    }
}
