using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class CAuto : IComponente
    {
        // ******************
        // Atributos privados
        // ******************
        private string modelo;
        private string caracteristicas;

        // ******************
        // Atributos publicos
        // ******************
        public double costo;

        // ***********
        // Constructor
        // ***********
        public CAuto(string pModelo, string pCaract, double pCosto)
        {
            modelo = pModelo;
            caracteristicas = pCaract;
            costo = pCosto;
        }

        // ****************
        // Metodos privados
        // ****************


        // ****************
        // Metodos publicos
        // ****************

        public void Puertas(bool pEstado)
        {
            if (pEstado)
                Console.WriteLine("Puertas cerradas");
            else
                Console.WriteLine("Puertas abiertas");
        }

        public override string ToString()
        {
            return string.Format("Modelo {0}, {1} \r\n", modelo, caracteristicas);
        }

        // ********
        // Interfaz
        // ********
        public double Costo()
        {
            return costo;
        }

        public string Funciona()
        {
            return "Encendi el motor";
        }
    }
}
