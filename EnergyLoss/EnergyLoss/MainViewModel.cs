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
        public List<Material> RoofMaterial { get; set; } = new List<Material>();
        public List<Material> WallMaterial { get; set; } = new List<Material>();
        public List<Material> FloorMaterial { get; set; } = new List<Material>();



        public void GetRoofMaterilsId()
        {

        }

    }
}
