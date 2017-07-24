using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet
{
    public class Monk : Classes
    {
        public Monk(decimal level, string archetype)
        {
            HitDice = "d8";
            Archetypes.Add("Way of the Open Hand");
            Archetypes.Add("Way of Shadow");
            Archetypes.Add("Way of the Four Elements");
            ItemProficiencies.Add("Simple Weapon");
            ItemProficiencies.Add("Shorsword");
            ClassFeatures.Add("Unarmored Defense");
            ClassFeatures.Add("Martial Arts");
            if(level >= 2) ClassFeatures.Add("Ki");
            if (level >= 2) ClassFeatures.Add("Unarmored movement");
            if (level >= 3) ClassFeatures.Add("Monastic Tradition");
            if (level >= 3) ClassFeatures.Add("Deflect Missles");
            if (level >= 4) ClassFeatures.Add("Slow Fall");
            if (level >= 5) ClassFeatures.Add("Extra Attack");
            if (level >= 5) ClassFeatures.Add("Stunning Strike");
            if (level >= 6) ClassFeatures.Add("Ki Empowered Strikes");
            if (level >= 7) ClassFeatures.Add("Evasion");
            if (level >= 7) ClassFeatures.Add("Stillness of Mind");
            if (level >= 10) ClassFeatures.Add("Purity of Body");
            if (level >= 13) ClassFeatures.Add("Tongue of Moon");
            if (level >= 14) ClassFeatures.Add("Diamond Soul");
            if (level >= 15) ClassFeatures.Add("Timeless Body");
            if (level >= 18) ClassFeatures.Add("Empty Body");
            if (level >= 18) ClassFeatures.Add("Perfect Self");
            switch (archetype)
            {
                case "":
                    break;
                case "Way of the Open Hand":
                    if (level >= 3) ArchetypeFeats.Add("Open Hand Technique");
                    if (level >= 6) ArchetypeFeats.Add("Wholeness of Body");
                    if (level >= 11) ArchetypeFeats.Add("Tranquility");
                    if (level >= 17) ArchetypeFeats.Add("Quivering Palm");
                    break;
                case "Way of Shadow":
                    if (level >= 3) ArchetypeFeats.Add("Shadow Arts");
                    if (level >= 6) ArchetypeFeats.Add("Shadow Step");
                    if (level >= 11) ArchetypeFeats.Add("Cloak of Shadows");
                    if (level >= 17) ArchetypeFeats.Add("Opportunity");
                    break;
                case "Way of the Four Elements":
                    if (level >= 3) ArchetypeFeats.Add("Disciple of the Elements");
                    if (level >= 3) ArchetypeFeats.Add("Elemental Disciplines");
                    break;
            }
        }
    }
}
