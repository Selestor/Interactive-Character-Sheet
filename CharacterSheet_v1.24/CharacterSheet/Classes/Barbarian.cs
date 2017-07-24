using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet
{
    public class Barbarian : Classes
    {
        public Barbarian(decimal level, string archetype)
        {
            HitDice = "d12";
            Archetypes.Add("Berserker");
            Archetypes.Add("Totem Warrior");
            ItemProficiencies.Add("Light Armor");
            ItemProficiencies.Add("Medium Armor");
            ItemProficiencies.Add("Shields");
            ItemProficiencies.Add("Simple Weapon");
            ItemProficiencies.Add("Martial Weapon");
            ClassFeatures.Add("Rage");
            ClassFeatures.Add("Unarmored Defense");
            if (level >= 2) ClassFeatures.Add("Reckless Attack");
            if (level >= 2) ClassFeatures.Add("Danger Sense");
            if (level >= 3) ClassFeatures.Add("Primal Path");
            if (level >= 5) ClassFeatures.Add("Extra Attack");
            if (level >= 5) ClassFeatures.Add("Fast Movement");
            if (level >= 7) ClassFeatures.Add("Feral Instinct");
            if (level >= 9) ClassFeatures.Add("Brutal Critical");
            if (level >= 11) ClassFeatures.Add("Relentless Rage");
            if (level >= 15) ClassFeatures.Add("Persistent Rage");
            if (level >= 18) ClassFeatures.Add("Indomitable Might");
            if (level >= 20) ClassFeatures.Add("Primal Champion");
            switch (archetype)
            {
                case "":
                    break;
                case "Totem Warrior":
                    if (level >= 3) ArchetypeFeats.Add("Spirit Seeker");
                    if (level >= 3) ArchetypeFeats.Add("Totem Spirit");
                    if (level >= 6) ArchetypeFeats.Add("Aspect of the Beast");
                    if (level >= 10) ArchetypeFeats.Add("Spirit Walker");
                    if (level >= 14) ArchetypeFeats.Add("Totem Attunement");
                    break;
                case "Berserker":
                    if (level >= 3) ArchetypeFeats.Add("Frenzy");
                    if (level >= 6) ArchetypeFeats.Add("Mindless Rage");
                    if (level >= 10) ArchetypeFeats.Add("Intimidating Presence");
                    if (level >= 14) ArchetypeFeats.Add("Retaliation");
                    break;
            }
        }
    }
}
