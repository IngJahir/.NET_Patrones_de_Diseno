using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class CSuspension : IComponente
    {
        // ******************
        // Atributos privados
        // ******************
        private IComponente decoramosA;

        // ******************
        // Atributos publicos
        // ******************

        // ***********
        // Constructor
        // ***********
        public CSuspension(IComponente pComponente)
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
            return "Suspension de alto desempeño \r\n" + decoramosA.ToString();
        }

        // ********
        // Interfaz
        // ********
        public double Costo()
        {
            // Calculamos el costo 
            // El costo de lo que decoro mas mi costo como componente
            return decoramosA.Costo() + 63850;
        }

        public string Funciona()
        {
            return decoramosA.Funciona() + ", Elevando suspension";
        }
    }
}
