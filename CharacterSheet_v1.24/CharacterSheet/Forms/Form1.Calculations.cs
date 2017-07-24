using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CharacterSheet.Items;
using CharacterSheet.Weapons;

namespace CharacterSheet
{
    public partial class Form1 : Form
    {
        public Weapon AddWeapon(string name, string damageDice, string damageType, string weaponKind, string slot, string greaterDamge = "", bool finesse = false, bool disposable = false)
        {
            Weapon weapon = new Weapon();
            weapon.Name = name;
            weapon.DamageDice = damageDice;
            weapon.DamageType = damageType;
            weapon.WeaponKind = weaponKind;
            weapon.WeaponSlot = slot;
            weapon.GreaterDamageDice = greaterDamge;
            weapon.IsFinese = finesse;
            weapon.IsDisposable = disposable;
            return weapon;
        }

        public RangedWeapon AddRangedWeapon(string name, string damageDice, string damageType, string weaponKind, string slot,int minRange, int maxRange, bool finesse = false, bool disposable = false)
        {
            RangedWeapon weapon = new RangedWeapon();
            weapon.Name = name;
            weapon.DamageDice = damageDice;
            weapon.DamageType = damageType;
            weapon.WeaponKind = weaponKind;
            weapon.WeaponSlot = slot;
            weapon.IsFinese = finesse;
            weapon.MinRange = minRange;
            weapon.MaxRange = maxRange;
            weapon.IsDisposable = disposable;
            return weapon;
        }

        public Armors AddArmors(string name, string type, int baseAc, int maxDex, bool disposable = false)
        {
            Armors armor = new Armors();
            armor.Name = name;
            armor.Type = type;
            armor.BaseAc = baseAc;
            armor.MaxDex = maxDex;
            armor.IsDisposable = disposable;
            return armor;
        }

        public FeatInfo AddFeatInfo(string name, string info)
        {
            FeatInfo featInfo = new FeatInfo();
            featInfo.Name = name;
            featInfo.Info = info;
            return featInfo;
        }

