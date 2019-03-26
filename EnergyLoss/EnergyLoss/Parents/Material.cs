using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLoss
{
    public abstract class Material : IMaterial
    {
        public double Lambda { get; set; }
        public double Lenght { get; set; }
        public double Width { get; set; }

        public string GetName()
        {
            throw new NotImplementedException();
        }

        public double Thickness()
        {
            throw new NotImplementedException();
        }

        double IMaterial.Lambda()
        {
            throw new NotImplementedException();
        }
    }
}
