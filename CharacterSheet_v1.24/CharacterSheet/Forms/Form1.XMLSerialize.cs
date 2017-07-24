using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using CharacterSheet.Items;
using CharacterSheet.Weapons;

namespace CharacterSheet
{
    public partial class Form1 
    {
        string filePath = null;

        static public void SerializeToXml(CharacterProperties character, string saveDirectory)
        {
            XmlWriterSettings writerSettings = new XmlWriterSettings(); //new
            writerSettings.NewLineHandling = NewLineHandling.Entitize;

            XmlSerializer serializer = new XmlSerializer(typeof(CharacterProperties));

            //TextWriter textWriter = new StreamWriter(saveDirectory); 
            XmlWriter xmlWriter = XmlWriter.Create(saveDirectory, writerSettings);
            serializer.Serialize(xmlWriter, character);
            xmlWriter.Close();
            //textWriter.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveCharacter();
            zapis();
        }

        private void quicksave(object sender, EventArgs e)
        {
            if (filePath == null) saveToolStripMenuItem_Click(sender, e);
            else
            {
                saveCharacter();
                SerializeToXml(_characterProperties, filePath);
            }
        }

        private void zapis()
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Xml files (*.xml)|*.xml|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    myStream.Close();
                    filePath = saveFileDialog1.FileName;
                    SerializeToXml(_characterProperties, filePath);
                }
            }
        }

        private void saveCharacter()
        {
            _characterProperties.Name = nameTextBox.Text;
            _characterProperties.Race = raceComboBox.SelectedIndex;
            _characterProperties.SelectedClass = classComboBox.SelectedIndex;
            _characterProperties.Specialization = archetypeComboBox.SelectedIndex;
            _characterProperties.Aligment = aligmentComboBox.SelectedIndex;
            _characterProperties.Size = sizeComboBox.SelectedIndex;
            _characterProperties.Experience = experienceCurrentTextBox.Text;
            _characterProperties.Level = LevelUpDown.Value;
            _characterProperties.HitPoints = HealthTextBox.Text;
            _characterProperties.Wounds = woundsTextBox.Text;
            _characterProperties.AcBonus = otherAcBonusuesUpDown.Value;
            _characterProperties.Strength = strUpDown.Value;
            _characterProperties.Dextirity = dexUpDown.Value;
            _characterProperties.Constitution = conUpDown.Value;
            _characterProperties.Intelligence = intUpDown.Value;
            _characterProperties.Wisdom = wisUpDown.Value;
            _characterProperties.Charisma = chaUpDown.Value;
            _characterProperties.StrenghtProficiency = StrSavingProf.Checked;
            _characterProperties.DextirityProficiency = DexSavingProf.Checked;
            _characterProperties.ConstitutionProficiency = ConSavingProf.Checked;
            _characterProperties.IntelligenceProficiency = IntSavingProf.Checked;
            _characterProperties.WisdomProficiency = WisSavingProf.Checked;
            _characterProperties.CharismaProficiency = ChaSavingProf.Checked;
            _characterProperties.Acrobatics = SkillAcrobaticsCheckBox.Checked;
            _characterProperties.Animal = SkillAnimalCheckBox.Checked;
            _characterProperties.Arcana = SkillArcanaCheckBox.Checked;
            _characterProperties.Athletics = SkillAthleticssCheckBox.Checked;
            _characterProperties.Deception = SkillDeceptionCheckBox.Checked;
            _characterProperties.History = SkillHistoryCheckBox.Checked;
            _characterProperties.Insight = SkillInsightCheckBox.Checked;
            _characterProperties.Intimidation = SkillIntimidationCheckBox.Checked;
            _characterProperties.Investigation = SkillInvestigationCheckBox.Checked;
            _characterProperties.Medicine = SkillMedicineCheckBox.Checked;
            _characterProperties.Nature = SkillNatureCheckBox.Checked;
            _characterProperties.Perception = SkillPerceptionCheckBox.Checked;
            _characterProperties.Performance = SkillPerformanceCheckBox.Checked;
            _characterProperties.Persuassion = SkillPersuasionCheckBox.Checked;
            _characterProperties.Religion = SkillReligionCheckBox.Checked;
            _characterProperties.Sleight = SkillSleightofHandCheckBox.Checked;
            _characterProperties.Stealth = SkillStealthCheckBox.Checked;
            _characterProperties.Survival = SkillSurvivalCheckBox.Checked;

            _characterProperties.Feats = new List<object>();
            foreach (var feat in featsAndPerksListBox.Items)
            {
                _characterProperties.Feats.Add(feat);
            }

            _characterProperties.Weapon1 = meleeWeapon1ComboBox.SelectedIndex;
            _characterProperties.Weapon2 = meleeWeapon2ComboBox.SelectedIndex;
            _characterProperties.SpecialWeapon1 = specialWeaponCheckBox1.Checked;
            _characterProperties.SpecialWeapon2 = specialWeaponCheckBox2.Checked;
            _characterProperties.Ranged1 = rangedWeapon1ComboBox.SelectedIndex;
            _characterProperties.Ranged2 = rangedWeapon2ComboBox.SelectedIndex;
            _characterProperties.Armor = armorComboBox.SelectedIndex;
            _characterProperties.Shield = shieldComboBox.SelectedIndex;
            _characterProperties.Backpack = backpackTextBox.Text;
            _characterProperties.Plat = PlatiniumTextBox.Text;
            _characterProperties.Gold = goldAmountTextBox.Text;
            _characterProperties.Electrum = ElectrumAmountTextBox.Text;
            _characterProperties.Silver = silverAmountTextBox.Text;
            _characterProperties.Copper = copperAmountTextBox.Text;


            _characterProperties.Spellslevel0 = new List<object>();
            _characterProperties.Spellslevel1 = new List<object>();
            _characterProperties.Spellslevel2 = new List<object>();
            _characterProperties.Spellslevel3 = new List<object>();
            _characterProperties.Spellslevel4 = new List<object>();
            _characterProperties.Spellslevel5 = new List<object>();
            _characterProperties.Spellslevel6 = new List<object>();
            _characterProperties.Spellslevel7 = new List<object>();
            _characterProperties.Spellslevel8 = new List<object>();
            _characterProperties.Spellslevel9 = new List<object>();
            foreach (var spell in spellBookLevel0ListBox.Items)
            {
                _characterProperties.Spellslevel0.Add(spell);
            }
            foreach (var spell in spellBookLevel1listBox.Items)
            {
                _characterProperties.Spellslevel1.Add(spell);
            }
            foreach (var spell in spellBookLevel2listBox.Items)
            {
                _characterProperties.Spellslevel2.Add(spell);
            }
            foreach (var spell in spellBookLevel3ListBox.Items)
            {
                _characterProperties.Spellslevel3.Add(spell);
            }
            foreach (var spell in spellBookLevel4listBox.Items)
            {
                _characterProperties.Spellslevel4.Add(spell);
            }
            foreach (var spell in spellBookLevel5listBox.Items)
            {
                _characterProperties.Spellslevel5.Add(spell);
            }
            foreach (var spell in spellBookLevel6listBox.Items)
            {
                _characterProperties.Spellslevel6.Add(spell);
            }
            foreach (var spell in spellBookLevel7listBox.Items)
            {
                _characterProperties.Spellslevel7.Add(spell);
            }
            foreach (var spell in spellBookLevel8listBox.Items)
            {
                _characterProperties.Spellslevel8.Add(spell);
            }
            foreach (var spell in spellBookLevel9listBox.Items)
            {
                _characterProperties.Spellslevel9.Add(spell);
            }


            _characterProperties.MeleeWeaponList = new List<Weapon>();
            foreach (var weapon in _newWeaponList)
            {
                _characterProperties.MeleeWeaponList.Add(weapon);
            }

            _characterProperties.RangedWeaponList = new List<RangedWeapon>();
            foreach (var weapon in _newRangedWeaponList)
            {
                _characterProperties.RangedWeaponList.Add(weapon);
            }

            _characterProperties.ArmorsList = new List<Armors>();
            foreach (var armor in _newArmorsList)
            {
                _characterProperties.ArmorsList.Add(armor);
            }

            _characterProperties.Gender = genderComboBox.SelectedIndex;
            _characterProperties.Height = heightTextBox.Text;
            _characterProperties.Weight = weightTextBox.Text;
            _characterProperties.Hair = hairTextBox.Text;
            _characterProperties.Skin = skinTextBox.Text;
            _characterProperties.Eyes = EyesTextBox.Text;
            _characterProperties.Age = ageTextBox.Text;
            _characterProperties.Notes = notesTextBox.Text;
            _characterProperties.Describtion = descriptionTextBox.Text;
            if (AvatarPictureBox.Image != null) _characterProperties.Avatar = imageToByteArray(AvatarPictureBox.Image);
            if (pictureBox.Image != null) _characterProperties.Picture = imageToByteArray(pictureBox.Image);
        }

        static CharacterProperties DeserializeFromXml(string fileName)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(CharacterProperties));
            TextReader textReader = new StreamReader(fileName);
            CharacterProperties character;
            character = (CharacterProperties)deserializer.Deserialize(textReader);
            textReader.Close();

            return character;
        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Xml files (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            newToolStripMenuItem_Click(sender, e);

                            filePath = openFileDialog1.FileName;
                            _characterProperties = DeserializeFromXml(filePath);
                            // Insert code to read the stream here.
                            nameTextBox.Text = _characterProperties.Name;
                            raceComboBox.SelectedIndex = _characterProperties.Race;
                            classComboBox.SelectedIndex = _characterProperties.SelectedClass;
                            experienceCurrentTextBox.Text = _characterProperties.Experience;
                            LevelUpDown.Value = _characterProperties.Level;
                            archetypeComboBox.SelectedIndex = _characterProperties.Specialization;
                            aligmentComboBox.SelectedIndex = _characterProperties.Aligment;
                            sizeComboBox.SelectedIndex = _characterProperties.Size;
                            HealthTextBox.Text = _characterProperties.HitPoints;
                            woundsTextBox.Text = _characterProperties.Wounds;
                            strUpDown.Value = _characterProperties.Strength;
                            dexUpDown.Value = _characterProperties.Dextirity;
                            conUpDown.Value = _characterProperties.Constitution;
                            intUpDown.Value = _characterProperties.Intelligence;
                            wisUpDown.Value = _characterProperties.Wisdom;
                            chaUpDown.Value = _characterProperties.Charisma;
                            StrSavingProf.Checked = _characterProperties.StrenghtProficiency;
                            DexSavingProf.Checked = _characterProperties.DextirityProficiency;
                            ConSavingProf.Checked = _characterProperties.ConstitutionProficiency;
                            IntSavingProf.Checked = _characterProperties.IntelligenceProficiency;
                            WisSavingProf.Checked = _characterProperties.WisdomProficiency;
                            ChaSavingProf.Checked = _characterProperties.CharismaProficiency;
                            SkillAcrobaticsCheckBox.Checked = _characterProperties.Acrobatics;
                            SkillAnimalCheckBox.Checked = _characterProperties.Animal;
                            SkillArcanaCheckBox.Checked = _characterProperties.Arcana;
                            SkillAthleticssCheckBox.Checked = _characterProperties.Athletics;
                            SkillDeceptionCheckBox.Checked = _characterProperties.Deception;
                            SkillHistoryCheckBox.Checked = _characterProperties.History;
                            SkillInsightCheckBox.Checked = _characterProperties.Insight;
                            SkillIntimidationCheckBox.Checked = _characterProperties.Intimidation;
                            SkillInvestigationCheckBox.Checked = _characterProperties.Investigation;
                            SkillMedicineCheckBox.Checked = _characterProperties.Medicine;
                            SkillNatureCheckBox.Checked = _characterProperties.Nature;
                            SkillPerceptionCheckBox.Checked = _characterProperties.Perception;
                            SkillPerformanceCheckBox.Checked = _characterProperties.Performance;
                            SkillPersuasionCheckBox.Checked = _characterProperties.Persuassion;
                            SkillReligionCheckBox.Checked = _characterProperties.Religion;
                            SkillSleightofHandCheckBox.Checked = _characterProperties.Sleight;
                            SkillStealthCheckBox.Checked = _characterProperties.Stealth;
                            SkillSurvivalCheckBox.Checked = _characterProperties.Survival;

                            _newWeaponList.Clear();
                            foreach (var weapon in _characterProperties.MeleeWeaponList)
                            {
                                _newWeaponList.Add(weapon);
                            }

                            _newRangedWeaponList.Clear();
                            foreach (var weapon in _characterProperties.RangedWeaponList)
                            {
                                _newRangedWeaponList.Add(weapon);
                            }

                            _newArmorsList.Clear();
                            foreach (var armor in _characterProperties.ArmorsList)
                            {
                                _newArmorsList.Add(armor);
                            }
                            ItemsRefresh();
                            ItemsApplyChanged();

                            featsAndPerksListBox.Items.Clear();
                            foreach (var feat in _characterProperties.Feats)
                            {
                                featsAndPerksListBox.Items.Add(feat);
                            }

                            meleeWeapon1ComboBox.SelectedIndex = _characterProperties.Weapon1;
                            meleeWeapon2ComboBox.SelectedIndex = _characterProperties.Weapon2;
                            rangedWeapon1ComboBox.SelectedIndex = _characterProperties.Ranged1;
                            rangedWeapon2ComboBox.SelectedIndex = _characterProperties.Ranged2;
                            armorComboBox.SelectedIndex = _characterProperties.Armor;
                            shieldComboBox.SelectedIndex = _characterProperties.Shield;
                            otherAcBonusuesUpDown.Value = _characterProperties.AcBonus;
                            backpackTextBox.Text = _characterProperties.Backpack;

                            PlatiniumTextBox.Text = _characterProperties.Plat;
                            goldAmountTextBox.Text = _characterProperties.Gold;
                            ElectrumAmountTextBox.Text = _characterProperties.Electrum;
                            silverAmountTextBox.Text = _characterProperties.Silver;
                            copperAmountTextBox.Text = _characterProperties.Copper;

                            spellBookLevel0ListBox.Items.Clear();
                            spellBookLevel1listBox.Items.Clear();
                            spellBookLevel2listBox.Items.Clear();
                            spellBookLevel3ListBox.Items.Clear();
                            spellBookLevel4listBox.Items.Clear();
                            spellBookLevel5listBox.Items.Clear();
                            spellBookLevel6listBox.Items.Clear();
                            spellBookLevel7listBox.Items.Clear();
                            spellBookLevel8listBox.Items.Clear();
                            spellBookLevel9listBox.Items.Clear();
                            foreach (var spell in _characterProperties.Spellslevel0)
                            {
                                spellBookLevel0ListBox.Items.Add(spell);
                            }
                            foreach (var spell in _characterProperties.Spellslevel1)
                            {
                                spellBookLevel1listBox.Items.Add(spell);
                            }
                            foreach (var spell in _characterProperties.Spellslevel2)
                            {
                                spellBookLevel2listBox.Items.Add(spell);
                            }
                            foreach (var spell in _characterProperties.Spellslevel3)
                            {
                                spellBookLevel3ListBox.Items.Add(spell);
                            }
                            foreach (var spell in _characterProperties.Spellslevel4)
                            {
                                spellBookLevel4listBox.Items.Add(spell);
                            }
                            foreach (var spell in _characterProperties.Spellslevel5)
                            {
                                spellBookLevel5listBox.Items.Add(spell);
                            }
                            foreach (var spell in _characterProperties.Spellslevel6)
                            {
                                spellBookLevel6listBox.Items.Add(spell);
                            }
                            foreach (var spell in _characterProperties.Spellslevel7)
                            {
                                spellBookLevel7listBox.Items.Add(spell);
                            }
                            foreach (var spell in _characterProperties.Spellslevel8)
                            {
                                spellBookLevel8listBox.Items.Add(spell);
                            }
                            foreach (var spell in _characterProperties.Spellslevel9)
                            {
                                spellBookLevel9listBox.Items.Add(spell);
                            }

                            genderComboBox.SelectedIndex = _characterProperties.Gender;
                            heightTextBox.Text = _characterProperties.Height;
                            weightTextBox.Text = _characterProperties.Weight;
                            hairTextBox.Text = _characterProperties.Hair;
                            skinTextBox.Text = _characterProperties.Skin;
                            EyesTextBox.Text = _characterProperties.Eyes;
                            ageTextBox.Text = _characterProperties.Age;
                            notesTextBox.Text = _characterProperties.Notes;
                            descriptionTextBox.Text = _characterProperties.Describtion;
                            LevelUpDown_ValueChanged(sender, e);

                            specialWeaponCheckBox1.Checked = _characterProperties.SpecialWeapon1;
                            specialWeaponCheckBox2.Checked = _characterProperties.SpecialWeapon2;

                            if (_characterProperties.Avatar != null) AvatarPictureBox.Image = byteArrayToImage(_characterProperties.Avatar);
                            if (_characterProperties.Picture != null) pictureBox.Image = byteArrayToImage(_characterProperties.Picture);
                            CalculateHp();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
