using System;
using System.Collections.Generic;
using System.Text;

namespace ArenaRPG.Models
{
    internal class Arme
    {
        public Arme(string nom, int degat)
        {
            Nom = nom;
            Degat = degat;
        }

        private string _nom =  string.Empty;
        public string Nom 
        {
            get { return _nom; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    _nom = "inconnue";
                }
                else
                {
                    _nom = value;
                }
            }
        }
        private int _degat;
        public int Degat
        {
            get { return _degat; }
            set
            {
                if (value < 0)
                {
                    _degat = 0;
                }
                else
                {
                    _degat = value;
                }
            }
        }
    }
}
