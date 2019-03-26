using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnergyLoss.Materials;

namespace EnergyLoss
{
    class MaterialRepository : IMaterialRepository
    {
        public List<Material> GetMaterials()
        {
            var list = new List<Material>()
            {
                new Material("concrete", 1.3),
                new Material("plaster", 0.15),
                new Material("dry wall", 0.22),
                new Material("ytong", 0.9),
                new Material("glass wool", 0.37),
                new Material("polystyrene", 0.31)
        };
            return list;
        }
    }
}
