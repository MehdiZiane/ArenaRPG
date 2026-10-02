using System;
using System.Collections.Generic;
using System.Text;

namespace ArenaRPG.Models
{
    internal class Inventaire
    {
        private List<string> _objets = new List<string>();
        private int _capaciteMax;
        public Inventaire(int capaciteMax) 
        {
            _capaciteMax = capaciteMax;
        }

        public bool Ajouter(string objet)
        {
            if(_objets.Count >= _capaciteMax)
            {
                return false;
            }
            _objets.Add(objet);
            return true;
        }

        public void AfficherContenu()
        {
            foreach (string objet in _objets)
            {
                Console.WriteLine($" - {objet}");
            }
        }
    }
}
