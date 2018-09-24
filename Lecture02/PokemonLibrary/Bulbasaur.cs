using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonLibrary
{
    public class Bulbasaur : Pokemon
    {

        public override int Hp
        {
            get => base.Hp;
            set
            {
                if (value < 0)
                    base.Hp = 0;
                else if (value > 300)
                    base.Hp = 300;
                else
                    base.Hp = value;
            }
        }
    }
}