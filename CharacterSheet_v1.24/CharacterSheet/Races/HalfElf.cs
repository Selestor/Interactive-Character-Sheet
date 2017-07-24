using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet
{
    class HalfElf : Race
    {
        private decimal _charisma;

        public override decimal Charisma
        {
            get { return _charisma + 2; }
            set { _charisma = value; }
        }

        public HalfElf()
        {
            AdultSize = 0;
            AdditionalPerks.Add("Darkvision");
            AdditionalPerks.Add("Skill Versatility");
        }
    }
}
