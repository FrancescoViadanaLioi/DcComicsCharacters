using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DcCharacters.Entities.Attributes
{
    internal class Power
    {
        public string PowerName { get; set; }

        public Power(string powerName)
        {
            PowerName = powerName;
        }
        public override string ToString() => PowerName;
    }
}
