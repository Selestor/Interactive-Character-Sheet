using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet
{
    public class Wizard : Classes
    {
        public Wizard(decimal level, string archetype)
        {
            HitDice = "k6";
            Archetypes.Add("School of Abjuration");
            Archetypes.Add("School of Conjuration");
            Archetypes.Add("School of Divination");
            Archetypes.Add("School of Enchantment");
            Archetypes.Add("School of Evocation");
            Archetypes.Add("School of Necromancy");
            Archetypes.Add("School of Transmutation");
            ItemProficiencies.Add("Dagger");
            ItemProficiencies.Add("Dart");
            ItemProficiencies.Add("Sling");
            ItemProficiencies.Add("Quarterstaff");
            ItemProficiencies.Add("Light Crossbow");
            ClassFeatures.Add("Spellcasting");
            ClassFeatures.Add("Arcane Recovery");
            if (level >= 2) ClassFeatures.Add("Arcane Tradition");
            if (level >= 6) ClassFeatures.Add("Arcane Tradition Feature");
            if (level >= 18) ClassFeatures.Add("Spell Mastery");
            if (level >= 20) ClassFeatures.Add("Signature Spell");
            switch (archetype)
            {
                case "":
                    break;
                case "School of Abjuration":
                    if (level >= 2) ArchetypeFeats.Add("Abjuration Savant");
                    if (level >= 2) ArchetypeFeats.Add("Arcane Ward");
                    if (level >= 6) ArchetypeFeats.Add("Projected Ward");
                    if (level >= 10) ArchetypeFeats.Add("Improved Abjuration");
                    if (level >= 14) ArchetypeFeats.Add("Spell Resistance");
                    break;
                case "School of Conjuration":
                    if (level >= 2) ArchetypeFeats.Add("Conjuration Savant");
                    if (level >= 2) ArchetypeFeats.Add("Minor Conjuration");
                    if (level >= 6) ArchetypeFeats.Add("Benign Transposition");
                    if (level >= 10) ArchetypeFeats.Add("Focused Conjuration");
                    if (level >= 14) ArchetypeFeats.Add("Durable Summons");
                    break;
                case "School of Divination":
                    if (level >= 2) ArchetypeFeats.Add("Divination Savant");
                    if (level >= 2) ArchetypeFeats.Add("Portent");
                    if (level >= 6) ArchetypeFeats.Add("Expert Divination");
                    if (level >= 10) ArchetypeFeats.Add("The Third Eye");
                    if (level >= 14) ArchetypeFeats.Add("Greater Portent");
                    break;
                case "School of Enchantment":
                    if (level >= 2) ArchetypeFeats.Add("Enchantment Savant");
                    if (level >= 2) ArchetypeFeats.Add("Hypnotic Gaze");
                    if (level >= 6) ArchetypeFeats.Add("Instinctive Charm");
                    if (level >= 10) ArchetypeFeats.Add("Split Enchantment");
                    if (level >= 14) ArchetypeFeats.Add("Alter Memories");
                    break;
                case "School of Evocation":
                    if (level >= 2) ArchetypeFeats.Add("Evocation Savant");
                    if (level >= 6) ArchetypeFeats.Add("Potent Cantrips");
                    if (level >= 10) ArchetypeFeats.Add("Empowered Evocations");
                    if (level >= 14) ArchetypeFeats.Add("Overchannel");
                    break;
                case "School of Necromancy":
                    if (level >= 2) ArchetypeFeats.Add("Necromancy Savant");
                    if (level >= 2) ArchetypeFeats.Add("Grim Harvest");
                    if (level >= 6) ArchetypeFeats.Add("Undead Thralls");
                    if (level >= 10) ArchetypeFeats.Add("Inured to Undeath");
                    if (level >= 14) ArchetypeFeats.Add("Command Undead");
                    break;
                case "School of Transmutation":
                    if (level >= 2) ArchetypeFeats.Add("Transmutation Savant");
                    if (level >= 2) ArchetypeFeats.Add("Minor Alchemy");
                    if (level >= 6) ArchetypeFeats.Add("Transmuter's Stone");
                    if (level >= 10) ArchetypeFeats.Add("Shapechanger");
                    if (level >= 14) ArchetypeFeats.Add("Master Transmuter");
                    break;
            }
        }
    }
}
