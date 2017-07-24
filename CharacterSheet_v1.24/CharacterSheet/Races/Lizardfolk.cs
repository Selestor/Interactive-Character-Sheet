using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet.Races
{
    class Lizardfolk : Race
    {
        private decimal _constitution;
        private decimal _naturalArmor;
        public override decimal Constitution
        {
            get { return _constitution + 2; }
            set { _constitution = value; }
        }

        public override decimal NaturalArmor
        {
            get { return _naturalArmor + 3; }
            set { _naturalArmor = value; }
        }

        public Lizardfolk()
        {
            AdultSize = 0;
            AdditionalPerks.Add("Natural Armor");
            AdditionalPerks.Add("Bite Attack");
            AdditionalPerks.Add("Hold Breath");
            AdditionalPerks.Add("Sneaky Survivalist");
        }
    }
}
