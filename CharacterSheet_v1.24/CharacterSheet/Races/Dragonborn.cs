using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet
{
    class Dragonborn : Race
    {
        private decimal _strength;
        private decimal _charisma;
        public override decimal Strength
        {
            get { return _strength + 2; }
            set { _strength = value; }
        }
        public override decimal Charisma
        {
            get { return _charisma + 1; }
            set { _charisma = value; }
        }

        public Dragonborn()
        {
            AdultSize = 0;
            AdditionalPerks.Add("Draconic Ancestry");
            AdditionalPerks.Add("Breath Weapon");
            AdditionalPerks.Add("Draconic Ancestry");
        }
    }
}
