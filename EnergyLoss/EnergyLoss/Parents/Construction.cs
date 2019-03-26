using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLoss
{
    public class Construction : ISurface
    {
        private double _lenght;
        private double _width;
        public string Name { get; set; }
        private List<IMaterial> _materials;

        public Construction(List<IMaterial> materials, string name)
        {
            _materials = materials;
            Name = name;
        }
        public double GetThermalResistance()
        {
            double result = 0;
            double materialThermalResistance = 0;
            foreach(IMaterial m in _materials)
            {
                materialThermalResistance += m.ThermalResistance;
            }
            return result = 1 / materialThermalResistance;
        }
        public double GetSurface()
        {
            return _lenght * _width;
        }

    }
}
