using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet
{
    public class Gnome : Race
    {
        private decimal _intelligence;
        public override decimal Intelligence
        {
            get { return _intelligence + 2; }
            set { _intelligence = value; }
        }
        public Gnome()
        {
            AdultSize = 1;
            AdditionalPerks.Add("Darkvision");
            AdditionalPerks.Add("Gnome Cunning");
            AdditionalPerks.Add("Damage Resistance");
        }
    }
}
