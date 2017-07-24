using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet
{
    public class Bard : Classes
    {
        public Bard(decimal level, string archetype)
        {
            HitDice = "d8";
            Archetypes.Add("College of Lore");
            Archetypes.Add("College of Valor");
            ItemProficiencies.Add("Light Armor");
            ItemProficiencies.Add("Simple Weapon");
            ItemProficiencies.Add("Longsword");
            ItemProficiencies.Add("Rapier");
            ItemProficiencies.Add("Shortsword");
            ItemProficiencies.Add("Hand Crossbow");
            ClassFeatures.Add("Spellcasting");
            ClassFeatures.Add("Bardic Inspiration");
            if (level >= 2) ClassFeatures.Add("Jack of all Trades");
            if (level >= 2) ClassFeatures.Add("Song of Rest");
            if (level >= 3) ClassFeatures.Add("Bard College");
            if (level >= 3) ClassFeatures.Add("Expertise");
            if (level >= 5) ClassFeatures.Add("Font of Inspiration");
            if (level >= 6) ClassFeatures.Add("Countercharm");
            if (level >= 10) ClassFeatures.Add("Magical Secrets");
            if (level >= 20) ClassFeatures.Add("Superior Inspiration");
            switch (archetype)
            {
                case "":
                    break;
                case "College of Lore":
                    if (level >= 3) ArchetypeFeats.Add("Bonus Proficiencies");
                    if (level >= 3) ArchetypeFeats.Add("Cutting Word");
                    if (level >= 6) ArchetypeFeats.Add("Additional Magical Secrets");
                    if (level >= 14) ArchetypeFeats.Add("Peerless Skill");
                    break;
                case "College of Valor":
                    if (level >= 3) ItemProficiencies.Add("Medium Amor");
                    if (level >= 3) ItemProficiencies.Add("Shields");
                    if (level >= 3) ItemProficiencies.Add("Martial");
                    if (level >= 3) ArchetypeFeats.Add("Combat Inspiration");
                    if (level >= 6) ArchetypeFeats.Add("Extra Attack");
                    if (level >= 14) ArchetypeFeats.Add("Battle Magic");
                    break;
            }
        }
    }
}
