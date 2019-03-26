using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLoss
{
    class Plaster : IMaterial
    {
        public double Thickness { get; set; }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Lambda { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public double ThermalResistance => Thickness/Lambda;
    }
}
