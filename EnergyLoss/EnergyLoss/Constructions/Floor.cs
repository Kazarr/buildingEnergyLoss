using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLoss
{
    class Floor : Construction
    {
        public override IMaterial Material { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override double GetArea()
        {
            throw new NotImplementedException();
        }
    }
}
