using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet
{
    class HighElf : Elf
    {
        private decimal _intelligence;

        public override decimal Intelligence
        {
            get { return _intelligence + 1; }
            set { _intelligence = value; }
        }

        public HighElf()
        {
            ItemProficiencies.Add("Longsword");
            ItemProficiencies.Add("Shortsword");
            ItemProficiencies.Add("Shortbow");
            ItemProficiencies.Add("Longbow");
        }
    }
}
