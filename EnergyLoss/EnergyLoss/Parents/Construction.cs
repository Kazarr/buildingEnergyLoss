using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLoss
{
    public abstract class Construction : ISurface
    {
        public abstract IMaterial Material { get;set; }

        public abstract double GetArea();

    }
}
