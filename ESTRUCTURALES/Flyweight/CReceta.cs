using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    class CReceta : IFlyweight
    {
        // ******************
        // Atributos privados
        // ******************
        private string nombre;
        private double costo;
        private double venta;

        // ********
        // Interfaz
        // ********
        public void CalculaCosto()
        {
            foreach (char letra in nombre)
            {
                costo += (int)letra;
            }
            venta = costo * 1.30;
        }

        public void ColocaNombre(string pNombre)
        {
            nombre = pNombre;
        }

        public void Mostrar()
        {
            Console.WriteLine("{0} cuesta {1}", nombre, venta);
        }

        public string ObtenNombre()
        {
            return nombre;
        }
    }
}
