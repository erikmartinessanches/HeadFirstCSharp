using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beehive_with_interfaces
{
    class Bee
    {
        private const double HoneyUnitsConsumedPerMg = 0.25;

        public double WeightMg { get; private set; }

        public Bee(double weightMg)
        {
            WeightMg = weightMg;
        }

        public virtual double HoneyConsumptionRate() => WeightMg * HoneyUnitsConsumedPerMg;
    }
}
