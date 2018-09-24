using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonLibrary
{
    public abstract class Character
    {
        public string Name { get; set; }

        protected int hp;

        public virtual int Hp
        {
            get => hp;
            set => hp = value > 0 ? 0 : value;
        }

        protected int height;
        protected int weight;

        protected IAttackBehavior attackBehavior;

        public void Attack(Character character)
        {
            if (attackBehavior == null)
                attackBehavior = new NonAttackBehavior();
            attackBehavior.Attack(character);
        }
    }
}