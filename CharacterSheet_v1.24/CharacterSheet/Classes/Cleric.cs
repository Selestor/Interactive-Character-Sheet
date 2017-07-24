using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet
{
    public class Cleric : Classes
    {
        public Cleric(decimal level, string archetype)
        {
            HitDice = "d8";
            Archetypes.Add("Knowledge");
            Archetypes.Add("Life");
            Archetypes.Add("Light");
            Archetypes.Add("Tempest");
            Archetypes.Add("Nature");
            Archetypes.Add("Trickery");
            Archetypes.Add("War");
            ItemProficiencies.Add("Light Armor");
            ItemProficiencies.Add("Medium Armor");
            ItemProficiencies.Add("Shields");
            ItemProficiencies.Add("Simple Weapon");
            ClassFeatures.Add("Spellcasting");
            ClassFeatures.Add("Divine Domain");
            if (level >= 2) ClassFeatures.Add("Channel Divinity");
            if (level >= 5) ClassFeatures.Add("Destroy Undead");
            if (level >= 10) ClassFeatures.Add("Divine Intervention");
            if (level >= 20) ClassFeatures.Add("Superior Inspiration");
            switch (archetype)
            {
                case "":
                    break;
                case "Knowledge":
                    if (level >= 1) ArchetypeFeats.Add("Blessing of Knowledge");
                    if (level >= 2) ArchetypeFeats.Add("Channel Divinity: Knowledge of the Ages");
                    if (level >= 6) ArchetypeFeats.Add("Channel Divinity: Read Thoughts");
                    if (level >= 8) ArchetypeFeats.Add("Potent Spellcasting");
                    if (level >= 17) ArchetypeFeats.Add("Visions of the Past");
                    break;
                case "Life":
                    if (level >= 1) ArchetypeFeats.Add("Blessing of Light");
                    if (level >= 1) ItemProficiencies.Add("Heavy Armor");
                    if (level >= 2) ArchetypeFeats.Add("Channel Divinity: Preserve Life");
                    if (level >= 6) ArchetypeFeats.Add("Blessed Healer");
                    if (level >= 8) ArchetypeFeats.Add("Divine Strike");
                    if (level >= 17) ArchetypeFeats.Add("Supreme Healing");
                    break;
                case "Light":
                    if (level >= 1) ArchetypeFeats.Add("Bonus Contrip");
                    if (level >= 1) ArchetypeFeats.Add("Warding Flare");
                    if (level >= 2) ArchetypeFeats.Add("Channel Divinity: Radiance of the Dawn");
                    if (level >= 6) ArchetypeFeats.Add("Improved Flare");
                    if (level >= 8) ArchetypeFeats.Add("Potent Spellcasting");
                    if (level >= 17) ArchetypeFeats.Add("Corona of Light");
                    break;
                case "Nature":
                    if (level >= 1) ArchetypeFeats.Add("Acolyte of Nature");
                    if (level >= 1) ItemProficiencies.Add("Heavy Armor");
                    if (level >= 2) ArchetypeFeats.Add("Channel Divinity: Charm Animals and Plants");
                    if (level >= 6) ArchetypeFeats.Add("Dampen Elements");
                    if (level >= 8) ArchetypeFeats.Add("Divine Strike");
                    if (level >= 17) ArchetypeFeats.Add("Master of Nature");
                    break;
                case "Tempest":
                    if (level >= 1) ItemProficiencies.Add("Martial");
                    if (level >= 1) ItemProficiencies.Add("Heavy Armor");
                    if (level >= 1) ArchetypeFeats.Add("Watch of the Storm");
                    if (level >= 2) ArchetypeFeats.Add("Channel Divinity: Destructive Wrath");
                    if (level >= 6) ArchetypeFeats.Add("Thunderbolt Strike");
                    if (level >= 8) ArchetypeFeats.Add("Divine Strike");
                    if (level >= 17) ArchetypeFeats.Add("Stormborn");
                    break;
                case "Trickery":
                    if (level >= 1) ArchetypeFeats.Add("Blessing of the Trickster");
                    if (level >= 2) ArchetypeFeats.Add("Channel Divinity: Invoke Duplicity");
                    if (level >= 6) ArchetypeFeats.Add("Channel Divinity: Cloak of Shadows");
                    if (level >= 8) ArchetypeFeats.Add("Divine Strike");
                    if (level >= 17) ArchetypeFeats.Add("Improved Duplicity");
                    break;
                case "War":
                    if (level >= 1) ItemProficiencies.Add("Martial");
                    if (level >= 1) ItemProficiencies.Add("Heavy Armor");
                    if (level >= 1) ArchetypeFeats.Add("War Priest");
                    if (level >= 2) ArchetypeFeats.Add("Channel Divinity: Guided Strike");
                    if (level >= 6) ArchetypeFeats.Add("Channel Divinity: War God's Blessing");
                    if (level >= 8) ArchetypeFeats.Add("Divine Strike");
                    if (level >= 17) ArchetypeFeats.Add("Avatar of Battle");
                    break;
            }
        }
    }
}