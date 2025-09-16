using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DcCharacters.Entities.Attributes
{
    internal class Skill
    {
        public string Description { get; private set; }

        public Skill(string description)
        {
            Description = description;
        }
    }
}
