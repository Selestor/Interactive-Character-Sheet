using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet
{
    public class Rogue : Classes
    {      
        public Rogue(decimal level, string archetype)
        {
            HitDice = "d8";
            Archetypes.Add("Assasin");
            Archetypes.Add("Thief");
            Archetypes.Add("Arcane Trickster");
            ItemProficiencies.Add("Light Armor");
            ItemProficiencies.Add("Simple Weapon");
            ItemProficiencies.Add("Hand Crossbow");
            ItemProficiencies.Add("Longsword");
            ItemProficiencies.Add("Rapier");
            ItemProficiencies.Add("Shortsword");
            ItemProficiencies.Add("Thieve's Tool");
            ClassFeatures.Add("Expertise");
            ClassFeatures.Add("Sneak Attack");
            ClassFeatures.Add("Thieves' Cant");
            if(level >= 2) ClassFeatures.Add("Cunning Action");
            if (level >= 3) ClassFeatures.Add("Roguish Archetype");
            if (level >= 4) ClassFeatures.Add("Ability Score Improvement");
            if (level >= 5) ClassFeatures.Add("Uncanny Dodge");
            if (level >= 7) ClassFeatures.Add("Evasion");
            if (level >= 11) ClassFeatures.Add("Reliable Talent");
            if (level >= 14) ClassFeatures.Add("Blindsense");
            if (level >= 15) ClassFeatures.Add("Slippery Mind");
            if (level >= 18) ClassFeatures.Add("Elusive");
            if (level >= 20) ClassFeatures.Add("Stroke of Luck");
            switch (archetype)
            {
                case "":
                    break;
                case "Assasin":
                    if (level >= 3) ItemProficiencies.Add("Disguise Kit");
                    if (level >= 3) ItemProficiencies.Add("Poisoners Kit");
                    if (level >= 3) ArchetypeFeats.Add("Assasinate");
                    if (level >= 9) ArchetypeFeats.Add("Inflirtation Expertise");
                    if (level >= 13) ArchetypeFeats.Add("Imposter");
                    if (level >= 17) ArchetypeFeats.Add("Death Strike");
                    break;
                case "Thief":
                    if (level >= 3) ArchetypeFeats.Add("Fast Hands");
                    if (level >= 3) ArchetypeFeats.Add("Second Story Work");
                    if (level >= 9) ArchetypeFeats.Add("Supreme Sneak");
                    if (level >= 13) ArchetypeFeats.Add("Use Magic Device");
                    if (level >= 17) ArchetypeFeats.Add("Thief's Reflexes");
                    break;
                case "Arcane Trickster":
                    if (level >= 3) ArchetypeFeats.Add("Spellcasting");
                    if (level >= 3) ArchetypeFeats.Add("Mage Hand Legerdemain");
                    if (level >= 9) ArchetypeFeats.Add("Magic Ambush");
                    if (level >= 13) ArchetypeFeats.Add("Versatile Trickster");
                    if (level >= 17) ArchetypeFeats.Add("Spell Thief");
                    break;
            }
        }
    }
}
