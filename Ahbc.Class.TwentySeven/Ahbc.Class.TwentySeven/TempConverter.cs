using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahbc.Class.TwentySeven
{
    public class TempConverter
    {
        public int Convert(int value, string targetUnit)
        {
            switch (targetUnit.ToUpper())
            {
                case "C":
                    return (value - 32) * 5 / 9;
                case "F":
                    return value * 9 / 5 + 32;
                default:
                    throw new ArgumentException($"{nameof(targetUnit)} is not C or F");
            }
        }
    }
}
