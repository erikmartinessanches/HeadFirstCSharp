using System;
using System.Collections.Generic;
using System.Text;

namespace Covariance
{
    class Penguin
    {
        public string Name { get; set; }
        public virtual void Fly(string destination)
        {
            Console.WriteLine($"{this} can't fly to {destination}");
        }
        public override string ToString()
        {
            return $"A penguin named {Name}";
        }
        public static void FlyAway(List<Bird> flock, string destination)
        {
            foreach (Bird bird in flock)
            {
                bird.Fly(destination);
            }
        }
    }
}
