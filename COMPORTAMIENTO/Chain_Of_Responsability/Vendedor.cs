﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_Of_Responsability
{
    class Vendedor : IHandler
    {
        private IHandler siguiente = null;

        public Vendedor(IHandler pSiguiente)
        {
            siguiente = pSiguiente;
        }
        public double CalculaPrecioFinal(int pCantidad, double pPrecio)
        {
            Console.WriteLine("Con el vendedor");

            // Si son mas de 20 articulos o mas de 20000 en ventas 
            // Pasa el jefe de piso
            double total = pCantidad * pPrecio;

            if (pCantidad > 20 || total > 20000)
                total = siguiente.CalculaPrecioFinal(pCantidad, pPrecio);
            else 
            {
                // Si son mas de 10 damos un 5% de descuento
                if (pCantidad > 10)
                    total *= 0.95;
            }
            return total;
        }
    }
}
