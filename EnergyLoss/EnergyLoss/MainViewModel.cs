using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnergyLoss.Materials;

namespace EnergyLoss
{
    public class MainViewModel
    {
        public List<int> RoofMaterialId { get; set; }
        public List<int> WallMaterialId { get; set; }
        public List<int> FloorMaterialId { get; set; }

        public double RoofWidth { get; set; }
        public double RoofLenght { get; set; }

        public double WallWidth { get; set; }
        public double WallLenght { get; set; }

        public double FloorWidth { get; set; }
        public double FloorLenght { get; set; }

        public List<double> RoofMaterialThickness { get; set; }
        public List<double> WallMaterialThickness { get; set; }
        public List<double> FloorMaterialThickness { get; set; }

        public Roof Roof { get; set; }
        public Wall Wall { get; set; }
        public Floor Floor { get; set; }

        private MaterialRepository _materials;

        public MainViewModel()
        {
            RoofMaterialId = new List<int>();
            WallMaterialId = new List<int>();
            FloorMaterialId = new List<int>();
            RoofMaterialThickness = new List<double>();
            WallMaterialThickness = new List<double>();
            FloorMaterialThickness = new List<double>();
            _materials = new MaterialRepository();
        }

        private Material CreateMaterial(int ID, double thickness)
        {
            return _materials.CreateMaterial(ID, thickness);
        }

        public List<Material> GetMaterials()
        {
            return _materials.GetMaterials();
        }

        public void CreateRoof()
        {
            Roof = new Roof(MakeMaterialsForRoof(), nameof(Roof), RoofLenght, RoofWidth);
        }

        private List<Material> MakeMaterialsForRoof()
        {
            List<Material> ret = new List<Material>();
            for(int i = 0; i < RoofMaterialId.Count; i++)
            {
                ret.Add(CreateMaterial(RoofMaterialId[i], RoofMaterialThickness[i]));
            }
            return ret;
        }
        public string RoofToString()
        {
            return Roof.ToString();
        }
    }
}
