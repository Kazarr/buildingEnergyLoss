using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLoss
{
    class Concrete : Material
    {
        public override double Lenght { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override double Width { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override double GetLambda(double outSideTemp, double inSideTemp)
        {
            throw new NotImplementedException();
        }

        public override string GetName()
        {
            throw new NotImplementedException();
        }

        public override double Thickness()
        {
            throw new NotImplementedException();
        }
    }
}
