using System;
using System.Windows.Forms;

namespace CharacterSheet
{
    public partial class Form1
    {
        private void StrSavingProf_CheckedChanged(object sender, EventArgs e)
        {
            StrUpDown_ValueChanged(sender, e);
        }

        private void DexSavingProf_CheckedChanged(object sender, EventArgs e)
        {
            DexUpDown_ValueChanged(sender, e);
        }

        private void ConSavingProf_CheckedChanged(object sender, EventArgs e)
        {
            ConUpDown_ValueChanged(sender, e);
        }

        private void IntSavingProf_CheckedChanged(object sender, EventArgs e)
        {
            IntUpDown_ValueChanged(sender, e);
        }

        private void WisSavingProf_CheckedChanged(object sender, EventArgs e)
        {
            WisUpDown_ValueChanged(sender, e);
        }

        private void ChaSavingProf_CheckedChanged(object sender, EventArgs e)
        {
            ChaUpDown_ValueChanged(sender, e);
        }
        private void armorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetAc();
            CalculateSpeed();
        }

        private void shieldComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetAc();
        }

        private void SkillChecked(object sender, EventArgs e)
        {
            RefreshAttributes(sender, e);
        }

        private void sizeComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            CalculateSpeed();
        }

        private void archetypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            classComboBox_SelectedIndexChanged(sender, e);
        }
        private void rageCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            meleeWeapon1ComboBox_SelectedIndexChanged(sender, e);
            meleeWeapon2ComboBox_SelectedIndexChanged(sender, e);
        }

        private void otherAcBonusuesUpDown_ValueChanged(object sender, EventArgs e)
        {
            armorComboBox_SelectedIndexChanged(sender, e);
        }

        private void addLevel0_Click(object sender, EventArgs e)
        {
            spellBookLevel0ListBox.Items.Add(level0TextBox.Text);
            level0TextBox.Text = null;
        }

        private void addLevel1_Click(object sender, EventArgs e)
        {
            spellBookLevel1listBox.Items.Add(level1TextBox.Text);
            level1TextBox.Text = null;
        }

        private void addLevel2_Click(object sender, EventArgs e)
        {
            spellBookLevel2listBox.Items.Add(level2TextBox.Text);
            level2TextBox.Text = null;
        }

        private void addLevel3_Click(object sender, EventArgs e)
        {
            spellBookLevel3ListBox.Items.Add(level3TextBox.Text);
            level3TextBox.Text = null;
        }

        private void addLevel4_Click(object sender, EventArgs e)
        {
            spellBookLevel4listBox.Items.Add(level4TextBox.Text);
            level4TextBox.Text = null;
        }

        private void addLevel5_Click(object sender, EventArgs e)
        {
            spellBookLevel5listBox.Items.Add(level5TextBox.Text);
            level5TextBox.Text = null;
        }

        private void addLevel6_Click(object sender, EventArgs e)
        {
            spellBookLevel6listBox.Items.Add(level6TextBox.Text);
            level6TextBox.Text = null;
        }

        private void addLevel7_Click(object sender, EventArgs e)
        {
            spellBookLevel7listBox.Items.Add(level7TextBox.Text);
            level7TextBox.Text = null;
        }

        private void addLevel8_Click(object sender, EventArgs e)
        {
            spellBookLevel8listBox.Items.Add(level8TextBox.Text);
            level8TextBox.Text = null;
        }

        private void addLevel9_Click(object sender, EventArgs e)
        {
            spellBookLevel9listBox.Items.Add(level9TextBox.Text);
            level9TextBox.Text = null;
        }

        private void delLevel0_Click(object sender, EventArgs e)
        {
            spellBookLevel0ListBox.Items.Remove(spellBookLevel0ListBox.SelectedItem);
        }

        private void delLevel1_Click(object sender, EventArgs e)
        {
            spellBookLevel1listBox.Items.Remove(spellBookLevel1listBox.SelectedItem);
        }

        private void delLevel2_Click(object sender, EventArgs e)
        {
            spellBookLevel2listBox.Items.Remove(spellBookLevel2listBox.SelectedItem);
        }

        private void delLevel3_Click(object sender, EventArgs e)
        {
            spellBookLevel3ListBox.Items.Remove(spellBookLevel3ListBox.SelectedItem);
        }

        private void delLevel4_Click(object sender, EventArgs e)
        {
            spellBookLevel4listBox.Items.Remove(spellBookLevel4listBox.SelectedItem);
        }

        private void delLevel5_Click(object sender, EventArgs e)
        {
            spellBookLevel5listBox.Items.Remove(spellBookLevel5listBox.SelectedItem);
        }

        private void delLevel6_Click(object sender, EventArgs e)
        {
            spellBookLevel6listBox.Items.Remove(spellBookLevel6listBox.SelectedItem);
        }

        private void delLevel7_Click(object sender, EventArgs e)
        {
            spellBookLevel7listBox.Items.Remove(spellBookLevel7listBox.SelectedItem);
        }

        private void delLevel8_Click(object sender, EventArgs e)
        {
            spellBookLevel8listBox.Items.Remove(spellBookLevel8listBox.SelectedItem);
        }

        private void delLevel9_Click(object sender, EventArgs e)
        {
            spellBookLevel9listBox.Items.Remove(spellBookLevel9listBox.SelectedItem);
        }


        private void woundsTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculateHp();
        }
    }
}
