using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLoss.Materials
{
    public class Material // : IMaterial
    {
        public int ID { get; set; } = 0;
        public double ThermalResistance => Thickness/Lambda;

        public double Thickness { get; set; }
        public string Name { get; set; }
        public double Lambda { get; set; }

        public Material(string name, double lambda)
        {
            ID++;
            Name = name;
            Lambda = lambda;
        }
    }
}
