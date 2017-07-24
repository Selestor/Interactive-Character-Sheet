using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet
{
    public class Druid : Classes
    {
 public Druid(decimal level, string archetype)
        {
            HitDice = "d8";
            Archetypes.Add("Circle of the Land");
            Archetypes.Add("Circle of the Moon");
            ItemProficiencies.Add("Light Armor");
            ItemProficiencies.Add("Medium Armor");
            ItemProficiencies.Add("Club");
            ItemProficiencies.Add("Dagger");
            ItemProficiencies.Add("Dart");
            ItemProficiencies.Add("Javelin");
            ItemProficiencies.Add("Mace");
            ItemProficiencies.Add("Quarterstaff");
            ItemProficiencies.Add("Scimitar");
            ItemProficiencies.Add("Sickle");
            ItemProficiencies.Add("Sling");
            ItemProficiencies.Add("Spear");
            ItemProficiencies.Add("Herbalism Kit");
            ClassFeatures.Add("Spellcasting");
            if (level >= 2) ClassFeatures.Add("Wild Shape");
            if (level >= 2) ClassFeatures.Add("Druidic Circle");
            if (level >= 8) ClassFeatures.Add("Timeless Body");
            if (level >= 18) ClassFeatures.Add("Beast Spells");
            if (level >= 20) ClassFeatures.Add("Archdruid");
            switch (archetype)
            {
                case "":
                    break;
                case "Circle of the Land":
                    if (level >= 2) ArchetypeFeats.Add("Bonus Contrip");
                    if (level >= 2) ArchetypeFeats.Add("Natural Recovery");
                    if (level >= 3) ArchetypeFeats.Add("Circle Spells");
                    if (level >= 6) ArchetypeFeats.Add("Lands Stride");
                    if (level >= 10) ArchetypeFeats.Add("Nature Ward");
                    if (level >= 14) ArchetypeFeats.Add("Natures's Sanctuary");
                    break;
                case "Circle of the Moon":
                    if (level >= 2) ArchetypeFeats.Add("Combat Wild Shape");
                    if (level >= 2) ArchetypeFeats.Add("Circle Forms");
                    if (level >= 6) ArchetypeFeats.Add("Primal Strike");
                    if (level >= 10) ArchetypeFeats.Add("Elemental Wild Shape");
                    if (level >= 14) ArchetypeFeats.Add("Thousand Forms");
                    break;
            }
        }
    }
}
