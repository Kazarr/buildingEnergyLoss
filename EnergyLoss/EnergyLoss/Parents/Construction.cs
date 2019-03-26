using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLoss
{
    public abstract class Construction : ISurface
    {
        public List<Material> Material { get;set; }

        public double GetSurface()
        {
            throw new NotImplementedException();
        }
    }
}