        //zapelnianie listy featow z pliku
        public List<FeatInfo> CreateFeatInfo(string file)
        {
            string name;
            string info = "";

            List<FeatInfo> theList = new List<FeatInfo>();

            try
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    string line;

                    line = sr.ReadLine();

                    while (line != null)
                    {
                        info = "";
                        if (String.IsNullOrEmpty(line))
                        {
                            line = sr.ReadLine();
                        }
                        name = line;
                        while (!String.IsNullOrEmpty(line = sr.ReadLine()))
                        {
                            info = info + line + Environment.NewLine;
                        }
                        FeatInfo feat = AddFeatInfo(name, info);
                        theList.Add(feat);
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            return theList;
        }

        //z resourca
        private List<FeatInfo> AddFeatFromResource(string data)
        {
            string name = "";
            string info= "";
            List<FeatInfo> theList = new List<FeatInfo>();

            string[] feats = data.Split(new string[] {"\r\n\r\n"}, StringSplitOptions.None);
            foreach (var feat in feats)
            {
                string[] part = feat.Split(new string[] {"\r\n"}, StringSplitOptions.None);
                if (part[0] == "" || part[1] == "") break;
                name = part[0];
                info = part[1];
                FeatInfo featParsed = AddFeatInfo(name, info);
                theList.Add(featParsed);
            }
            return theList;
        }

        public List<Weapon> CreateBasicWeaponsList()
        {
            List<Weapon> theList = new List<Weapon>();
            Weapon unarmed = AddWeapon("Unarmed Strike", "1", "Bludgeoning", "Simple Weapon", "1hand");
            Weapon none = AddWeapon("None", "NA", "NA", "NA", "NA");
            Weapon club = AddWeapon("Club", "1d6", "Bludgeoning", "Simple Weapon", "1hand");
            Weapon dagger = AddWeapon("Dagger", "1d4", "Piercing", "Simple Weapon", "1hand", finesse: true);
            Weapon greatclub = AddWeapon("Greatclub", "1d8", "Bludgeoning", "Simple Weapon", "2hand");
            Weapon handaxe = AddWeapon("Handaxe", "1d6", "Slashing", "Simple Weapon", "1hand");
            Weapon javelin = AddWeapon("Javelin", "1d6", "Piercing", "Simple Weapon", "1hand");
            Weapon lightHammer = AddWeapon("Light hammer", "1d4", "Bludgeoning", "Simple Weapon", "1hand");
            Weapon mace = AddWeapon("Mace", "1d6", "Bludgeoning", "Simple Weapon", "1hand");
            Weapon quarterstaff = AddWeapon("Quarterstaff", "1d6", "Bludgeoning", "Simple Weapon", "Versatile", "1d8");
            Weapon sickle = AddWeapon("Sickle", "1d4", "Slashing", "Simple Weapon", "1hand");
            Weapon spear = AddWeapon("Spear", "1d6", "Piercing", "Simple Weapon", "Versatile", "1d8");
            Weapon battleaxe = AddWeapon("Battleaxe", "1d8", "Slashing", "Martial Weapon", "Versatile", "1d10");
            Weapon flail = AddWeapon("Flail", "1d6", "Bludgeoning", "Martial Weapon", "1hand");
            Weapon glaive = AddWeapon("Glaive", "1d10", "Slashing", "Martial Weapon", "2hand");
            Weapon greataxe = AddWeapon("Greataxe", "1d12", "Slashing", "Martial Weapon", "2hand");
            Weapon greatsword = AddWeapon("Greatsword", "2d6", "Slashing", "Martial Weapon", "2hand");
            Weapon halberd = AddWeapon("Halberd", "1d10", "Slashing", "Martial Weapon", "2hand");
            Weapon lance = AddWeapon("Lance", "1d12", "Piercing", "Martial Weapon", "1hand");
            Weapon longsword = AddWeapon("Longsword", "1d8", "Slashing", "Martial Weapon", "Versatile", "1d10");
            Weapon maul = AddWeapon("Maul", "2d6", "Bludgeoning", "Martial Weapon", "2hand");
            Weapon morningstar = AddWeapon("Morningstar", "1d8", "Piercing", "Martial Weapon", "1hand");
            Weapon pike = AddWeapon("Pike", "1d10", "Piercing", "Martial Weapon", "2hand");
            Weapon rapier = AddWeapon("Rapier", "1d8", "Piercing", "Martial Weapon", "1hand", finesse: true);
            Weapon scimitar = AddWeapon("Scimitar", "1d6", "Slashing", "Martial Weapon", "1hand", finesse: true);
            Weapon shortsword = AddWeapon("Shortsword", "1d6", "Piercing", "Martial Weapon", "1hand", finesse: true);
            Weapon trident = AddWeapon("Trident", "1d6", "Piercing", "Martial Weapon", "Versatile", "1d8");
            Weapon warpick = AddWeapon("Warpick", "1d8", "Piercing", "Martial Weapon", "1hand");
            Weapon warhammer = AddWeapon("Warhammer", "1d8", "Bludgeoning", "Martial Weapon", "Versatile", "1d10");
            Weapon whip = AddWeapon("Whip", "1d4", "Slashing", "Martial Weapon", "1hand", finesse: true);

            theList.Add(unarmed);
            theList.Add(none);
            theList.Add(club);
            theList.Add(dagger);
            theList.Add(greatclub);
            theList.Add(handaxe);
            theList.Add(javelin);
            theList.Add(lightHammer);
            theList.Add(mace);
            theList.Add(quarterstaff);
            theList.Add(sickle);
            theList.Add(spear);
            theList.Add(battleaxe);
            theList.Add(flail);
            theList.Add(glaive);
            theList.Add(greataxe);
            theList.Add(greatsword);
            theList.Add(halberd);
            theList.Add(lance);
            theList.Add(longsword);
            theList.Add(maul);
            theList.Add(morningstar);
            theList.Add(pike);
            theList.Add(rapier);
            theList.Add(scimitar);
            theList.Add(shortsword);
            theList.Add(trident);
            theList.Add(warpick);
            theList.Add(warhammer);
            theList.Add(whip);
            return theList;
        }

        public List<RangedWeapon> CreateBasicRangedWeaponList()
        {
            List<RangedWeapon> theList = new List<RangedWeapon>();

            RangedWeapon none = AddRangedWeapon("None", "NA", "NA", "NA", "NA", 0, 0);
            RangedWeapon lightCrossbow = AddRangedWeapon("Light Crossbow", "1d6", "Piercing", "Simple Weapon", "2hand", 80, 320);
            RangedWeapon dart = AddRangedWeapon("Dart", "1d4", "Piercing", "Simple Weapon", "1hand", 20, 60, true);
            RangedWeapon shortbow = AddRangedWeapon("Shortbow", "1d6", "Piercing", "Simple Weapon", "2hand", 80, 320);
            RangedWeapon sling = AddRangedWeapon("Sling", "1d4", "Bludgeoning", "Simple Weapon", "1hand", 30, 120);
            RangedWeapon dagger = AddRangedWeapon("Dagger", "1d4", "Piercing", "Simple Weapon", "1hand", 20, 60, true);
            RangedWeapon handaxe = AddRangedWeapon("Handaxe", "1d6", "Slashing", "Simple Weapon", "1hand", 20, 60);
            RangedWeapon javelin = AddRangedWeapon("Javelin", "1d6", "Piercing", "Simple Weapon", "1hand", 30, 120);
            RangedWeapon lightHammer = AddRangedWeapon("Light hammer", "1d4", "Bludgeoning", "Simple Weapon", "1hand", 20, 60);
            RangedWeapon spear = AddRangedWeapon("Spear", "1d6", "Piercing", "Simple Weapon", "1hand", 20, 60);
            RangedWeapon blowgun = AddRangedWeapon("Blowgun", "1", "Piercing", "Martial Weapon", "1hand", 25, 100);
            RangedWeapon handCrossbow = AddRangedWeapon("Hand Crossbow", "1d6", "Piercing", "Martial Weapon", "1hand", 30, 120);
            RangedWeapon heavyCrossbow = AddRangedWeapon("Heavy Crossbow", "1d10", "Piercing", "Martial Weapon", "2hand", 100, 400);
            RangedWeapon longBow = AddRangedWeapon("Longbow", "1d8", "Piercing", "Martial Weapon", "2hand", 150, 600);
            RangedWeapon net = AddRangedWeapon("Net", "NA", "NA", "Martial Weapon", "1hand", 5, 15);

            theList.Add(none);
            theList.Add(lightCrossbow);
            theList.Add(dart);
            theList.Add(shortbow);
            theList.Add(sling);
            theList.Add(dagger);
            theList.Add(handaxe);
            theList.Add(javelin);
            theList.Add(lightHammer);
            theList.Add(spear);
            theList.Add(blowgun);
            theList.Add(handCrossbow);
            theList.Add(heavyCrossbow);
            theList.Add(longBow);
            theList.Add(net);
            return theList;
        }

        public List<Armors> CreateBasicArmors()
        {
            List<Armors> theList = new List<Armors>();

            Armors none = AddArmors("None", "Light Armor", 10, 10);
            Armors padded = AddArmors("Padded", "Light Armor", 11, 10);
            Armors leather = AddArmors("Leather", "Light Armor", 11, 10);
            Armors studdedLeather = AddArmors("Studded Leather", "Light Armor", 12, 10);
            Armors hide = AddArmors("Hide", "Medium Armor", 12, 2);
            Armors chainShirt = AddArmors("Chain shirt", "Medium Armor", 13, 2);
            Armors scaleMail = AddArmors("Scale mail", "Medium Armor", 14, 2);
            Armors breastPlate = AddArmors("Breastplate", "Medium Armor", 14, 2);
            Armors halfPlate = AddArmors("Halfplate", "Medium Armor", 15, 2);
            Armors ringmail = AddArmors("Ring mail", "Heavy Armor", 14, 0);
            Armors chainMail = AddArmors("Chain mail", "Heavy Armor", 16, 0);
            Armors splint = AddArmors("Splint", "Heavy Armor", 17, 0);
            Armors plate = AddArmors("Plate", "Heavy Armor", 18, 0);

            theList.Add(none);
            theList.Add(padded);
            theList.Add(leather);
            theList.Add(studdedLeather);
            theList.Add(hide);
            theList.Add(chainShirt);
            theList.Add(scaleMail);
            theList.Add(breastPlate);
            theList.Add(halfPlate);
            theList.Add(ringmail);
            theList.Add(chainMail);
            theList.Add(splint);
            theList.Add(plate);

            return theList;
        }
        private void SetUpDecaultCharacter()
        {
            //setup weapons
            ItemsApplyChanged();

            //starting gear
            armorComboBox.SelectedIndex = 0;
            shieldComboBox.SelectedIndex = 0;
            meleeWeapon1ComboBox.SelectedIndex = 0;
            meleeWeapon2ComboBox.SelectedIndex = 0;
            rangedWeapon1ComboBox.SelectedIndex = 0;
            rangedWeapon2ComboBox.SelectedIndex = 0;

            //starting stats
            CalculateSpeed();
            CalculateAvaliableFeats();
            _newcharacter.Strength = 10;
            _newcharacter.Dextirity = 10;
            _newcharacter.Constitution = 10;
            _newcharacter.Intelligence = 10;
            _newcharacter.Wisdom = 10;
            _newcharacter.Charisma = 10;

            strUpDown.Value = _newcharacter.Strength;
            strActualTextBox.Text = strUpDown.Value.ToString("G");
            dexUpDown.Value = _newcharacter.Dextirity;
            dexActualTextBox.Text = dexUpDown.Value.ToString("G");
            conUpDown.Value = _newcharacter.Constitution;
            conActualTextBox.Text = conUpDown.Value.ToString("G");
            intUpDown.Value = _newcharacter.Intelligence;
            intActualTextBox.Text = intUpDown.Value.ToString("G");
            wisUpDown.Value = _newcharacter.Wisdom;
            wisActualTextBox.Text = wisUpDown.Value.ToString("G");
            chaUpDown.Value = _newcharacter.Charisma;
            chaActualTextBox.Text = chaUpDown.Value.ToString("G");

            //starting race and class
            raceComboBox.SelectedIndex = 0;
            classComboBox.SelectedIndex = 0;

            //exp n level
            experienceCurrentTextBox.Text = "0";
            experienceRequiredTextBox.Text = "300";
        }

        private void VisibleAttributesChangers(bool state)
        {
            strUpDown.Enabled = state;
            dexUpDown.Enabled = state;
            conUpDown.Enabled = state;
            intUpDown.Enabled = state;
            wisUpDown.Enabled = state;
            chaUpDown.Enabled = state;

            strUpDown.Visible = state;
            dexUpDown.Visible = state;
            conUpDown.Visible = state;
            intUpDown.Visible = state;
            wisUpDown.Visible = state;
            chaUpDown.Visible = state;
        }
        private void ItemsApplyChanged()
        {
            //weaponlist
            meleeWeapon1ComboBox.DataSource = _newWeaponList.ToList();
            meleeWeapon1ComboBox.DisplayMember = "Name";
            meleeWeapon1ComboBox.ValueMember = "Name";
            meleeWeaponsListBox.DataSource = _newWeaponList.ToList();
            meleeWeaponsListBox.DisplayMember = "Name";
            meleeWeaponsListBox.ValueMember = "Name";

            meleeWeapon2ComboBox.DataSource = _newWeaponList.ToList();
            meleeWeapon2ComboBox.DisplayMember = "Name";
            meleeWeapon2ComboBox.ValueMember = "Name";

            rangedWeapon1ComboBox.DataSource = _newRangedWeaponList.ToList();
            rangedWeapon1ComboBox.DisplayMember = "Name";
            rangedWeapon1ComboBox.ValueMember = "Name";
            rangedWeaponsListBox.DataSource = _newRangedWeaponList.ToList();
            rangedWeaponsListBox.DisplayMember = "Name";
            rangedWeaponsListBox.ValueMember = "Name";

            rangedWeapon2ComboBox.DataSource = _newRangedWeaponList.ToList();
            rangedWeapon2ComboBox.DisplayMember = "Name";
            rangedWeapon2ComboBox.ValueMember = "Name";

            armorComboBox.DataSource = _newArmorsList.ToList();
            armorComboBox.DisplayMember = "Name";
            armorComboBox.ValueMember = "Name";
            armorListBox.DataSource = _newArmorsList.ToList();
            armorListBox.DisplayMember = "Name";
            armorListBox.ValueMember = "Name";
        }

        private void ItemsRefresh()
        {
            meleeWeaponsListBox.DataSource = null;
            meleeWeaponsListBox.Items.Clear();
            meleeWeaponsListBox.DataSource = _newWeaponList.ToList();

            meleeWeapon1ComboBox.DataSource = null;
            meleeWeapon1ComboBox.Items.Clear();
            meleeWeapon1ComboBox.DataSource = _newWeaponList.ToList();
            meleeWeapon2ComboBox.DataSource = null;
            meleeWeapon2ComboBox.Items.Clear();
            meleeWeapon2ComboBox.DataSource = _newWeaponList.ToList();

            rangedWeaponsListBox.DataSource = null;
            rangedWeaponsListBox.Items.Clear();
            rangedWeaponsListBox.DataSource = _newRangedWeaponList.ToList();

            armorListBox.DataSource = null;
            armorListBox.Items.Clear();
            armorListBox.DataSource = _newArmorsList.ToList();
        }
        private void RaceUpdate(Race race)
        {
            strActualTextBox.Text = race.Strength.ToString("G");
            dexActualTextBox.Text = race.Dextirity.ToString("G");
            conActualTextBox.Text = race.Constitution.ToString("G");
            intActualTextBox.Text = race.Intelligence.ToString("G");
            wisActualTextBox.Text = race.Wisdom.ToString("G");
            chaActualTextBox.Text = race.Charisma.ToString("G");
        }

        public void CalculateAc(decimal armorAc, decimal maxDex)
        {
            var shieldAc = 0;
            decimal classBonus = 0;
            var bonus = otherAcBonusuesUpDown.Value;
            if (shieldComboBox.SelectedIndex == 1) shieldAc = 2;
            var dexModifier = decimal.Parse(DexModTextBox.Text);
            if (dexModifier > maxDex) dexModifier = maxDex;
            if (armorComboBox.SelectedIndex == 0)
            {
                if (classComboBox.Text == "Monk") classBonus = int.Parse(WisModTextBox.Text);
                if (classComboBox.Text == "Barbarian") classBonus = int.Parse(ConModTextBox.Text);
            }
            var newAc = armorAc + dexModifier + shieldAc + bonus+ classBonus;
            ArmorClassTextBox.Text = newAc.ToString("G");
            AcBaseTextBox.Text = _newArmorsList[armorComboBox.SelectedIndex].BaseAc.ToString("G");
            AcDexTextBox.Text = dexModifier.ToString("G");
            AcOtherTextBox.Text = otherAcBonusuesUpDown.Value.ToString("G");
        }

        public void SetAc()
        {
            decimal armorAc;
            decimal maxDex;

            if (armorComboBox.SelectedIndex == 0) armorAc = 10 + _newcharacter.NaturalArmor;
            else armorAc = _newArmorsList[armorComboBox.SelectedIndex].BaseAc;
            maxDex = _newArmorsList[armorComboBox.SelectedIndex].MaxDex;
            CalculateAc(armorAc, maxDex);
        }

        private void CalculateAvaliableFeats()
        {
            featsAvaliableTextBox.Text = Math.Floor((LevelUpDown.Value / 4) - featsAndPerksListBox.Items.Count).ToString("");
            if (int.Parse(featsAvaliableTextBox.Text) == 0) featsAndPerksAddButton.Visible = false;
            else featsAndPerksAddButton.Visible = true;
            if (int.Parse(featsAvaliableTextBox.Text) < 0) featsAndPerksListBox.Items.RemoveAt(0);
            featsAvaliableTextBox.Text = Math.Floor((LevelUpDown.Value / 4) - featsAndPerksListBox.Items.Count).ToString("");
        }
        private void CalculateSpeed()
        {
            int Speed=0;
            if (sizeComboBox.SelectedIndex == 0) Speed = 30;
            if (sizeComboBox.SelectedIndex == 1) Speed = 25;
            if (sizeComboBox.SelectedIndex == 2) Speed = 35;
            Speed = Speed + _newcharacter.SpeedModifier;
            SpeedTextBox.Text = Speed.ToString("G") + "ft.";

            if (int.Parse(strActualTextBox.Text) < 13 && armorComboBox.Text == "Chain mail") SpeedTextBox.Text = (Speed - 10).ToString("G");
            if (int.Parse(strActualTextBox.Text) < 15 && armorComboBox.Text == "Splint") SpeedTextBox.Text = (Speed - 10).ToString("G");
            if (int.Parse(strActualTextBox.Text) < 15 && armorComboBox.Text == "Plate") SpeedTextBox.Text = (Speed - 10).ToString("G");
        }

        private void CalculateHp()
        {
            if(woundsTextBox.Text != "" && HealthTextBox.Text != "")
                healthLeft.Text = (int.Parse(HealthTextBox.Text) - int.Parse(woundsTextBox.Text)).ToString("G");
        }

        public void SkillValue(string name, decimal attributeModifier, bool proficiency)
        {
            TabPage page = tabControl1.TabPages[0];
            var fieldValueName = "Skill" + name + "ValueTextBox";
            var skillValueControl = page.Controls[fieldValueName];

            var proficiencyBonus = 0;
            if (proficiency) proficiencyBonus = int.Parse(ProficiencyVisibleTextBox.Text);
            skillValueControl.Text = (attributeModifier + proficiencyBonus).ToString("G");
        }
        public decimal CalculateModifier(string attribute)
        {
            var attributeModifier = (decimal.Parse(attribute) - 10) / 2;
            attributeModifier = Math.Floor(attributeModifier);
            return attributeModifier;
        }

        private void SetUpMeleeWeapon(int weaponNumber)
        {
            string attribute = "Str";
            TabPage aimedPage = tabControl1.TabPages[1];
            var meleeWeaponName = "meleeWeapon" + weaponNumber + "ComboBox";
            var meleeWeaponAttack = "meleeWeapon" + weaponNumber + "AttackTextBox";
            var meleeWeaponDamage = "meleeWeapon" + weaponNumber + "DamageTextBox";
            var meleeWeaponType = "meleeWeapon" + weaponNumber + "TypeTextBox";
            var meleeIsProficient = "isProficientMelee" + weaponNumber;
            var specialWeaponAttribute = "specialWeaponCheckBox" + weaponNumber;

            var meleeWeaponNameControl = aimedPage.Controls[meleeWeaponName] as ComboBox;
            var meleeWeaponAttackControl = aimedPage.Controls[meleeWeaponAttack];
            var meleeWeaponDamageControl = aimedPage.Controls[meleeWeaponDamage];
            var meleeWeaponTypeControl = aimedPage.Controls[meleeWeaponType];
            var meleeIsProficientControl = aimedPage.Controls[meleeIsProficient]as CheckBox;
            var specialWeaponAttributeControl = aimedPage.Controls[specialWeaponAttribute] as CheckBox;

            if (meleeWeaponNameControl.SelectedIndex > -1)
            {

                specialWeaponAttributeControl.Enabled = true;
                specialWeaponAttributeControl.Visible = false;
                specialWeaponAttributeControl.Text = "use Dextirity";

                //check if u are proficient
                foreach (string proficiency in equipmentProficiencyListBox.Items)
                {
                    if (proficiency == meleeWeaponNameControl.Text ||
                        proficiency == _newWeaponList[meleeWeaponNameControl.SelectedIndex].WeaponKind)
                    {
                        meleeIsProficientControl.Checked = true;
                        break;
                    }
                    meleeIsProficientControl.Checked = false;
                }

                //if Finesse weap, use dex when selected
                if (_newWeaponList[meleeWeaponNameControl.SelectedIndex].IsFinese)
                {
                    specialWeaponAttributeControl.Visible = true;
                    if (specialWeaponAttributeControl.Checked) attribute = "Dex";
                }

                //if None weapon selected
                if (_newWeaponList[meleeWeaponNameControl.SelectedIndex].Name != "None")
                {
                    meleeWeaponAttackControl.Text = CalculateAttack(attribute, meleeIsProficientControl.Checked);
                    meleeWeaponDamageControl.Text =
                        CalculateDamage(_newWeaponList[meleeWeaponNameControl.SelectedIndex].DamageDice, attribute);
                }
                else
                {
                    meleeWeaponAttackControl.Text = "NA";
                    meleeWeaponDamageControl.Text = _newWeaponList[meleeWeaponNameControl.SelectedIndex].DamageDice;
                }
                meleeWeaponTypeControl.Text = _newWeaponList[meleeWeaponNameControl.SelectedIndex].DamageType;
      
                //if 2 handed weap, lock another weapon
                if (_newWeaponList[meleeWeaponNameControl.SelectedIndex].WeaponSlot == "2hand")
                {
                    specialWeaponAttributeControl.Text = "use 2 hands";
                    specialWeaponAttributeControl.Visible = true;
                    specialWeaponAttributeControl.Checked = true;
                    specialWeaponAttributeControl.Enabled = false;
                }
                //if versatile weap, use greater dice if selected to do so
                if (_newWeaponList[meleeWeaponNameControl.SelectedIndex].WeaponSlot == "Versatile")
                {
                    specialWeaponAttributeControl.Text = "use 2 hands";
                    specialWeaponAttributeControl.Visible = true;
                    if (specialWeaponAttributeControl.Checked)
                        meleeWeaponDamageControl.Text =
                            CalculateDamage(_newWeaponList[meleeWeaponNameControl.SelectedIndex].GreaterDamageDice,
                                attribute);
                    else
                        meleeWeaponDamageControl.Text =
                            CalculateDamage(_newWeaponList[meleeWeaponNameControl.SelectedIndex].DamageDice, attribute);
                }
            }
        }

        private void SetUpRangedWeapon(int weaponNumber)
        {
            string attribute = "Dex";
            TabPage aimedPage = tabControl1.TabPages[1];
            var rangedWeaponName = "rangedWeapon" + weaponNumber + "ComboBox";
            var rangedWeaponAttack = "rangedWeapon" + weaponNumber + "AttackTextBox";
            var rangedWeaponDamage = "rangedWeapon" + weaponNumber + "DamageTextBox";
            var rangedWeaponType = "rangedWeapon" + weaponNumber + "TypeTextBox";
            var rangedWeaponRange = "rangedWeapon" + weaponNumber + "RangeTextBox";
            var isProficientRanged = "isProficientRanged" + weaponNumber;
            var rangedWeapon2hands = "ranged2handsCheckBox" + weaponNumber;

            var rangedWeaponNameControl = aimedPage.Controls[rangedWeaponName] as ComboBox;
            var rangedWeaponAttackControl = aimedPage.Controls[rangedWeaponAttack];
            var rangedWeaponDamageControl = aimedPage.Controls[rangedWeaponDamage];
            var rangedWeaponTypeControl = aimedPage.Controls[rangedWeaponType];
            var rangedWeaponRangeControl = aimedPage.Controls[rangedWeaponRange];
            var isProficientRangedControl = aimedPage.Controls[isProficientRanged] as CheckBox;
            var rangedWeapon2handsControl = aimedPage.Controls[rangedWeapon2hands] as CheckBox;

            rangedWeapon2handsControl.Visible = false;
            rangedWeapon2handsControl.Text = "2 handed";
            if (rangedWeapon2handsControl.Enabled) rangedWeapon2handsControl.Enabled = false;

            if (_newRangedWeaponList[rangedWeaponNameControl.SelectedIndex].Name == "None")
            {
                rangedWeaponAttackControl.Text = _newRangedWeaponList[rangedWeaponNameControl.SelectedIndex].DamageDice;
                rangedWeaponDamageControl.Text = _newRangedWeaponList[rangedWeaponNameControl.SelectedIndex].DamageDice;
                rangedWeaponTypeControl.Text = _newRangedWeaponList[rangedWeaponNameControl.SelectedIndex].DamageType;
                rangedWeaponRangeControl.Text = "NA";
            }
            else
            {
                foreach (string proficiency in equipmentProficiencyListBox.Items)
                {
                    if (proficiency == rangedWeaponNameControl.Text ||
                        proficiency == _newRangedWeaponList[rangedWeaponNameControl.SelectedIndex].WeaponKind)
                    {
                        isProficientRangedControl.Checked = true;
                        break;
                    }
                    isProficientRangedControl.Checked = false;
                }

                //if Finesse weap, use dex when selected
                if (_newRangedWeaponList[rangedWeaponNameControl.SelectedIndex].IsFinese)
                {
                    rangedWeapon2handsControl.Text = "use Dextirity";
                    rangedWeapon2handsControl.Visible = true;
                    rangedWeapon2handsControl.Enabled = true;
                    if (rangedWeapon2handsControl.Checked) attribute = "Dex";
                    else attribute = "Str";
                }

                rangedWeaponAttackControl.Text = CalculateAttack(attribute, isProficientRangedControl.Checked);
                rangedWeaponDamageControl.Text =
                    CalculateDamage(_newRangedWeaponList[rangedWeaponNameControl.SelectedIndex].DamageDice, attribute);
                rangedWeaponTypeControl.Text = _newRangedWeaponList[rangedWeaponNameControl.SelectedIndex].DamageType;
                rangedWeaponRangeControl.Text =
                    _newRangedWeaponList[rangedWeaponNameControl.SelectedIndex].MinRange.ToString("G") + "/" +
                    _newRangedWeaponList[rangedWeaponNameControl.SelectedIndex].MaxRange.ToString("G");

                //if 2 handed weap, lock another weapon
                if (_newRangedWeaponList[rangedWeaponNameControl.SelectedIndex].WeaponSlot == "2hand")
                {
                    rangedWeapon2handsControl.Text = "use 2 hands";
                    rangedWeapon2handsControl.Visible = true;
                    rangedWeapon2handsControl.Checked = true;
                }
            }
        }

        private string CalculateDamage(string damageDice, string attributeName)
        {
            var rageBonus = 0;
            var damageBonus = 0;
            if (rageCheckBox.Visible && rageCheckBox.Checked) rageBonus = int.Parse(rageDamageTextBox.Text);
            TabPage aimedPage = tabControl1.TabPages[0];
            var fieldValueName = attributeName + "ModTextBox";
            var attributeModifierControl = aimedPage.Controls[fieldValueName];

            damageBonus = int.Parse(attributeModifierControl.Text) + rageBonus;
            if (damageBonus > 0) return damageDice + "+" + damageBonus.ToString("G");
            if (damageBonus < 0) return damageDice + damageBonus.ToString("G");
            return damageDice;
        }

        private string CalculateAttack(string attributeName, bool isProficient)
        {
            int attackBonus;

            TabPage profPage = tabControl1.TabPages[0];
            var proficiencyValueName = "ProficiencyVisibleTextBox";

            TabPage aimedPage = tabControl1.TabPages[0];
            var fieldValueName = attributeName + "ModTextBox";

            var attributeModifierControl = aimedPage.Controls[fieldValueName];
            var proficiencyControl = profPage.Controls[proficiencyValueName];

            var attributeModifier = int.Parse(attributeModifierControl.Text);
            int proficiencyBonus;
            if (isProficient) proficiencyBonus = int.Parse(proficiencyControl.Text);
            else proficiencyBonus = 0;
            attackBonus = attributeModifier + proficiencyBonus;
            if (attackBonus > 0) return "+" + attackBonus;
            return attackBonus.ToString();
        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void ItemProficiencies()
        {
            equipmentProficiencyListBox.Items.Clear();
            equipmentProficiencyListBox.Items.AddRange(_newClass.ItemProficiencies.ToArray());
            List<string> lista = _newcharacter.ItemProficiencies.Except(_newClass.ItemProficiencies).ToList();
            equipmentProficiencyListBox.Items.AddRange(lista.ToArray());
        }
    }
    //////////////////////////
}
