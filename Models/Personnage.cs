using System.Security.Cryptography.X509Certificates;

namespace ArenaRPG.Models
{
    internal class Personnage
    {
        public Personnage(string nom, int pointsDeVie, int force, int mana) 
        {
            Nom = nom;
            PointsDeVie = pointsDeVie;
            Niveau = 1;
            Force = force;
            Mana = mana;
        }
        public Personnage(string nom) : this(nom, 100, 1, 1) { }
        public Personnage() : this(""){ }
        
        private string _nom = string.Empty;
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

        private int _pointsdevie;
        public int PointsDeVie
        {
            get { return _pointsdevie; }
            set
            {
                if (value < 0)
                {
                    _pointsdevie = 0;
                }
                else
                {
                    _pointsdevie = value;
                }
            }
        }
        public int Niveau { get; private set; }

        private int _force;
        public int Force
        {
            get { return _force; }
            set
            {
                if (value < 0)
                {
                    _force = 0;
                }
                else
                {
                    _force = value;
                }
            }
        }

        private int _mana;
        public int Mana
        {
            get { return _mana; }
            set { _mana = value < 0 ? 0 : value; }
        }

        public bool EstVivant
        {
            get { return PointsDeVie > 0; }
        }

        public void MonterDeNiveau()
        {
            Niveau += 1;
        }

        public static bool operator ==(Personnage p1, Personnage p2)
        {
            return p1.Niveau == p2.Niveau;
        }
        public static bool operator !=(Personnage p1, Personnage p2)
        {
            return !(p1 == p2);
        }

        public static bool operator <(Personnage p1, Personnage p2) 
        {
            return p1.Niveau < p2.Niveau;
        }
        public static bool operator >(Personnage p1, Personnage p2)
        {
            return p1.Niveau > p2.Niveau;
        }

        public override bool Equals(object? obj)
        {
            return obj is Personnage personnage &&
                   Niveau == personnage.Niveau;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Niveau);
        }
    }
}
