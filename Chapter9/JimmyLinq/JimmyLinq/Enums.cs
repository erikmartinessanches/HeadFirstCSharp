using System;
using System.Collections.Generic;
using System.Text;

namespace JimmyLinq
{
    enum Critics {
        MuddyCritic,
        RottenTornadoes,
    }
    enum PriceRange {
        Cheap,
        Expensive,
    }
    class Review {
        public int Issue { get; set; }
        public Critics Critic { get; set; }
        public double Score { get; set; }
    }
}
