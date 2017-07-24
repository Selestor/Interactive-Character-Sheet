using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CharacterSheet.Items;
using CharacterSheet.Races;
using CharacterSheet.Weapons;

namespace CharacterSheet
{
    public partial class Form1
    {
        private decimal _strOld;
        private decimal _dexOld;
        private decimal _conOld;
        private decimal _intOld;
        private decimal _wisOld;
        private decimal _chaOld;
        private void StrUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (LevelUpDown.Value > 1 && attributeAvaliablePoints.Value > 0)
            {
                if (strUpDown.Value > _strOld) attributeAvaliablePoints.Value--;
                else strUpDown.Value = _strOld;
            }

            _strOld = strUpDown.Value;
            _newcharacter.Strength = strUpDown.Value;
            strActualTextBox.Text = _newcharacter.Strength.ToString("G");
            CalculateSpeed();

            //modifier
            var attributeModifier = CalculateModifier(strActualTextBox.Text);
            StrModTextBox.Text = attributeModifier.ToString("G");

            //saving throw
            if (StrSavingProf.Checked) StrSavingTextBox.Text = (attributeModifier + int.Parse(ProficiencyVisibleTextBox.Text)).ToString("G");
            else StrSavingTextBox.Text = StrModTextBox.Text;

            //skills
            bool proficiencyStatus;
            if (SkillAthleticssCheckBox.Checked) proficiencyStatus = true;
            else proficiencyStatus = false;
            SkillValue("Athletics", attributeModifier, proficiencyStatus);

            //attack and damage
            meleeWeapon1ComboBox_SelectedIndexChanged(sender,e);
            meleeWeapon2ComboBox_SelectedIndexChanged(sender, e);
            rangedWeapon1ComboBox_SelectedIndexChanged(sender, e);
            rangedWeapon2ComboBox_SelectedIndexChanged(sender, e);
        }

        private void DexUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (LevelUpDown.Value > 1 && attributeAvaliablePoints.Value > 0)
            {
                if (dexUpDown.Value > _dexOld) attributeAvaliablePoints.Value--;
                else dexUpDown.Value = _dexOld;
            }

            _dexOld = dexUpDown.Value;
            _newcharacter.Dextirity = dexUpDown.Value;
            dexActualTextBox.Text = _newcharacter.Dextirity.ToString("G");

            //modifier
            var attributeModifier = CalculateModifier(dexActualTextBox.Text);
            DexModTextBox.Text = attributeModifier.ToString("G");

            //skills
            bool acrobaticsProficiencyStatus = false;
            bool sleightOfHandProficiencyStatus = false;
            bool stealthProficiencyStatus = false;
            if (SkillAcrobaticsCheckBox.Checked) acrobaticsProficiencyStatus = true;
            if (SkillSleightofHandCheckBox.Checked) sleightOfHandProficiencyStatus = true;
            if (SkillStealthCheckBox.Checked) stealthProficiencyStatus = true;
            SkillValue("Acrobatics", attributeModifier, acrobaticsProficiencyStatus);
            SkillValue("SleightofHand", attributeModifier, sleightOfHandProficiencyStatus);
            SkillValue("Stealth", attributeModifier, stealthProficiencyStatus);

            //initiative
            InitiativetextBox.Text = attributeModifier.ToString("G");
            if (attributeModifier > 0) InitiativetextBox.Text = "+" + InitiativetextBox.Text;

            //saving throw
            if (DexSavingProf.Checked) DexSavingTextBox.Text = (attributeModifier + int.Parse(ProficiencyVisibleTextBox.Text)).ToString("G");
            else DexSavingTextBox.Text = DexModTextBox.Text;

            //AC
            SetAc();

