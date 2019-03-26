using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLoss
{
    class Wall : Construction
    {
        public Wall(List<IMaterial> materials, string name)  :base(materials,name)
        { }

    }
}
