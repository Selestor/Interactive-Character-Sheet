using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterSheet
{
    public partial class FormInfo : Form
    {
        public FormInfo()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
        }

        public void ChangeInsides(string name, string info)
        {
            infoLabel.Text = name;
            InfoTextBox.Text = info;
        }

        private void Close(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape) Close();
        }
    }
}