            //weapons
            meleeWeapon1ComboBox_SelectedIndexChanged(sender, e);
            meleeWeapon2ComboBox_SelectedIndexChanged(sender, e);
            rangedWeapon1ComboBox_SelectedIndexChanged(sender, e);
            rangedWeapon2ComboBox_SelectedIndexChanged(sender, e);
        }

        private void ConUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (LevelUpDown.Value > 1 && attributeAvaliablePoints.Value > 0)
            {
                if (conUpDown.Value > _conOld) attributeAvaliablePoints.Value--;
                else conUpDown.Value = _conOld;
            }

            _conOld = conUpDown.Value;
            _newcharacter.Constitution = conUpDown.Value;
            conActualTextBox.Text = _newcharacter.Constitution.ToString("G");

            //modifier
            var attributeModifier = CalculateModifier(conActualTextBox.Text);
            ConModTextBox.Text = attributeModifier.ToString("G");

            //saving throw
            if (ConSavingProf.Checked) ConSavingTextBox.Text = (attributeModifier + int.Parse(ProficiencyVisibleTextBox.Text)).ToString("G");
            else ConSavingTextBox.Text = ConModTextBox.Text;

            //for barbarians
            SetAc();
        }

        private void IntUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (LevelUpDown.Value > 1 && attributeAvaliablePoints.Value > 0)
            {
                if (intUpDown.Value > _intOld) attributeAvaliablePoints.Value--;
                else intUpDown.Value = _intOld;
            }

            _intOld = intUpDown.Value;
            _newcharacter.Intelligence = intUpDown.Value;
            intActualTextBox.Text = _newcharacter.Intelligence.ToString("G");

            //modifier
            var attributeModifier = CalculateModifier(intActualTextBox.Text);
            IntModTextBox.Text = attributeModifier.ToString("G");

            //skills
            var arcanaProficiencyStatus = false;
            var historyProficiencyStatus = false;
            var investigationProficiencyStatus = false;
            var natureProficiencyStatus = false;
            var religionProficiencyStatus = false;
            if (SkillArcanaCheckBox.Checked) arcanaProficiencyStatus = true;
            if (SkillHistoryCheckBox.Checked) historyProficiencyStatus = true;
            if (SkillInvestigationCheckBox.Checked) investigationProficiencyStatus = true;
            if (SkillNatureCheckBox.Checked) natureProficiencyStatus = true;
            if (SkillReligionCheckBox.Checked) religionProficiencyStatus = true;
            SkillValue("Arcana", attributeModifier, arcanaProficiencyStatus);
            SkillValue("History", attributeModifier, historyProficiencyStatus);
            SkillValue("Investigation", attributeModifier, investigationProficiencyStatus);
            SkillValue("Nature", attributeModifier, natureProficiencyStatus);
            SkillValue("Religion", attributeModifier, religionProficiencyStatus);

            //saving throw
            if (IntSavingProf.Checked) IntSavingTextBox.Text = (attributeModifier + int.Parse(ProficiencyVisibleTextBox.Text)).ToString("G");
            else IntSavingTextBox.Text = IntModTextBox.Text;
        }

        private void WisUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (LevelUpDown.Value > 1 && attributeAvaliablePoints.Value > 0)
            {
                if (wisUpDown.Value > _wisOld) attributeAvaliablePoints.Value--;
                else wisUpDown.Value = _wisOld;
            }

            _wisOld = wisUpDown.Value;
            _newcharacter.Wisdom = wisUpDown.Value;
            wisActualTextBox.Text = _newcharacter.Wisdom.ToString("G");

            //modifier
            var attributeModifier = CalculateModifier(wisActualTextBox.Text);
            WisModTextBox.Text = attributeModifier.ToString("G");

            //skills
            var animalProficiencyStatus = false;
            var insightProficiencyStatus = false;
            var medicineProficiencyStatus = false;
            var perceptionProficiencyStatus = false;
            var survivalProficiencyStatus = false;
            if (SkillAnimalCheckBox.Checked) animalProficiencyStatus = true;
            if (SkillInsightCheckBox.Checked) insightProficiencyStatus = true;
            if (SkillMedicineCheckBox.Checked) medicineProficiencyStatus = true;
            if (SkillPerceptionCheckBox.Checked) perceptionProficiencyStatus = true;
            if (SkillSurvivalCheckBox.Checked) survivalProficiencyStatus = true;
            SkillValue("Animal", attributeModifier, animalProficiencyStatus);
            SkillValue("Insight", attributeModifier, insightProficiencyStatus);
            SkillValue("Medicine", attributeModifier, medicineProficiencyStatus);
            SkillValue("Perception", attributeModifier, perceptionProficiencyStatus);
            SkillValue("Survival", attributeModifier, survivalProficiencyStatus);

            //saving throw
            if (WisSavingProf.Checked) WisSavingTextBox.Text = (attributeModifier + int.Parse(ProficiencyVisibleTextBox.Text)).ToString("G");
            else WisSavingTextBox.Text = WisModTextBox.Text;

            //for monks
            SetAc();
        }

        private void ChaUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (LevelUpDown.Value > 1 && attributeAvaliablePoints.Value > 0)
            {
                if (chaUpDown.Value > _chaOld) attributeAvaliablePoints.Value--;
                else chaUpDown.Value = _chaOld;
            }

            _chaOld = chaUpDown.Value;
            _newcharacter.Charisma = chaUpDown.Value;
            chaActualTextBox.Text = _newcharacter.Charisma.ToString("G");

            //modifier
            var attributeModifier = CalculateModifier(chaActualTextBox.Text);
            ChaModTextBox.Text = attributeModifier.ToString("G");

            //skills
            var deceptionProficiencyStatus = false;
            var intimidationProficiencyStatus = false;
            var performanceProficiencyStatus = false;
            var persuasionProficiencyStatus = false;
            if (SkillDeceptionCheckBox.Checked) deceptionProficiencyStatus = true;
            if (SkillIntimidationCheckBox.Checked) intimidationProficiencyStatus = true;
            if (SkillPerformanceCheckBox.Checked) performanceProficiencyStatus = true;
            if (SkillPersuasionCheckBox.Checked) persuasionProficiencyStatus = true;
            SkillValue("Deception", attributeModifier, deceptionProficiencyStatus);
            SkillValue("Intimidation", attributeModifier, intimidationProficiencyStatus);
            SkillValue("Performance", attributeModifier, performanceProficiencyStatus);
            SkillValue("Persuasion", attributeModifier, persuasionProficiencyStatus);

            //saving throw
            if (ChaSavingProf.Checked) ChaSavingTextBox.Text = (attributeModifier + int.Parse(ProficiencyVisibleTextBox.Text)).ToString("G");
            else ChaSavingTextBox.Text = ChaModTextBox.Text;
        }

        private void RefreshAttributes(object sender, EventArgs e)
        {
            StrUpDown_ValueChanged(sender, e);
            DexUpDown_ValueChanged(sender, e);
            ConUpDown_ValueChanged(sender, e);
            IntUpDown_ValueChanged(sender, e);
            WisUpDown_ValueChanged(sender, e);
            ChaUpDown_ValueChanged(sender, e);
        }
        private void LevelUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (LevelUpDown.Value == 1)
            {
                experienceCurrentTextBox.Text = "0";
                experienceRequiredTextBox.Text = "300";
            }
            int levelBracket = 0;
            if (LevelUpDown.Value > 1) VisibleAttributesChangers(false);
            else VisibleAttributesChangers(true);
            if (LevelUpDown.Value >= 1 && LevelUpDown.Value <= 4) levelBracket = 1;
            if (LevelUpDown.Value >= 5 && LevelUpDown.Value <= 8) levelBracket = 2;
            if (LevelUpDown.Value >= 9 && LevelUpDown.Value <= 12) levelBracket = 3;
            if (LevelUpDown.Value >= 13 && LevelUpDown.Value <= 16) levelBracket = 4;
            if (LevelUpDown.Value >= 17 && LevelUpDown.Value <= 20) levelBracket = 5;
            switch (levelBracket)
            {
                case 1:
                    ProficiencyVisibleTextBox.Text = 2.ToString();
                    break;
                case 2:
                    ProficiencyVisibleTextBox.Text = 3.ToString();
                    break;
                case 3:
                    ProficiencyVisibleTextBox.Text = 4.ToString();
                    break;
                case 4:
                    ProficiencyVisibleTextBox.Text = 5.ToString();
                    break;
                case 5:
                    ProficiencyVisibleTextBox.Text = 6.ToString();
                    break;
            }
            RefreshAttributes(sender, e);
            classComboBox_SelectedIndexChanged(sender, e);
            CalculateAvaliableFeats();
            ItemProficiencies();
        }

        private void raceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var race = raceComboBox.SelectedItem.ToString();
            racialPerksListBox.Items.Clear();
            switch (race)
            {
                case "Dwarf: Mountain Dwarf":
                    _newcharacter = new MountainDwarf();
                    RefreshAttributes(sender, e);
                    break;
                case "Dwarf: Hill Dwarf":
                    _newcharacter = new HillDwarf();
                    RefreshAttributes(sender, e);
                    break;
                case "Elf: Wood Elf":
                    _newcharacter = new WoodElf();
                    RefreshAttributes(sender, e);
                    break;
                case "Elf: High Elf":
                    _newcharacter = new HighElf();
                    RefreshAttributes(sender, e);
                    break;
                case "Elf: Drow":
                    _newcharacter = new Drow();
                    RefreshAttributes(sender, e);
                    break;
                case "Halfling: Lightfoot":
                    _newcharacter = new LightfootHalfling();
                    RefreshAttributes(sender, e);
                    break;
                case "Halfling: Stout Halfling":
                    _newcharacter = new StoutHalfling();
                    RefreshAttributes(sender, e);
                    break;
                case "Human":
                    _newcharacter = new Human();
                    RefreshAttributes(sender, e);
                    break;
                case "Dragonborn":
                    _newcharacter = new Dragonborn();
                    RefreshAttributes(sender, e);
                    break;
                case "Gnome: Rock Gnome":
                    _newcharacter = new RockGnome();
                    RefreshAttributes(sender, e);
                    break;
                case "Gnome: Forest Gnome":
                    _newcharacter = new ForestGnome();
                    RefreshAttributes(sender, e);
                    break;
                case "Half-Elf":
                    _newcharacter = new HalfElf();
                    RefreshAttributes(sender, e);
                    break;
                case "Half-Orc":
                    _newcharacter = new HalfOrc();
                    RefreshAttributes(sender, e);
                    break;
                case "Lizardfolk":
                    _newcharacter = new Lizardfolk();
                    RefreshAttributes(sender, e);
                    break;
                case "Tiefling":
                    _newcharacter = new Tiefling();
                    RefreshAttributes(sender, e);
                    break;
            }
            RaceUpdate(_newcharacter);
            sizeComboBox.SelectedIndex = _newcharacter.AdultSize;
            racialPerksListBox.Items.AddRange(_newcharacter.AdditionalPerks.ToArray());
            ItemProficiencies();
        }

        private void classComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (classComboBox.SelectedIndex == 0) LevelUpDown.Visible = false;
            else LevelUpDown.Visible = true;
            StrSavingProf.Checked = false;
            DexSavingProf.Checked = false;
            ConSavingProf.Checked = false;
            IntSavingProf.Checked = false;
            WisSavingProf.Checked = false;
            ChaSavingProf.Checked = false;
            rageCheckBox.Checked = false;
            rageCheckBox.Visible = false;
            ragesPerDay.Visible = false;
            rageDamageTextBox.Text = "";
            rageDamageTextBox.Visible = false;
            equipmentProficiencyListBox.Items.Clear();
            archetypeFeatsListBox.Items.Clear();
            classFeatsListBox.Items.Clear();
            var archetype = archetypeComboBox.Text;

            if (sender == classComboBox)
            {
                LevelUpDown.Value = 1;
                classFeatsListBox.Items.Clear();
            }

            var level = LevelUpDown.Value;
            var characterClass = classComboBox.SelectedItem.ToString();
            switch (characterClass)
            {
                case "None":
                    break;
                case "Barbarian":
                    var rages = "";
                    if (level < 3 && level > 0) rages = 2.ToString();
                    if (level < 6 && level > 2) rages = 3.ToString();
                    if (level < 12 && level > 5) rages = 4.ToString();
                    if (level < 17 && level > 11) rages = 5.ToString();
                    if (level < 20 && level > 16) rages = 6.ToString();
                    if (level == 20) rages = "Unlimited"; 
                    _newClass = new Barbarian(level, archetype);
                    StrSavingProf.Checked = true;
                    ConSavingProf.Checked = true;
                    rageCheckBox.Visible = true;
                    ragesPerDay.Visible = true;
                    ragesPerDay.Text = rages;
                    rageDamageTextBox.Visible = true;
                    rageDamageTextBox.Text = (2 + Math.Floor(LevelUpDown.Value / 8)).ToString("G");
                    if (level < 3) archetypeComboBox.Items.Clear();
                    if (level > 2 && archetypeComboBox.Items.Count < 1) archetypeComboBox.Items.AddRange(_newClass.Archetypes.ToArray());
                    break;
                case "Bard":
                    _newClass = new Bard(level, archetype);
                    DexSavingProf.Checked = true;
                    ChaSavingProf.Checked = true;
                    if (level < 3) archetypeComboBox.Items.Clear();
                    if (level > 2 && archetypeComboBox.Items.Count < 1) archetypeComboBox.Items.AddRange(_newClass.Archetypes.ToArray());
                    break;
                case "Cleric":
                    _newClass = new Cleric(level, archetype);
                    if (sender == classComboBox) archetypeComboBox.Items.Clear();
                    WisSavingProf.Checked = true;
                    ChaSavingProf.Checked = true;
                    if (level < 1) archetypeComboBox.Items.Clear();
                    if (archetypeComboBox.Items.Count < 1) archetypeComboBox.Items.AddRange(_newClass.Archetypes.ToArray());
                    break;
                case "Druid":
                    _newClass = new Druid(level, archetype);
                    IntSavingProf.Checked = true;
                    WisSavingProf.Checked = true;
                    if (level < 2) archetypeComboBox.Items.Clear();
                    if (level > 1 && archetypeComboBox.Items.Count < 1) archetypeComboBox.Items.AddRange(_newClass.Archetypes.ToArray());
                    break;
                case "Fighter":
                    _newClass = new Fighter(level, archetype);
                    StrSavingProf.Checked = true;
                    ConSavingProf.Checked = true;
                    if (level < 3) archetypeComboBox.Items.Clear();
                    if (level > 2 && archetypeComboBox.Items.Count < 1) archetypeComboBox.Items.AddRange(_newClass.Archetypes.ToArray());
                    break;
                case "Monk":
                    _newClass = new Monk(level, archetype);
                    StrSavingProf.Checked = true;
                    DexSavingProf.Checked = true;
                    if (level < 3) archetypeComboBox.Items.Clear();
                    if (level > 2 && archetypeComboBox.Items.Count < 1) archetypeComboBox.Items.AddRange(_newClass.Archetypes.ToArray());
                    break;
                case "Paladin":
                    _newClass = new Paladin(level, archetype);
                    WisSavingProf.Checked = true;
                    ChaSavingProf.Checked = true;
                    if (level < 3) archetypeComboBox.Items.Clear();
                    if (level > 2 && archetypeComboBox.Items.Count < 1) archetypeComboBox.Items.AddRange(_newClass.Archetypes.ToArray());
                    break;
                case "Ranger":
                    _newClass = new Ranger(level, archetype);
                    StrSavingProf.Checked = true;
                    DexSavingProf.Checked = true;
                    if (level < 3) archetypeComboBox.Items.Clear();
                    if (level > 2 && archetypeComboBox.Items.Count < 1) archetypeComboBox.Items.AddRange(_newClass.Archetypes.ToArray());
                    break;
                case "Rogue":
                    _newClass = new Rogue(level, archetype);
                    DexSavingProf.Checked = true;
                    IntSavingProf.Checked = true;
                    if (level < 3) archetypeComboBox.Items.Clear();
                    if (level > 2 && archetypeComboBox.Items.Count < 1) archetypeComboBox.Items.AddRange(_newClass.Archetypes.ToArray());
                    break;
                case "Sorcerer":
                    _newClass = new Sorcerer(level, archetype);
                    if (sender == classComboBox) archetypeComboBox.Items.Clear();
                    ConSavingProf.Checked = true;
                    ChaSavingProf.Checked = true;
                    if (level < 1) archetypeComboBox.Items.Clear();
                    if (archetypeComboBox.Items.Count < 1) archetypeComboBox.Items.AddRange(_newClass.Archetypes.ToArray());
                    break;
                case "Warlock":
                     _newClass = new Warlock(level, archetype);
                    if (sender == classComboBox) archetypeComboBox.Items.Clear();
                    WisSavingProf.Checked = true;
                    ChaSavingProf.Checked = true;
                    if (level < 1) archetypeComboBox.Items.Clear();
                    if (archetypeComboBox.Items.Count < 1) archetypeComboBox.Items.AddRange(_newClass.Archetypes.ToArray());
                    break;
                case "Wizard":
                    _newClass = new Wizard(level, archetype);
                    WisSavingProf.Checked = true;
                    IntSavingProf.Checked = true;
                    if (level < 2) archetypeComboBox.Items.Clear();
                    if (level > 1 && archetypeComboBox.Items.Count < 1) archetypeComboBox.Items.AddRange(_newClass.Archetypes.ToArray());
                    break;
            }
            HealthDiceTextBox.Text = _newClass.HitDice;
            classFeatsListBox.Items.AddRange(_newClass.ClassFeatures.ToArray());
            archetypeFeatsListBox.Items.AddRange(_newClass.ArchetypeFeats.ToArray());
            ItemProficiencies();
        }

        private void featsAndPerksAddButton_Click(object sender, EventArgs e)
        {
            if (featComboBox.SelectedItem != null)
            {
                featsAndPerksListBox.Items.Add(featComboBox.SelectedItem);
                featsAndPerksListBox.Sorted = true;
                featComboBox.SelectedItem = null;
                if (featsAndPerksListBox.Items.Contains("Increase Attribute"))
                {
                    attributeAvaliablePoints.Visible = true;
                    attributeAvaliablePoints.Value += 2;

                    VisibleAttributesChangers(true);
                }
                CalculateAvaliableFeats();
            }
        }

        private void featsAndPerksDeleteButton_Click(object sender, EventArgs e)
        {
            featsAndPerksListBox.Items.Remove(featsAndPerksListBox.SelectedItem);
            CalculateAvaliableFeats();
        }

        private void AvatarPictureBox_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "(*.jpg)|*.jpg|(*.bmp)|*.bmp";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // Create a new Bitmap object from the picture file on disk,
                    // and assign that to the PictureBox.Image property
                    Bitmap bmp = (Bitmap)Image.FromFile(dlg.FileName);
                    AvatarPictureBox.Image = bmp;
                }
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "(*.jpg)|*.jpg|(*.bmp)|*.bmp";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // Create a new Bitmap object from the picture file on disk,
                    // and assign that to the PictureBox.Image property
                    Bitmap bmp = (Bitmap)Image.FromFile(dlg.FileName);
                    pictureBox.Image = bmp;
                }
            }
        }

        private void DelDelete(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) featsAndPerksDeleteButton_Click(sender, e);
        }

        private void rangedWeapon1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ranged2handsCheckBox1.Checked = false;
            if (ranged2handsCheckBox2.Visible && ranged2handsCheckBox2.Text == "use 2 hands" && ranged2handsCheckBox2.Checked) ranged2handsCheckBox2.Checked = false;
            SetUpRangedWeapon(1);
        }

        private void rangedWeapon2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ranged2handsCheckBox2.Checked = false;
            if (ranged2handsCheckBox1.Visible && ranged2handsCheckBox1.Text == "use 2 hands" && ranged2handsCheckBox1.Checked) ranged2handsCheckBox1.Checked = false;
            SetUpRangedWeapon(2);
        }

        private void ranged2handsCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ranged2handsCheckBox1.Text == "use 2 hands" && ranged2handsCheckBox1.Checked)
            {
                rangedWeapon2ComboBox.SelectedIndex = 0;
                ranged2handsCheckBox1.Checked = true;
            }
            SetUpRangedWeapon(1);
        }

        private void ranged2handsCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (ranged2handsCheckBox2.Text == "use 2 hands" && ranged2handsCheckBox2.Checked)
            {
                rangedWeapon1ComboBox.SelectedIndex = 0;
                ranged2handsCheckBox2.Checked = true;
            }
            SetUpRangedWeapon(2);
        }

        private void meleeWeapon1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            specialWeaponCheckBox1.Checked = false;
            if (specialWeaponCheckBox2.Visible && specialWeaponCheckBox2.Text == "use 2 hands" && specialWeaponCheckBox2.Checked) specialWeaponCheckBox2.Checked = false;
            SetUpMeleeWeapon(1);
        }

        private void meleeWeapon2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            specialWeaponCheckBox2.Checked = false;
            if (specialWeaponCheckBox1.Visible && specialWeaponCheckBox1.Text == "use 2 hands" && specialWeaponCheckBox1.Checked) specialWeaponCheckBox1.Checked = false;
            SetUpMeleeWeapon(2);
        }

        private void specialWeaponCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (specialWeaponCheckBox1.Text == "use 2 hands" && specialWeaponCheckBox1.Checked)
            {
                meleeWeapon2ComboBox.SelectedIndex = 1;
                specialWeaponCheckBox1.Checked = true;
            }
            SetUpMeleeWeapon(1);
        }

        private void specialWeaponCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (specialWeaponCheckBox2.Text == "use 2 hands" && specialWeaponCheckBox2.Checked)
            {
                meleeWeapon1ComboBox.SelectedIndex = 1;
                specialWeaponCheckBox2.Checked = true;
            }
            SetUpMeleeWeapon(2);
        }

        private void EasterEgg(object sender, KeyEventArgs e)
        {
            if (_sequence.IsCompletedBy(e.KeyCode))
            {
                using (Form form = new Form())
                {
                    Image img = Properties.Resources.pppolka;

                    form.StartPosition = FormStartPosition.CenterScreen;
                    form.Size = img.Size;

                    PictureBox pb = new PictureBox();
                    pb.Dock = DockStyle.Fill;
                    pb.Image = img;

                    form.Controls.Add(pb);
                    form.ShowDialog();
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (Controls.Count > 0)
            {
                Controls[0].Dispose();
            }
            InitializeComponent();
            SetUpDecaultCharacter();

            equipmentProficiencyListBox.Items.Clear();
            classFeatsListBox.Items.Clear();
            archetypeFeatsListBox.Items.Clear();
            filePath = null;
            strUpDown.Value = 10;
            dexUpDown.Value = 10;
            conUpDown.Value = 10;
            intUpDown.Value = 10;
            wisUpDown.Value = 10;
            chaUpDown.Value = 10;
        }

        private void OnlyNumericKeys(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        public void DeleteMeleeWeapon_Click(object sender, EventArgs e)
        {
            if (_newWeaponList[meleeWeaponsListBox.SelectedIndex].IsDisposable)
            {
                List<Weapon> newList = _newWeaponList;
                newList.RemoveAt(meleeWeaponsListBox.SelectedIndex);
                _newWeaponList = newList;
                ItemsRefresh();
                ItemsApplyChanged();
            }
        }

        public void newMeleeWeaponAddButton_Click(object sender, EventArgs e)
        {
            List<Weapon> newList = _newWeaponList;
            string customDamageDice = newMeleeWeaponNumberofDice.Value.ToString("G") + newMeleeWeaponDamageDice.Text;
            string customVersatileDamageDice = newMeleeWeaponVersatileNumberofDamageDice.Value.ToString("G") +
                                               newMeleeWeaponVersatileDamageDice.Text;
            Weapon newWeapon = AddWeapon(newMeleeWeaponName.Text, customDamageDice, newMeleeWeaponDamageType.Text, newMeleeWeaponKind.Text,
                newMeleeWeaponSlot.Text, customVersatileDamageDice, newMeleeWeaponIsFinesse.Checked, true);

            newList.Add(newWeapon);
            _newWeaponList = newList;
            ItemsRefresh();
            ItemsApplyChanged();
        }

        private void newMeleeWeaponSlot_SelectedIndexChanged(object sender, EventArgs e)
        {
            versatileNODD.Visible = false;
            versatile2HDD.Visible = false;
            newMeleeWeaponIsFinesse.Visible = true;
            newMeleeWeaponVersatileDamageDice.Visible = false;
            newMeleeWeaponVersatileNumberofDamageDice.Visible = false;
            if (newMeleeWeaponSlot.Text == "Versatile" || newMeleeWeaponSlot.Text == "2hand")
            {
                versatileNODD.Visible = true;
                versatile2HDD.Visible = true;
                newMeleeWeaponIsFinesse.Checked = false;
                newMeleeWeaponIsFinesse.Visible = false;
                newMeleeWeaponVersatileDamageDice.Visible = true;
                newMeleeWeaponVersatileNumberofDamageDice.Visible = true;
            }
        }

        private void DeleteArmor_Click(object sender, EventArgs e)
        {
            if (_newArmorsList[armorListBox.SelectedIndex].IsDisposable)
            {
                List<Armors> newList = _newArmorsList;
                newList.RemoveAt(armorListBox.SelectedIndex);
                _newArmorsList = newList;
                ItemsRefresh();
                ItemsApplyChanged();
            }
        }

        private void newArmorAddButton_Click(object sender, EventArgs e)
        {
            List<Armors> newList = _newArmorsList;
            Armors armor = AddArmors(newArmorName.Text, newArmorType.Text, int.Parse(newArmorBaseAc.Text),
                int.Parse(newArmorMaxDex.Text), true);
            newList.Add(armor);
            _newArmorsList = newList;
            ItemsRefresh();
            ItemsApplyChanged();
        }

        private void newArmorType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (newArmorType.Text == "Light") newArmorMaxDex.Text = "10";
            if (newArmorType.Text == "Medium") newArmorMaxDex.Text = "2";
            if (newArmorType.Text == "Heavy") newArmorMaxDex.Text = "0";
        }

        private void DeleteRangedWeapon_Click(object sender, EventArgs e)
        {
            List<RangedWeapon> newList = _newRangedWeaponList;
            newList.RemoveAt(rangedWeaponsListBox.SelectedIndex);
            _newRangedWeaponList = newList;
            ItemsRefresh();
            ItemsApplyChanged();
        }

        private void newRangedWeaponAddButton_Click(object sender, EventArgs e)
        {
            List<RangedWeapon> newList = _newRangedWeaponList;
            string customDamageDice = newRangedWeaponNumberofDice.Value.ToString("G") + newRangedWeaponDamageDice.Text;

            RangedWeapon newWeapon = AddRangedWeapon(newRangedWeaponName.Text, customDamageDice,
                newRangedWeaponDamageType.Text, newRangedWeaponKind.Text, newRangedWeaponSlot.Text,
                int.Parse(newRangedWeaponMinRange.Text), int.Parse(newRangedWeaponMaxRange.Text),
                newRangedWeaponIsFinesse.Checked, true);

            newList.Add(newWeapon);
            _newRangedWeaponList = newList;
            ItemsRefresh();
            ItemsApplyChanged();
        }

        private void attributeAvaliablePoints_ValueChanged(object sender, EventArgs e)
        {
            if (attributeAvaliablePoints.Value == 0) VisibleAttributesChangers(false);
        }

        private void InfoPopUp(object sender, MouseEventArgs e)
        {
            var changedSender = sender as ListBox;
            FormInfo infoForm = new FormInfo();
            if (_newFeatInfoList != null)
            {
                foreach (var featInfo in _newFeatInfoList)
                {
                    if (changedSender.Text == featInfo.Name)
                    {
                        infoForm.Show();
                        infoForm.ChangeInsides(featInfo.Name, featInfo.Info);
                    }
                }
            }
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            rollResultTextBox.Text = "---";
            rollResultList.Items.Clear();
            rollResultList.Items.Add("Roll:\tResult:");
            var minRange = 1;
            var maxRange = 1;
            var result = 0;
            var sum = 0;

            if (rollDiceComboBox.SelectedIndex == 0) maxRange = 5;
            if (rollDiceComboBox.SelectedIndex == 1) maxRange = 7;
            if (rollDiceComboBox.SelectedIndex == 2) maxRange = 9;
            if (rollDiceComboBox.SelectedIndex == 3) maxRange = 11;
            if (rollDiceComboBox.SelectedIndex == 4) maxRange = 13;
            if (rollDiceComboBox.SelectedIndex == 5) maxRange = 21;
            if (rollDiceComboBox.SelectedIndex == 6) maxRange = 101;
            Random roll = new Random();

            if (rollNumberOfTimes.Value == 1)
            {
                result = roll.Next(minRange, maxRange);
                rollResultTextBox.Text = result.ToString("G");
            }
            else
            {
                for (var i = 0; i < rollNumberOfTimes.Value; i++)
                {
                    result = roll.Next(minRange, maxRange);
                    rollResultList.Items.Add((i + 1) + "." + "\t" + result);
                    sum = sum + result;
                }
                rollResultTextBox.Text = sum.ToString("G");
            }
        }


        private void experienceCurrentTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(experienceCurrentTextBox.Text) < 0) experienceCurrentTextBox.Text = "0";
            if (string.IsNullOrEmpty(experienceCurrentTextBox.Text) || int.Parse(experienceCurrentTextBox.Text) < 300)
            {
                LevelUpDown.Value = 1;
                experienceRequiredTextBox.Text = "300";
            }
            else
            {
                if (int.Parse(experienceCurrentTextBox.Text) >= 300 && int.Parse(experienceCurrentTextBox.Text) < 900)
                {
                    LevelUpDown.Value = 2;
                    experienceRequiredTextBox.Text = "900";
                }
                if (int.Parse(experienceCurrentTextBox.Text) >= 900 && int.Parse(experienceCurrentTextBox.Text) < 2700)
                {
                    LevelUpDown.Value = 3;
                    experienceRequiredTextBox.Text = "2 700";
                }
                if (int.Parse(experienceCurrentTextBox.Text) >= 2700 && int.Parse(experienceCurrentTextBox.Text) < 6500)
                {
                    LevelUpDown.Value = 4;
                    experienceRequiredTextBox.Text = "6 500";
                }
                if (int.Parse(experienceCurrentTextBox.Text) >= 6500 && int.Parse(experienceCurrentTextBox.Text) < 14000)
                {
                    LevelUpDown.Value = 5;
                    experienceRequiredTextBox.Text = "14 000";
                }
                if (int.Parse(experienceCurrentTextBox.Text) >= 14000 && int.Parse(experienceCurrentTextBox.Text) < 23000)
                {
                    LevelUpDown.Value = 6;
                    experienceRequiredTextBox.Text = "23 000";
                }
                if (int.Parse(experienceCurrentTextBox.Text) >= 23000 && int.Parse(experienceCurrentTextBox.Text) < 34000)
                {
                    LevelUpDown.Value = 7;
                    experienceRequiredTextBox.Text = "34 000";
                }
                if (int.Parse(experienceCurrentTextBox.Text) >= 34000 && int.Parse(experienceCurrentTextBox.Text) < 48000)
                {
                    LevelUpDown.Value = 8;
                    experienceRequiredTextBox.Text = "48 000";
                }
                if (int.Parse(experienceCurrentTextBox.Text) >= 48000 && int.Parse(experienceCurrentTextBox.Text) < 64000)
                {
                    LevelUpDown.Value = 9;
                    experienceRequiredTextBox.Text = "64 000";
                }
                if (int.Parse(experienceCurrentTextBox.Text) >= 64000 && int.Parse(experienceCurrentTextBox.Text) < 85000)
                {
                    LevelUpDown.Value = 10;
                    experienceRequiredTextBox.Text = "85 000";
                }
                if (int.Parse(experienceCurrentTextBox.Text) >= 85000 &&
                    int.Parse(experienceCurrentTextBox.Text) < 100000)
                {
                    LevelUpDown.Value = 11;
                    experienceRequiredTextBox.Text = "100 000";
                }
                if (int.Parse(experienceCurrentTextBox.Text) >= 100000 &&
                    int.Parse(experienceCurrentTextBox.Text) < 120000)
                {
                    LevelUpDown.Value = 12;
                    experienceRequiredTextBox.Text = "120 000";
                }
                if (int.Parse(experienceCurrentTextBox.Text) >= 120000 &&
                    int.Parse(experienceCurrentTextBox.Text) < 140000)
                {
                    LevelUpDown.Value = 13;
                    experienceRequiredTextBox.Text = "140 000";
                }
                if (int.Parse(experienceCurrentTextBox.Text) >= 140000 &&
                    int.Parse(experienceCurrentTextBox.Text) < 165000)
                {
                    LevelUpDown.Value = 14;
                    experienceRequiredTextBox.Text = "165 000";
                }
                if (int.Parse(experienceCurrentTextBox.Text) >= 165000 &&
                    int.Parse(experienceCurrentTextBox.Text) < 195000)
                {
                    LevelUpDown.Value = 15;
                    experienceRequiredTextBox.Text = "195 000";
                }
                if (int.Parse(experienceCurrentTextBox.Text) >= 195000 &&
                    int.Parse(experienceCurrentTextBox.Text) < 225000)
                {
                    LevelUpDown.Value = 16;
                    experienceRequiredTextBox.Text = "225 000";
                }
                if (int.Parse(experienceCurrentTextBox.Text) >= 225000 &&
                    int.Parse(experienceCurrentTextBox.Text) < 265000)
                {
                    LevelUpDown.Value = 17;
                    experienceRequiredTextBox.Text = "265 000";
                }
                if (int.Parse(experienceCurrentTextBox.Text) >= 265000 &&
                    int.Parse(experienceCurrentTextBox.Text) < 305000)
                {
                    LevelUpDown.Value = 18;
                    experienceRequiredTextBox.Text = "305 000";
                }
                if (int.Parse(experienceCurrentTextBox.Text) >= 305000 &&
                    int.Parse(experienceCurrentTextBox.Text) < 355000)
                {
                    LevelUpDown.Value = 19;
                    experienceRequiredTextBox.Text = "355 000";
                }
                if (int.Parse(experienceCurrentTextBox.Text) >= 355000)
                {
                    LevelUpDown.Value = 20;
                    experienceRequiredTextBox.Text = "???";
                }
            }
        }

        private void AddExp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                experienceCurrentTextBox.Text =
                    (int.Parse(experienceCurrentTextBox.Text) + int.Parse(expAddTextBox.Text)).ToString("G");
                expAddTextBox.Text = "";
                if (int.Parse(experienceCurrentTextBox.Text) > 999999) experienceCurrentTextBox.Text = "999999";
            }
        }

        private void woundAddTextBox_TextChanged(object sender, KeyEventArgs e)
        {
            if (woundAddTextBox.Text != "" && e.KeyCode == Keys.Enter)
            {
                woundsTextBox.Text = (int.Parse(woundAddTextBox.Text) + int.Parse(woundsTextBox.Text)).ToString("G");
                woundAddTextBox.Text = "";
                if (int.Parse(woundsTextBox.Text) > int.Parse(HealthTextBox.Text)) woundsTextBox.Text = HealthTextBox.Text;
            }
        }

        private void HealUp(object sender, KeyEventArgs e)
        {
            if (healTextBox.Text != "" && e.KeyCode == Keys.Enter)
            {
                woundsTextBox.Text = (int.Parse(woundsTextBox.Text) - int.Parse(healTextBox.Text)).ToString("G");
                healTextBox.Text = "";
                if (int.Parse(woundsTextBox.Text) < 0) woundsTextBox.Text = "0";
            }
        }

        private void ChangeHp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CalculateHp();
                if (HealthTextBox.Text == "") HealthTextBox.Text = "0";
                if (int.Parse(woundsTextBox.Text) > int.Parse(HealthTextBox.Text)) woundsTextBox.Text = HealthTextBox.Text;
            }
        }

    }
}
