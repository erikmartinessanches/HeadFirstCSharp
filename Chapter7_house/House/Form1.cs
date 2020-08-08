using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace House
{
    public partial class Form1 : Form
    {
        private Location CurrentLocation { get; set; }

        private RoomWithDoor livingRoom;
        private OutsideWithDoor frontYard;
        private OutsideWithHidingPlace garden;
        private OutsideWithDoor backYard;
        private RoomWithHidingPlace diningRoom;
        private RoomWithDoor kitchen;
        private Room stairs;
        private RoomWithHidingPlace hallway;
        private RoomWithHidingPlace bathroom;
        private RoomWithHidingPlace masterBedroom;
        private RoomWithHidingPlace secondBedRoom;
        private OutsideWithHidingPlace driveway;
        private Opponent opponent;
        private int Moves;

        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            opponent = new Opponent(frontYard);
            ResetGame(false);
        }

        private void CreateObjects()
        {
            livingRoom = new RoomWithDoor("Living Room", "an antique carpet", "inside the closet", "an oak door with a brass knob");
            frontYard = new OutsideWithDoor("Front Yard", false, "an oak door with a brass knob");
            garden = new OutsideWithHidingPlace("Garden", false, "inside the shed");
            backYard = new OutsideWithDoor("Back yard", true, "a screen door"); 
            diningRoom = new RoomWithHidingPlace("Dining room", "chrystal chandelier","in the tall armoire");
            kitchen = new RoomWithDoor("Kitchen", "stainless steel appliances", "in the cabinet", "a screen door");
            stairs = new Room("Stairs","a wooden bannister");
            hallway = new RoomWithHidingPlace("Upstairs hallway", "a picture of a dog", "in the closet");
            bathroom = new RoomWithHidingPlace("Bathroom", "a sink and a toilet", "in the shower");
            masterBedroom = new RoomWithHidingPlace("Master bedroom", "a large bed", "under the bed");
            secondBedRoom = new RoomWithHidingPlace("Second bedroom", "a small bed", "under the bed");
            driveway = new OutsideWithHidingPlace("Driveway", true, "in the garage");

            livingRoom.Exits = new Location[]{diningRoom, stairs};
            diningRoom.Exits = new Location[]{livingRoom, kitchen};
            frontYard.Exits = new Location[]{backYard, garden, driveway};
            garden.Exits = new Location[]{frontYard, backYard};
            backYard.Exits = new Location[]{garden, frontYard};
            kitchen.Exits = new Location[]{diningRoom};
            stairs.Exits = new Location[]{livingRoom, hallway};
            hallway.Exits = new Location[]{stairs, bathroom, masterBedroom, secondBedRoom};
            bathroom.Exits = new Location[]{hallway};
            masterBedroom.Exits = new Location[]{hallway};
            secondBedRoom.Exits = new Location[]{hallway};
            driveway.Exits = new Location[]{backYard, frontYard};
            

            //For the IHasExteriorDoor object, we need to set where their door goes to
            livingRoom.DoorLocation = frontYard;
            backYard.DoorLocation = kitchen;
            frontYard.DoorLocation = livingRoom;
            kitchen.DoorLocation = backYard;
        }

        private void MoveToANewLocation(Location newLocation)
        {
            Moves++;
            CurrentLocation = newLocation;
            RedrawForm();
        }

        private void goHere_Click(object sender, EventArgs e)
        {
            // Use the selected location's position in the combo box to chose 
            // where to go by pressing the goHere button.
            MoveToANewLocation(CurrentLocation.Exits[exits.SelectedIndex]);
        }

        private void goThroughTheDoor_Click(object sender, EventArgs e)
        {
            MoveToANewLocation((CurrentLocation as IHasExteriorDoor).DoorLocation);
        }

        private void ResetGame(bool displayMessage)
        {
            if (displayMessage)
            {
                MessageBox.Show($"You found me in {Moves} moves!");
                //Where did I find the opponent?
                IHidingPlace foundLocation = CurrentLocation as IHidingPlace;
                description.Text =
                    $"Your opponent was found in {Moves} moves, it was hiding in {foundLocation.HidingPlace}.";
            }
            Moves = 0;
            hide.Visible = true;
            goHere.Visible = false;
            check.Visible = false;
            goThroughTheDoor.Visible = false;
            exits.Visible = false;
        }

        private void RedrawForm()
        {
            exits.Items.Clear();
            for (int i = 0; i < CurrentLocation.Exits.Length; i++)
            {
                exits.Items.Add(CurrentLocation.Exits[i].Name);
            }

            //foreach (var exitLocation in CurrentLocation.Exits)
            //{
            //    exits.Items.Add(exitLocation.Name);
            //}
            exits.SelectedIndex = 0;
            description.Text = CurrentLocation.Description + "\r\n(Move number " + Moves + ".)";
            if (CurrentLocation is IHidingPlace)
            {
                IHidingPlace hidingPlace = CurrentLocation as IHidingPlace;
                check.Text = $"Check {hidingPlace.HidingPlace}";
                check.Visible = true;
            }
            else
            {
                check.Visible = false;
            }
            if (CurrentLocation is IHasExteriorDoor)
            {
                goThroughTheDoor.Visible = true;
            }
            else
            {
                goThroughTheDoor.Visible = false;
            }
        }

        private void check_Click(object sender, EventArgs e)
        {
            Moves++;
            if (opponent.Check(CurrentLocation))
            {
                ResetGame(true);
            }
            else
            {
                RedrawForm();
            }
        }

        private void hide_Click(object sender, EventArgs e)
        {
            hide.Visible = false;
            for (int i = 0; i < 10; i++)
            {
                opponent.Move();
                description.Text = $"{i}...";
                //Without Application.DoEvents, the text box doesn't refresh and
                //the program looks frozen.
                Application.DoEvents();
                System.Threading.Thread.Sleep(200);
            }
            description.Text = "Ready or not, here I come!";
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);
            goHere.Visible = true;
            exits.Visible = true;
            MoveToANewLocation(livingRoom);
        }
    }
}
