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


        public virtual string GetName()
        {

        }


        public virtual double Thickness()
        {

        }

    }
}
