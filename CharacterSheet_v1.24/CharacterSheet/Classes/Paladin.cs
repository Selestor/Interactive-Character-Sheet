using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet
{
    public class Paladin : Classes
    {
        public Paladin(decimal level, string archetype)
        {
            HitDice = "d10";
            Archetypes.Add("Oath of Devotion");
            Archetypes.Add("Oath of the Ancients");
            Archetypes.Add("Oath of Vengeance");
            ItemProficiencies.Add("Light Armor");
            ItemProficiencies.Add("Medium Armor");
            ItemProficiencies.Add("Heavy Armor");
            ItemProficiencies.Add("Shield");
            ItemProficiencies.Add("Simple Weapon");
            ItemProficiencies.Add("Martial Weapon");
            ClassFeatures.Add("Divine Sense");
            ClassFeatures.Add("Lay on Hands");
            if(level >= 2) ClassFeatures.Add("Fighting Style");
            if (level >= 2) ClassFeatures.Add("Spellcasting");
            if (level >= 2) ClassFeatures.Add("Divine Smite");
            if (level >= 3) ClassFeatures.Add("Divine Health");
            if (level >= 3) ClassFeatures.Add("Sacred Oath");
            if (level >= 5) ClassFeatures.Add("Extra Attack");
            if (level >= 6) ClassFeatures.Add("Aura of Protection");
            if (level >= 10) ClassFeatures.Add("Aura of Courage");
            if (level >= 11) ClassFeatures.Add("Improved Divine Smite");
            if (level >= 14) ClassFeatures.Add("Cleansing Touch");
            switch (archetype)
            {
                case "":
                    break;
                case "Oath of Devotion":
                    if (level >= 7) ArchetypeFeats.Add("Aura of Devotion");
                    if (level >= 15) ArchetypeFeats.Add("Purity of Spirit");
                    if (level >= 20) ArchetypeFeats.Add("Holy Nimbus");
                    break;
                case "Oath of the Ancients":
                    if (level >= 7) ArchetypeFeats.Add("Aura of Warding");
                    if (level >= 15) ArchetypeFeats.Add("Undying Sentinel");
                    if (level >= 20) ArchetypeFeats.Add("Elder Champion");
                    break;
                case "Oath of Vengeance":
                    if (level >= 7) ArchetypeFeats.Add("Relentless Avenger");
                    if (level >= 15) ArchetypeFeats.Add("Soul of Vengeance");
                    if (level >= 20) ArchetypeFeats.Add("Avenging Angel");
                    break;
            }
        }
    }
}