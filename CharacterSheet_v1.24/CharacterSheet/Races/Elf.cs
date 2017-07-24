using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet
{
    public class Elf : Race
    {
        private decimal _dextirity;

        public override decimal Dextirity
        {
            get { return _dextirity + 2; }
            set { _dextirity = value; }
        }

        public Elf()
        {
            AdultSize = 0;
            AdditionalPerks.Add("Darkvision");
            AdditionalPerks.Add("Fey Ancestry");
            AdditionalPerks.Add("Trance");
            AdditionalPerks.Add("Keen Senses");
        }
    }
}
