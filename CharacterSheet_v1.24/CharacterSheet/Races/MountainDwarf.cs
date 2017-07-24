using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet
{
    class MountainDwarf : Dwarf
    {
        private decimal _strength;

        public override decimal Strength
        {
            get { return _strength + 2; }
            set { _strength = value; }
        }

        public MountainDwarf()
        {
            ItemProficiencies.Add("Light Armor");
            ItemProficiencies.Add("Medium Armor");
        }
    }
}
