using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLoss
{
    class Roof : Construction
    {
        public Roof(List<IMaterial> materials, string name) :base(materials,name)
        {        }
    }
}
