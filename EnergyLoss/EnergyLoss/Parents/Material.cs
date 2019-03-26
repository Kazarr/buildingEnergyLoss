using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLoss
{
    public abstract class Material : IMaterial
    {
        public abstract double Lenght { get; set; }
        public abstract double Width { get; set; }

        public abstract double GetLambda(double outSideTemp, double inSideTemp);


        public abstract string GetName();


        public abstract double Thickness();

    }
}
