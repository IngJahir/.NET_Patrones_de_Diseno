using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Template
{
    class Normal : IPrimitiva
    {
        public double Decorar(int cantidad)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hacer {0} veces", cantidad);
            Console.WriteLine("Pintar logotipo");
            Console.WriteLine("POner brillos");
            Console.WriteLine("Adicionar cromos");

            return 7.50 * cantidad;
        }

        public double Empacar(int cantidad)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hacer {0} veces", cantidad);
            Console.WriteLine("Preparar caja");
            Console.WriteLine("Poner indtructivo");
            Console.WriteLine("Poner garantia");
            Console.WriteLine("Meter en caja con empaque");
            Console.WriteLine("Sellar caja");

            return 12.50 * cantidad;
        }
    }
}
