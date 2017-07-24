using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet
{
    class WoodElf : Elf
    {
        private decimal _wisdom;

        public override decimal Wisdom
        {
            get { return _wisdom + 1; }
            set { _wisdom = value; }
        }

        public WoodElf()
        {
            SpeedModifier = 5;
            AdditionalPerks.Add("Mask of the Wild");
            ItemProficiencies.Add("Longsword");
            ItemProficiencies.Add("Shortsword");
            ItemProficiencies.Add("Shortbow");
            ItemProficiencies.Add("Longbow");
        }
    }
}
