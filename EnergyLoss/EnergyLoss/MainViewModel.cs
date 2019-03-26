using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnergyLoss
{
    public class MainViewModel
    {
        public List<int> RoofMaterialId { get; set; } = new List<int>();
        public List<double> RoofMaterialsThickness { get; set; } = new List<double>();
        public List<int> WallMaterialId { get; set; } = new List<int>();
        public List<double> WallMaterialsThickness { get; set; } = new List<double>();
        public List<int> FloorMaterialId { get; set; } = new List<int>();
        public List<double> FloorMaterialsThickness { get; set; } = new List<double>();



        public void GetRoofMaterilsId()
        {

        }

    }
}
