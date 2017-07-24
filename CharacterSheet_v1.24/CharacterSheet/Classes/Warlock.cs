using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet
{
    public class Warlock : Classes
    {
        public Warlock(decimal level, string archetype)
        {
            HitDice = "k8";
            Archetypes.Add("The Archfey");
            Archetypes.Add("The Fiend");
            Archetypes.Add("The Great Old One");
            ItemProficiencies.Add("Simple Weapon");
            ItemProficiencies.Add("Light Armors");
            ClassFeatures.Add("Otherworldly Patreon");
            ClassFeatures.Add("Pact Magic");
            if (level >= 2) ClassFeatures.Add("Eldritch Invocations");
            if (level >= 3) ClassFeatures.Add("Pact boon");
            if (level >= 6) ClassFeatures.Add("Otherworldly Patreaon Feature");
            if (level >= 11) ClassFeatures.Add("Mystic Arcanum Surge(6th level)");
            if (level >= 13) ClassFeatures.Add("Mystic Arcanum Surge(7th level)");
            if (level >= 15) ClassFeatures.Add("Mystic Arcanum Surge(8th level)");
            if (level >= 17) ClassFeatures.Add("Mystic Arcanum Surge(9th level)");
            if (level >= 20) ClassFeatures.Add("Eldritch Master");
            switch (archetype)
            {
                case "":
                    break;
                case "The Archfey":
                    if (level >= 1) ArchetypeFeats.Add("Fey Presence");
                    if (level >= 6) ArchetypeFeats.Add("Misty Escape");
                    if (level >= 10) ArchetypeFeats.Add("Beg*iling Defense");
                    if (level >= 14) ArchetypeFeats.Add("Dark Delirium");
                    break;
                case "The Fiend":
                    if (level >= 1) ArchetypeFeats.Add("Dark One's Blessing");
                    if (level >= 6) ArchetypeFeats.Add("Dark One's Own Luck");
                    if (level >= 10) ArchetypeFeats.Add("Fiendish Resilience");
                    if (level >= 14) ArchetypeFeats.Add("Hurl Through Hell");
                    break;
                case "The Great Old One":
                    if (level >= 1) ArchetypeFeats.Add("Awekened Mind");
                    if (level >= 6) ArchetypeFeats.Add("Entropic Ward");
                    if (level >= 10) ArchetypeFeats.Add("Thought Shield");
                    if (level >= 14) ArchetypeFeats.Add("Create Thrall");
                    break;
            }
        }
    }
}
