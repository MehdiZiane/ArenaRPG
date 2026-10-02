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
            int degats = (Force + (ArmeEquipee?.Degat ?? 0))*2;
            cible.PointsDeVie -= degats;
        }

        public override string DecrireCompetence()
        {
            return $"{Nom} dechaine une rage devastatrice";
        }
    }
}
