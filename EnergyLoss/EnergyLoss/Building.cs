using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLoss
{
    public class Building
    {
        private string _name;
        private Author _author;
        private Country _country;
        private BuildingType _buildingType;
        private double _minOutsideTemp;
        private List<Construction> _constructions;

        public Building(string name, Author author, Country country, BuildingType buildingType, double minOutsideTemp, List<Construction> constructions)
        {
            _name = name ?? throw new ArgumentNullException(nameof(name));
            _author = author ?? throw new ArgumentNullException(nameof(author));
            _country = country;
            _buildingType = buildingType;
            _minOutsideTemp = minOutsideTemp;
            _constructions = constructions ?? throw new ArgumentNullException(nameof(constructions));
        }

    }
}
