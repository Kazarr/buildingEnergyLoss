using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnergyLoss.Materials;

namespace EnergyLoss
{
    public class Roof : Construction
    {
        public Roof(List<Material> materials, string name, double lenght, double width) :base(materials,name, lenght, width)
        {
        }
    }
}
