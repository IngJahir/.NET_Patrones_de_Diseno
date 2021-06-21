using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    interface IFlyweight
    {
        void ColocaNombre(string pNombre);
        void CalculaCosto();
        void Mostrar();
        string ObtenNombre();
    }
}
