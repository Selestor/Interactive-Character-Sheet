using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CharacterSheet.Items;
using CharacterSheet.Properties;
using CharacterSheet.Weapons;

namespace CharacterSheet
{
    public partial class Form1
    {
        private readonly EasterEgg _sequence = new EasterEgg();
        private Race _newcharacter = new Race();
        private Classes _newClass = new Classes();
        private CharacterProperties _characterProperties = new CharacterProperties();
        private List<Weapon> _newWeaponList;
        private List<RangedWeapon> _newRangedWeaponList;
        private List<Armors> _newArmorsList;
        private List<FeatInfo> _newFeatInfoList = new List<FeatInfo>();

        public Form1()
        {
            _newWeaponList = CreateBasicWeaponsList();
            _newRangedWeaponList = CreateBasicRangedWeaponList();
            _newArmorsList = CreateBasicArmors();

            //var file = "Feats.txt";
            //_newFeatInfoList = CreateFeatInfo(file);
            //_newFeatInfoList.AddRange(CreateFeatInfo(file));
            _newFeatInfoList = AddFeatFromResource(Resources.RogueFeats);

            InitializeComponent();
            SetUpDecaultCharacter();
        }

        private void percentcalc(object sender, EventArgs e)
        {
            percentTextbox.Text = (Double.Parse(healthLeft.Text)/Double.Parse(HealthTextBox.Text)*100/100).ToString("P");
        }
    }
}
