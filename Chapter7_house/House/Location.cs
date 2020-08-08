using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    abstract class Location
    {
        public string Name { get; private set; }
        public Location[] Exits;

        public Location(string name)
        {
            Name = name;
        }

        public virtual string Description
        {
            get
            {
                string description = $"You are standing in the {Name.ToLower()}. You see " +
                                     "exits to the following places: ";
                for (int i = 0; i < Exits.Length; i++)
                {
                    description += Exits[i].Name.ToLower();
                    if (i != Exits.Length - 1)
                    {
                        description += ", ";
                    }
                }
                description += ".";
                return description;
            }
        }
    }
}
