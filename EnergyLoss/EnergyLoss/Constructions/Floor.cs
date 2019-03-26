using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLoss
{
    public class Floor : Construction
    {
        public Floor(List<IMaterial> materials, string name) : base(materials, name)
        {        }
    }
}
