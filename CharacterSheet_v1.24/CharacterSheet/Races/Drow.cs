using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterSheet
{
    public class Drow : Elf
    {
        private decimal _charisma; 

        public override decimal Charisma
        {
            get { return _charisma +1; }
            set { _charisma = value; }
        }

        public Drow()
        {
            ItemProficiencies.Add("Shortsword");
            ItemProficiencies.Add("Rapier");
            ItemProficiencies.Add("Hand Crossbow");
        }
    }
}
