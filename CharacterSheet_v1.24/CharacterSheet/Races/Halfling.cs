using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet
{
    public class Halfling : Race
    {
        private decimal _dextirity;

        public override decimal Dextirity
        {
            get { return _dextirity + 2; }
            set { _dextirity = value; }
        }

        public Halfling()
        {
            AdultSize = 1;
            AdditionalPerks.Add("Lucky");
            AdditionalPerks.Add("Brave");
            AdditionalPerks.Add("Halfling nimbleness");
        }
    }
}
