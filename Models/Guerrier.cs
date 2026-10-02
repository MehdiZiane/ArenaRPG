using System;
using System.Collections.Generic;
using System.Text;

namespace ArenaRPG.Models
{
    internal class Guerrier : Personnage
    {
        public Guerrier (string nom, int pointsDeVie, int force, int mana)
            : base(nom, pointsDeVie, force, mana)
        {

        }

        public override void Attaquer(Personnage cible)
        {
            cible.PointsDeVie -= Force * 2;
        }

        public override string DecrireCompetence()
        {
            return $"{Nom} dechaine une rage devastatrice";
        }
    }
}
