using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet
{
    public class Race
    {
        public virtual decimal Strength { get; set; }
        public virtual decimal Dextirity { get; set; }
        virtual public decimal Constitution { get; set; }
        virtual public decimal Intelligence { get; set; }
        virtual public decimal Wisdom { get; set; }
        virtual public decimal Charisma { get; set; }
        virtual public decimal NaturalArmor { get; set; }
        public int AdultSize;
        public int SpeedModifier;
        public List<string> AdditionalPerks = new List<string>();
        public List<string> ItemProficiencies = new List<string>();
    }
}
