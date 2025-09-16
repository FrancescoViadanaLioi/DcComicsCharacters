using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DcCharacters.Entities.Attributes.Enum;

namespace DcCharacters.Entities.Attributes
{
    internal class Gadget
    {
        public string GadgetName { get; private set; }
        public GadgetKind Kind {get; private set; }

        public Gadget(string gadgetName, GadgetKind kind)
        {
            GadgetName = gadgetName;
            Kind = kind;
        }
    }
}
