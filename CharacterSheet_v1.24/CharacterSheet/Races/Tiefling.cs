using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet
{
    class Tiefling : Race
    {
        private decimal _intelligence;
        private decimal _charisma;
        public override decimal Intelligence
        {
            get { return _intelligence + 1; }
            set { _intelligence = value; }
        }
        public override decimal Charisma
        {
            get { return _charisma + 2; }
            set { _charisma = value; }
        }

        public Tiefling()
        {
            AdultSize = 0;
            AdditionalPerks.Add("Darkvision");
            AdditionalPerks.Add("Infernal Legacy");
            AdditionalPerks.Add("Hellish Resistance");
        }
    }
}
