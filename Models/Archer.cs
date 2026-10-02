using System;
using System.Collections.Generic;
using System.Text;

namespace ArenaRPG.Models
{
    internal class Archer : Personnage
    {
        public Archer(string nom, int pointsDeVie, int force, int mana) 
            : base(nom, pointsDeVie, force, mana)
        { 
        }
    }
}
