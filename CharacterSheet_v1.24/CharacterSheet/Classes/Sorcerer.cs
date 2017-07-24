using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet
{
    public class Sorcerer : Classes
    {
        public Sorcerer(decimal level, string archetype)
        {
            HitDice = "k6";
            Archetypes.Add("Draconic Bloodline");
            Archetypes.Add("Wild Magic");
            ItemProficiencies.Add("Dagger");
            ItemProficiencies.Add("Dart");
            ItemProficiencies.Add("Sling");
            ItemProficiencies.Add("Quarterstaff");
            ItemProficiencies.Add("Light Crossbow");
            ClassFeatures.Add("Spellcasting");
            ClassFeatures.Add("Sorcerous Orgin");
            if (level >= 2) ClassFeatures.Add("Font of Magic");
            if (level >= 3) ClassFeatures.Add("Metamagic");
            if (level >= 6) ClassFeatures.Add("Sorcerous Origin Feature");
            if (level >= 10) ClassFeatures.Add("Metamagic");
            if (level >= 14) ClassFeatures.Add("Sorcerous Origin Feature");
            if (level >= 17) ClassFeatures.Add("Metamagic");
            if (level >= 18) ClassFeatures.Add("Sorcerous Origin Feature");
            if (level >= 20) ClassFeatures.Add("Sorcerous Restoration");
            switch (archetype)
            {
                case "":
                    break;
                case "Draconic Bloodline":
                    if (level >= 1) ArchetypeFeats.Add("Draconic Ancestor");
                    if (level >= 1) ArchetypeFeats.Add("Draconic Resilience");
                    if (level >= 6) ArchetypeFeats.Add("Elemental Affinity");
                    if (level >= 14) ArchetypeFeats.Add("Dragon Wings");
                    if (level >= 18) ArchetypeFeats.Add("Draconic Presence");
                    break;
                case "Wild Magic":
                    if (level >= 1) ArchetypeFeats.Add("Wild Magic Surge");
                    if (level >= 1) ArchetypeFeats.Add("Tides of Chaos");
                    if (level >= 6) ArchetypeFeats.Add("Bend Luck");
                    if (level >= 14) ArchetypeFeats.Add("Controlled Chaos");
                    if (level >= 18) ArchetypeFeats.Add("Spell Bombardment");
                    break;
            }
        }
    }
}
