using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet
{
    public class Fighter : Classes
    {
        public Fighter(decimal level, string archetype)
        {
            HitDice = "d10";
            Archetypes.Add("Champion");
            Archetypes.Add("Battle Master");
            Archetypes.Add("Eldritch Knight");
            ItemProficiencies.Add("Light Armor");
            ItemProficiencies.Add("Medium Armor");
            ItemProficiencies.Add("Heavy Armor");
            ItemProficiencies.Add("Shields");
            ItemProficiencies.Add("Simple Weapon");
            ItemProficiencies.Add("Martial Weapon");
            ClassFeatures.Add("Fighting Style");
            ClassFeatures.Add("Second Wind");
            if(level >= 2) ClassFeatures.Add("Action Surge");
            if (level >= 3) ClassFeatures.Add("Martial Archetype");
            if (level >= 5) ClassFeatures.Add("Extra Attack");
            if (level >= 9) ClassFeatures.Add("Indomitable");
            switch (archetype)
            {
                case "":
                    break;
                case "Champion":
                    if (level >= 3) ArchetypeFeats.Add("Improved Critical");
                    if (level >= 7) ArchetypeFeats.Add("Remarkable Athlete");
                    if (level >= 10) ArchetypeFeats.Add("Additional Fighting Style");
                    if (level >= 15) ArchetypeFeats.Add("Superior Critical");
                    if (level >= 18) ArchetypeFeats.Add("Survivor");
                    break;
                case "Battle Master":
                    if (level >= 3) ArchetypeFeats.Add("Combat Superiority");
                    if (level >= 3) ArchetypeFeats.Add("Student of War");
                    if (level >= 7) ArchetypeFeats.Add("Know Your Enemy");
                    if (level >= 10) ArchetypeFeats.Add("Improved Combat Superiority");
                    if (level >= 15) ArchetypeFeats.Add("Relentless");
                    break;
                case "Eldritch Knight":
                    if (level >= 3) ArchetypeFeats.Add("Spellcasting");
                    if (level >= 3) ArchetypeFeats.Add("Weapon Bond");
                    if (level >= 7) ArchetypeFeats.Add("War Magic");
                    if (level >= 10) ArchetypeFeats.Add("Eldritch Strike");
                    if (level >= 15) ArchetypeFeats.Add("Arcane Charge");
                    if (level >= 18) ArchetypeFeats.Add("Improved War Magic");
                    break;
            }
        }
    }
}
