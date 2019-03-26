using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLoss
{
    public class Author
    {
        private string _name;
        private string _lastName;

        public Author()
        {
            _name = "Matej";
            _lastName = "Kardos";
        }
        public Author(string name, string lastName)
        {
            _name = name;
            _lastName = lastName;
        }
    }
}
