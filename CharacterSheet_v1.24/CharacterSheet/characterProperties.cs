using System.Collections.Generic;
using CharacterSheet.Items;
using CharacterSheet.Weapons;
using System.Windows.Forms;

namespace CharacterSheet
{
    public class CharacterProperties
    {
        public string Name { get; set; }
        public int SelectedClass { get; set; }
        public int Race { get; set; }
        public int Specialization { get; set; }
        public int Aligment { get; set; }
        public int Size { get; set; }
        public decimal Level { get; set; }
        public string Experience { get; set; }
        public string HitPoints { get; set; }
        public string Wounds { get; set; }
        public decimal AcBonus { get; set; }
        public decimal Strength { get; set; }
        public decimal Dextirity { get; set; }
        public decimal Constitution { get; set; }
        public decimal Intelligence { get; set; }
        public decimal Wisdom { get; set; }
        public decimal Charisma { get; set; }
        public bool StrenghtProficiency { get; set; }
        public bool DextirityProficiency { get; set; }
        public bool ConstitutionProficiency { get; set; }
        public bool IntelligenceProficiency { get; set; }
        public bool WisdomProficiency { get; set; }
        public bool CharismaProficiency { get; set; }
        public bool Acrobatics { get; set; }
        public bool Animal { get; set; }
        public bool Arcana { get; set; }
        public bool Athletics { get; set; }
        public bool Deception { get; set; }
        public bool History { get; set; }
        public bool Insight { get; set; }
        public bool Intimidation { get; set; }
        public bool Investigation { get; set; }
        public bool Medicine { get; set; }
        public bool Nature { get; set; }
        public bool Perception { get; set; }
        public bool Performance { get; set; }
        public bool Persuassion { get; set; }
        public bool Religion { get; set; }
        public bool Sleight { get; set; }
        public bool Stealth { get; set; }
        public bool Survival { get; set; }
        public List<object> Feats { get; set; } 
        public int Weapon1 { get; set; }
        public int Weapon2 { get; set; }
        public bool SpecialWeapon1 { get; set; }
        public bool SpecialWeapon2 { get; set; }
        public int Ranged1 { get; set; }
        public int Ranged2 { get; set; }
        public int Armor { get; set; }
        public int Shield { get; set; }
        public string Backpack { get; set; }
        public string Plat { get; set; }
        public string Gold { get; set; }
        public string Electrum { get; set; }
        public string Silver { get; set; }
        public string Copper { get; set; }
        public List<object> Spellslevel0 { get; set; }
        public List<object> Spellslevel1 { get; set; }
        public List<object> Spellslevel2 { get; set; }
        public List<object> Spellslevel3 { get; set; }
        public List<object> Spellslevel4 { get; set; }
        public List<object> Spellslevel5 { get; set; }
        public List<object> Spellslevel6 { get; set; }
        public List<object> Spellslevel7 { get; set; }
        public List<object> Spellslevel8 { get; set; }
        public List<object> Spellslevel9 { get; set; }
        public int Gender { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Hair { get; set; }
        public string Skin { get; set; }
        public string Eyes { get; set; }
        public string Age { get; set; }
        public string Notes { get; set; }
        public string Describtion { get; set; }
        public byte[] Avatar { get; set; }
        public byte[] Picture { get; set; }
        public List<Weapon> MeleeWeaponList { get; set; }
        public List<Armors> ArmorsList { get; set; }
        public List<RangedWeapon> RangedWeaponList { get; set; }
    }
}
