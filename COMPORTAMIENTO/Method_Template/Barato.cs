using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Template
{
    class Barato : IPrimitiva
    {
        public double Decorar(int cantidad)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            
            for (int n = 0; n < cantidad; n++)
            {
                Console.WriteLine("Pegar etiqueta");
            }

            return 1.5 * cantidad;
        }

        public double Empacar(int cantidad)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int n = 0; n < cantidad; n++)
            {
                Console.WriteLine("Meter en bolsa");
            }

            return 0.25 * cantidad;            
        }
    }
}
