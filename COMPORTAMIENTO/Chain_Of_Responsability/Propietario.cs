﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_Of_Responsability
{
    class Propietario : IHandler
    {
        public double CalculaPrecioFinal(int pCantidad, double pPrecio)
        {
            Console.WriteLine("Con el propieterio");
            double total = 0;

            // Damos el 15% de descuento
            total = pCantidad * pPrecio * 0.85;

            return total;
        }
    }
}
