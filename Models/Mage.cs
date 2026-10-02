using System;
using System.Collections.Generic;
using System.Text;

namespace ArenaRPG.Models
{
    internal class Mage : Personnage
    {
        public Mage(string nom, int pointsDeVie, int force, int mana) 
            : base(nom, pointsDeVie, force, mana)
        {
            TypeMagie = "feu";
        }

        public string TypeMagie { get; set; }

        public override void Attaquer(Personnage cible)
        {
            if (Mana >= 10)
            {
                cible.PointsDeVie -= Force + Mana;
            }
            else
            {
                cible.PointsDeVie -= Force;
            }

        }
        public override string DecrireCompetence()
        {
            return $"{Nom} déclanche une boule de feu destructrice";
        }

    }
}
