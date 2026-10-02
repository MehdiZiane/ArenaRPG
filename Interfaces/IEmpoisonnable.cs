using System;
using System.Collections.Generic;
using System.Text;

namespace ArenaRPG.Interfaces
{
    public interface IEmpoisonnable
    {
        void Empoisonner(int degatsParTour, int nombreDeTour);
        bool EstEmpoisonne {  get; }
    }
}
