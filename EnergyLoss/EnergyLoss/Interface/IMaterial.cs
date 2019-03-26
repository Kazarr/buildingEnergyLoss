using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLoss
{
    public interface IMaterial
    {
        double Thickness();
        string GetName();
        double Lambda();
    }
}
