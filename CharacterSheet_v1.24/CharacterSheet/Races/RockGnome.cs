using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet
{
    class RockGnome : Gnome
    {
        private decimal _constitution;
        public override decimal Constitution
        {
            get { return _constitution + 1; }
            set { _constitution = value; }
        }

        public RockGnome()
        {
            AdditionalPerks.Add("Artificer's Love");
            AdditionalPerks.Add("Tinker");
        }
    }
}
