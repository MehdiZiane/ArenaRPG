using System;
using System.Collections.Generic;
using System.Text;

namespace ArenaRPG.Models
{
    internal class Mannequin: Personnage
    {
        public Mannequin(string nom, int pointsDeVie, int force, int mana)
            : base(nom, pointsDeVie, force, mana)
        {
        }

        public Mannequin(string nom) : base(nom) 
        { 
        }

        public Mannequin() : base ()
        { 
        }

        public override string DecrireCompetence()
        {
            return $"{Nom} il est bien la";
        }
    }
}
