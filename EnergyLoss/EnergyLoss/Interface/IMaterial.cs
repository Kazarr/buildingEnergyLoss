using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLoss
{
    public interface IMaterial
    {
        double ThermalResistance { get; } //preco property?
        double Thickness { get; set; }
        string Name { get; set; }
        double Lambda { get; set; }
    }
}
