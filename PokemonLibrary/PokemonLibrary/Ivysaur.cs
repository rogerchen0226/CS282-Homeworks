using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonLibrary
{
    public class Ivysaur : Bulbasaur
    {
        public Ivysaur()
        {
            Name = "妙蛙草";
        }

        public override void Attack(Pokemon other)
        {
            other.CurrentHp -= 20;
        }
    }
}