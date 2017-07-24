using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet
{
    class HalfOrc:Race
    {
        private decimal _strength;
        private decimal _constitution;

        public override decimal Strength
        {
            get { return _strength + 2; }
            set { _strength = value; }
        }
        public override decimal Constitution
        {
            get { return _constitution + 1; }
            set { _constitution = value; }
        }

        public HalfOrc()
        {
            AdultSize = 0;
            AdditionalPerks.Add("Darkvision");
            AdditionalPerks.Add("Relentless Endurance");
            AdditionalPerks.Add("Savage Attacks");
        }
    }
}
