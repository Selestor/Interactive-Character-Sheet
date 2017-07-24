using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet
{
    public class Weapon
    {
        public string Name { get; set; }
        public string DamageDice { get; set; }
        public string GreaterDamageDice { get; set; }
        public string DamageType { get; set; }
        public string WeaponKind { get; set; }
        public string WeaponSlot { get; set; }
        public bool IsFinese { get; set; }
        public bool IsDisposable { get; set; }
    }
}
/*
Unarmed strike
None
Club
Dagger
Greatclub
Handaxe
Javelin
Light hammer
Mace
Quarterstaff
Sickle
Spear
Battleaxe
Flail
Glaive
Greataxe
Greatsword
Halberd
Lance
Longsword
Maul
Morningstar
Pike
Rapier
Scimitar
Shortsword
Trident
War pick
Warhammer
Whip
*/