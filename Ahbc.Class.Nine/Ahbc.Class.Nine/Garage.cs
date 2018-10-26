using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahbc.Class.Nine
{
    public class Garage
    {
        private int _streetNumber;
        private string _streetName;

        public Garage()
        {
            _streetNumber = 1234;
            _streetName = "Default Street Name";
        }

        public Garage(int streetNumber, string streetName)
        {
            this._streetNumber = streetNumber;
            this._streetName = streetName;
        }

        public string GetAddress()
        {
            return $"{_streetNumber} {_streetName}";
        }
    }
}
