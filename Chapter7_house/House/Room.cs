using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.ComponentModel.Com2Interop;

namespace House
{
    class Room : Location
    {
        private string Decoration { get; set; }


        public Room(string name, string decoration) : base(name)
        {
            Decoration = decoration;
        }

        public override string Description
        {
            get
            {
                string description = base.Description;
                return description += $" You see {Decoration}.";
            }
        }
    }
}
