using System;
using System.Collections.Generic;
using System.Text;

namespace ArenaRPG.Utils
{
    internal static class Des
    {
        public static int Lancer(int faces)
        {
            int nbrdes= Random.Shared.Next(1, faces +1);

            return nbrdes;
        }
    }
}
