using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_Of_Responsability
{
    interface IHandler
    {
        double CalculaPrecioFinal(int pCantidad, double pPrecio);
    }
}
