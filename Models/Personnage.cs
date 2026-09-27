namespace ArenaRPG.Models
{
    internal class Personnage
    {
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
                if(value < 0)
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
            set { _mana = value < 0 ?  0 : value; }
        }

        public bool EstVivant
        {
            get { return PointsDeVie > 0; }
        }
    }
}
