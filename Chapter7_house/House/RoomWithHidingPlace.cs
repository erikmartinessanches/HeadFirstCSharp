using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class RoomWithHidingPlace : Room, IHidingPlace
    {
        public RoomWithHidingPlace(string name, string decoration, string hidingPlace) : base(name, decoration)
        { 
            this.HidingPlace = hidingPlace;
        }


        public string HidingPlace { get; private set; }

        public override string Description
        {
            get { return base.Description + " Someone could hide " + HidingPlace + "."; }
        }
    }
}
