using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class CNitrogeno : IComponente
    {
        // *******************
        // Atributos privados
        // *******************

        // Variable de referencia hacia quien decoramos
        private IComponente decoramosA;

        // ******************
        // Atributos publicos
        // ******************

        // ***********
        // Constructor
        // ***********

        // Pasamos al objeto que va a ser decorado 
        public CNitrogeno(IComponente pComponente)
        {
            decoramosA = pComponente;
        }

        // ****************
        // Metodos privados
        // ****************

        // ****************
        // Metodos publicos
        // ****************
        public override string ToString()
        {
            return "Sistema de Nitrogeno \r\n" + decoramosA.ToString();
        }

        public void UsaN()
        {
            Console.WriteLine("Nitrogeno en uso");
        }

        // *********
        // Interfaz
        // *********
        public double Costo()
        {
            // Calculos el costo
            // El costo de lo que decoro mas mi costo de componente
            return decoramosA.Costo() + 45000;
        }

        public string Funciona()
        {
            return decoramosA.Funciona() + ", Nitrogeno listo";
        }
    }
}
