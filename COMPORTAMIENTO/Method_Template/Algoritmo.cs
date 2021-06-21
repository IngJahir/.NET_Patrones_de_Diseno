using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Template
{
    class Algoritmo
    {
        public double metodoTemplate(IPrimitiva tipo, int cantidad) 
        {
            double total = 0;

            // Crear juguete
            total += crearJuguete(cantidad);

            // Lo decoramos
            total += tipo.Decorar(cantidad);

            // Verificamos calidad
            calidad();

            // Empacamos
            total += tipo.Empacar(cantidad);

            return total;
        }

        // Metodos adicionales
        private void calidad()
        {
            Console.WriteLine("Pasa el control de calidad");
        }

        private double crearJuguete(int pCantidad)
        {
            Console.WriteLine("Estamos creando {0} juguetes", pCantidad);
            return 16.50 * pCantidad;
        }
    }
}
