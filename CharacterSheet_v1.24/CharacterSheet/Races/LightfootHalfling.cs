using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet
{
    class LightfootHalfling : Halfling
    {
        private decimal _charisma;

        public override decimal Charisma
        {
            get { return _charisma + 1; }
            set { _charisma = value; }
        }

        public LightfootHalfling()
        {
            AdditionalPerks.Add("Naturally Stealthy");
        }
    }
}
