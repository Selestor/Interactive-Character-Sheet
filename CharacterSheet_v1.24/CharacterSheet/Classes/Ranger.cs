using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet
{
    public class Ranger : Classes
    {
        public Ranger(decimal level, string archetype)
        {
            HitDice = "k10";
            Archetypes.Add("Hunter");
            Archetypes.Add("Beast Master");
            ItemProficiencies.Add("Light armor");
            ItemProficiencies.Add("Medium armor");
            ItemProficiencies.Add("Shield");
            ItemProficiencies.Add("Simple Weapon");
            ItemProficiencies.Add("Martial Weapon");
            ClassFeatures.Add("Favored Enemy");
            ClassFeatures.Add("Natural Explorer");
            if (level >= 2) ClassFeatures.Add("Fighting Style");
            if (level >= 2) ClassFeatures.Add("Spellcasting");
            if (level >= 3) ClassFeatures.Add("Ranger archetype");
            if (level >= 3) ClassFeatures.Add("Primeval awarness");
            if (level >= 5) ClassFeatures.Add("Extra attack");
            if (level >= 8) ClassFeatures.Add("Land's stride");
            if (level >= 10) ClassFeatures.Add("Hide in Plain Sight");
            if (level >= 14) ClassFeatures.Add("Vanish");
            if (level >= 18) ClassFeatures.Add("Feral senses");
            if (level >= 20) ClassFeatures.Add("Foe slayer");
            switch (archetype)
            {
                case "":
                    break;
                case "Hunter":
                    if (level >= 3) ArchetypeFeats.Add("Hunter's Prey");
                    if (level >= 7) ArchetypeFeats.Add("Defensive Tactics");
                    if (level >= 11) ArchetypeFeats.Add("Multiattack");
                    if (level >= 15) ArchetypeFeats.Add("Superior Hunter's Defense");
                    break;
                case "Beast Master":
                    if (level >= 3) ArchetypeFeats.Add("Ranger's Companion");
                    if (level >= 7) ArchetypeFeats.Add("Exceptional Training");
                    if (level >= 11) ArchetypeFeats.Add("Bestial Fury");
                    if (level >= 15) ArchetypeFeats.Add("Shared Spells");
                    break;
            }
        }
    }
}
