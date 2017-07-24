using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet
{
    public class Dwarf : Race
    {
        private decimal _constitution;

        public override decimal Constitution
        {
            get { return _constitution + 2; }
            set { _constitution = value; }
        }

        public Dwarf()
        {
            SpeedModifier = -5;
            AdultSize = 0;
            AdditionalPerks.Add("Darkvision");
            AdditionalPerks.Add("Dwarven Resilience");
            ItemProficiencies.Add("Battleaxe");
            ItemProficiencies.Add("Handaxe");
            ItemProficiencies.Add("Throwing hammer");
            ItemProficiencies.Add("Warhammer");
        }
    }
}
