using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahbc.Class.TwentyEight
{
    public class DateTimeHelper
    {
        public TimeSpan Distance(DateTime input)
        {
            return DateTime.UtcNow - input;
        }
    }
}
