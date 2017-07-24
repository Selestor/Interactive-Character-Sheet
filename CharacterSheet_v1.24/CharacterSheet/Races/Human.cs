using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet
{
    class Human : Race
    {
        private decimal _wisdom;
        private decimal _strength;
        private decimal _dextirity;
        private decimal _constitution;
        private decimal _charisma;
        private decimal _intelligence;

        public override decimal Strength
        {
            get { return _strength + 1; }
            set { _strength = value; }
        }
        public override decimal Dextirity
        {
            get { return _dextirity + 1; }
            set { _dextirity = value; }
        }
        public override decimal Constitution
        {
            get { return _constitution + 1; }
            set { _constitution = value; }
        }
        public override decimal Intelligence
        {
            get { return _intelligence + 1; }
            set { _intelligence = value; }
        }
        public override decimal Wisdom
        {
            get { return _wisdom + 1; }
            set { _wisdom = value; }
        }
        public override decimal Charisma
        {
            get { return _charisma + 1; }
            set { _charisma = value; }
        }

        public Human()
        {
            AdultSize = 0;
        }
    }
}
