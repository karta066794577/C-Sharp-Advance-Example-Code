using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonLibrary
{
    public abstract class Pokemon : Character
    {
        private int nationalNo;

        protected int NationalNo
        {
            get => nationalNo;
            set => nationalNo = value >= 1 ? value : 1;
        }

        public override int Hp
        {
            get { return hp; }
            set
            {
                if (value < 0)
                    base.Hp = 0;
                else if (value > 2000)
                    base.Hp = 2000;
                else
                    base.Hp = value;
            }
        }

        public abstract void Attack(Pokemon other);
    }
}