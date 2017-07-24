using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet.Weapons
{
    public class RangedWeapon
    {
        public string Name { get; set; }
        public string DamageDice { get; set; }
        public string DamageType { get; set; }
        public string WeaponKind { get; set; }
        public string WeaponSlot { get; set; }
        public bool IsFinese { get; set; }
        public int MinRange { get; set; }
        public int MaxRange { get; set; }
        public bool IsDisposable { get; set; }
    }
}
