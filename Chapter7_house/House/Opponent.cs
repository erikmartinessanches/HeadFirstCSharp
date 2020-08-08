using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Opponent
    {
        private Location myLocation;
        private Random random;

        public Opponent(Location startingLocation)
        {
            myLocation = startingLocation;
            random = new Random();
        }

        public void Move()
        {
            bool hidden = false;
            while (!hidden)
            {
                //If my location has an exterior door, "flip a coin" to determine whether to go through the exterior door.
                if (myLocation is IHasExteriorDoor)
                {
                    //Save locationWithDoor as a IHasExteriorDoor.
                    IHasExteriorDoor locationWithDoor = myLocation as IHasExteriorDoor;
                    if (random.Next(2)==1)
                    {
                        //In that case, move through the exteroir door by reassigning myLocation to locationWithDoor.DoorLocation, brilliantly.
                        myLocation = locationWithDoor.DoorLocation;
                    }
                }
                //Move myself to a location via one of the exits, randomly.
                myLocation = myLocation.Exits[random.Next(myLocation.Exits.Length)];
                if (myLocation is IHidingPlace)
                {
                    hidden = true;
                }
            }
        }

        public bool Check(Location location)
        {
            if (myLocation.Equals(location))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
