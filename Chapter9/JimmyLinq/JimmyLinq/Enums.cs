using System;
using System.Collections.Generic;
using System.Text;

namespace JimmyLinq
{
    public enum Critics {
        MuddyCritic,
        RottenTornadoes,
    }
    public enum PriceRange {
        Cheap,
        Expensive,
    }
    public class Review {
        public int Issue { get; set; }
        public Critics Critic { get; set; }
        public double Score { get; set; }
    }
}
