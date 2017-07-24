using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet
{
    class HillDwarf : Dwarf
    {
        private decimal _wisdom;

        public override decimal Wisdom
        {
            get { return _wisdom + 1; }
            set { _wisdom = value; }
        }

        public HillDwarf()
        {
            AdditionalPerks.Add("Dwarven Toughness");
        }
    }
}
