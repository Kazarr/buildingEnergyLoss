using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLoss
{
    class GlassWool : IMaterial
    {
        public double Thickness { get; set; }
        public string Name { get; set; }
        public double Lambda { get; set; }

        public double ThermalResistance => Thickness / Lambda;
    }
}
