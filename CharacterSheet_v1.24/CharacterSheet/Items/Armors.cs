using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet.Items
{
    public class Armors
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int BaseAc { get; set; }
        public int MaxDex { get; set; }
        public bool IsDisposable { get; set; }
    }
}
