using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnergyLoss.Materials;

namespace EnergyLoss
{
    interface IMaterialRepository
    {
        List<Material> GetMaterials();
        Material CreateMaterial(int ID, double thickness);

    }
}
