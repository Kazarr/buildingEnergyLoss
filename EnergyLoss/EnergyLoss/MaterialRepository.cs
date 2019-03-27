using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnergyLoss.Materials;

namespace EnergyLoss
{
    public class MaterialRepository : IMaterialRepository
    {
        private List<Material> _materials = new List<Material>()
        {
            new Material("concrete", 1.03),
            new Material("plaster", 0.15),
            new Material("dry wall", 0.22),
            new Material("ytong", 0.09),
            new Material("glass wool", 0.037),
            new Material("polystyrene", 0.031)
        };

        public List<Material> GetMaterials()
        {
            return _materials;
        }
        public Material CreateMaterial(int ID, double thickness)
        {
            Material ret = new Material();
            foreach(Material m in _materials)
            {
                if (ID == m.ID)
                {
                    ret.Name = m.Name;
                    ret.Lambda = m.Lambda;
                    ret.Thickness = thickness;
                    break;
                }
            }
            return ret;
        }
    }
}
