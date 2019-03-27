using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnergyLoss.Materials;

namespace EnergyLoss
{
    public class Construction : ISurface
    {
        private double _lenght;
        private double _width;
        public string Name { get; set; }
        private List<Material> _materials;

        public Construction(List<Material> materials, string name, double lenght, double width)
        {
            _materials = materials;
            Name = name;
            _lenght = lenght;
            _width = width;
        }
        public double GetThermalResistance()
        {
            double result = 0;
            double materialThermalResistance = 0;
            foreach(Material m in _materials)
            {
                materialThermalResistance += m.ThermalResistance;
            }
            return result = (1 / materialThermalResistance)*(GetSurface());
        }
        public double GetSurface()
        {
            return _lenght * _width;
        }

        override
        public string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Name}");
            sb.Append($"{GetThermalResistance()}");
            return sb.ToString();
        }
    }
}
