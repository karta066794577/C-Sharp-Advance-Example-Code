using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonLibrary
{
    public class Ivysaur : Bulbasaur
    {
        public override int Hp
        {
            get => base.Hp;
            set
            {
                if (value < 0)
                    base.Hp = 0;
                else if (value > 500)
                    base.Hp = 500;
                else
                    base.Hp = value;
            }
        }
    }
}