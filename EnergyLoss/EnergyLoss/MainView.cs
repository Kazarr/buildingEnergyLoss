using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnergyLoss.Materials;

namespace EnergyLoss
{
    public partial class MainView : Form
    {
        private MainViewModel _mainViewModel;
        public MainView(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
            //_materialRepository = materialRepository;
            InitializeComponent();
            AddToCombos(MaterialRepository.GetMaterials());
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_NewBuilding_Click(object sender, EventArgs e)
        {
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //_mainViewModel.RoofMaterialId.Add((Material)cmb_RoofMaterial1.SelectedValue);
        }

        private void AddToCombos(List<Material> materials)
        {
            foreach(Material m in materials)
            {
                cmb_RoofMaterial1.Items.Add(m);
            } //comboboxy od jedna do dva.
            foreach(Material m in materials)
            {
                cmb_RoofMaterial2.Items.Add(m);
            }
            foreach (Material m in materials)
            {
                cmb_RoofMaterial3.Items.Add(m);
            }
            foreach (Material m in materials)
            {
                cmb_RoofMaterial4.Items.Add(m);
            }
        }
    }
}
