using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class CSistemaSonido : IComponente
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
        public CSistemaSonido(IComponente pComponente)
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
            return "Radio 350XZ+ \r\n" + decoramosA.ToString();
        }

        // ********
        // Interfaz
        // ********
        public double Costo()
        {
            // Calculamos el costo
            // El costo de lo que decoro mas mi costo como componete
            return decoramosA.Costo() + 3500;
        }

        public string Funciona()
        {
            return decoramosA.Funciona() + ", Enciendo el radio";
        }
    }
}
