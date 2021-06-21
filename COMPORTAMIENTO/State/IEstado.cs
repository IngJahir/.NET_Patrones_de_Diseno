using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    interface IEstado
    {
        void Trabajar();
        void CortarFuego();
        void PonerCombustible();
        void ForzarFuego();
    }
}
