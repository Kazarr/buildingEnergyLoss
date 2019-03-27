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
            AddToCombos();
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_NewBuilding_Click(object sender, EventArgs e)
        {
        }

        private void AddToCombos()
        {
            AddMaterialToCombo(cmb_RoofMaterial1);
            AddMaterialToCombo(cmb_RoofMaterial2);
            AddMaterialToCombo(cmb_RoofMaterial3);
            AddMaterialToCombo(cmb_RoofMaterial4);
        }
        
        private void AddMaterialToCombo(ComboBox comboBox)
        {
            comboBox.DataSource = _mainViewModel.GetMaterials();
            comboBox.DisplayMember = nameof(Material.Name);
            comboBox.ValueMember = nameof(Material.ID);
            comboBox.BindingContext = new BindingContext();
        }

        private double ConvertTextBoxToDouble(TextBox textBox)
        {
           return double.Parse(textBox.Text);
        }

        private void btn_SaveRoof_Click_1(object sender, EventArgs e)
        {
            _mainViewModel.RoofMaterialId.Add((int)cmb_RoofMaterial1.SelectedValue);
            _mainViewModel.RoofMaterialThickness.Add(ConvertTextBoxToDouble(txt_Thickness1));
            _mainViewModel.RoofWidth = ConvertTextBoxToDouble(txt_RoofWidth);
            _mainViewModel.RoofLenght = ConvertTextBoxToDouble(txt_RoofLenght);
        }

        private void btn_SaveWall_Click(object sender, EventArgs e)
        {

        }

        private void btn_CreateConstruction_Click(object sender, EventArgs e)
        {
            _mainViewModel.CreateRoof();
            WriteConstructions();
        }

        private void WriteConstructions()
        {
            rtb_Constructions.AppendText(_mainViewModel.RoofToString());
        }
    }
}
