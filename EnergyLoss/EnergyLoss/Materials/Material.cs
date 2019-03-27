using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLoss.Materials
{
    public class Material  //: IMaterial
    {
        private static int _counter;
        public int ID { get; set; } = 0;
        public double ThermalResistance => Thickness/Lambda;

        public double Thickness { get; set; }
        public string Name { get; set; }
        public double Lambda { get; set; }

        public Material()
        {
            _counter++;
            ID = _counter;
        }

        public Material(string name, double lambda)
        {
            _counter++;
            ID = _counter;
            Name = name;
            Lambda = lambda;
        }
        public Material(string name, double lambda, double thickness)
        {
            
            _counter++;
            ID = _counter;
            Name = name;
            Lambda = lambda;
            Thickness = thickness;
        }
         
        override
        public string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Name}");
            sb.Append($"{ThermalResistance}");
            return sb.ToString();
        }
    }
}
