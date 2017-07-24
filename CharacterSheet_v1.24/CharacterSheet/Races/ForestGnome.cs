using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet
{
    class ForestGnome : Gnome
    {
        private decimal _dextirity;
        public override decimal Dextirity
        {
            get { return _dextirity + 1; }
            set { _dextirity = value; }
        }

        public ForestGnome()
        {
            AdditionalPerks.Add("Natural Illusionist");
            AdditionalPerks.Add("Speak with Small Beasts");
        }
    }
}
