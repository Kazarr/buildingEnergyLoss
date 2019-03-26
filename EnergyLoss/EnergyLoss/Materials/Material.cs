using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLoss.Materials
{
    class Material : IMaterial
    {
        public double ThermalResistance => Thickness/Lambda;

        public double Thickness { get; set; }
        public string Name { get; set; }
        public double Lambda { get; set; }
    }
}
