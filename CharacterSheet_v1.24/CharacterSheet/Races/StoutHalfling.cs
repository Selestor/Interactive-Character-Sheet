using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet
{
    class StoutHalfling: Halfling
    {
        private decimal _constitution;

        public override decimal Constitution
        {
            get { return _constitution + 1; }
            set { _constitution = value; }
        }

        public StoutHalfling()
        {
            AdditionalPerks.Add("Stout Resilience");
        }
    }
}
