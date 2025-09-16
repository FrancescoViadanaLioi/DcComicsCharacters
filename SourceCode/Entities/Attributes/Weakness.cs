using System;

namespace DcCharacters.Entities.Attributes
{
    internal class Weakness
    {
        public string Description { get; private set; }

        public Weakness(string description)
        {
            Description = description;
        }
    }
}
