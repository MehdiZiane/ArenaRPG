using ArenaRPG.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArenaRPG.Models
{
    internal class Archer : Personnage, IEmpoisonnable
    {
        private int _degatsParTour;
        private int _tourRestant;
        public Archer(string nom, int pointsDeVie, int force, int mana) 
            : base(nom, pointsDeVie, force, mana)
        { 
        }

        public override void Attaquer(Personnage cible)
        {
            base.Attaquer(cible);
            Console.WriteLine($"{Nom} utilise son arc");
        }

        public override string DecrireCompetence()
        {
            return $"{Nom} lance une fleche de toute sa force";
        }

        public bool EstEmpoisonne
        {
            get { return _tourRestant > 0; }
        }
        public void Empoisonner(int degatsParTour, int nombreDeTour)
        {
            _degatsParTour = degatsParTour;
            _tourRestant = nombreDeTour;
        }
        public void AppliquerPoison()
        {
            if (EstEmpoisonne)
            {
                PointsDeVie -= _degatsParTour;
                _tourRestant--;
            }
        }
    }
}
