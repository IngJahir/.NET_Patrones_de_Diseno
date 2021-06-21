using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    abstract class Expresion
    {
        public void Interpretar(Contexto pContexto) 
        {
            // Si ya no hay elementos que interpretar salimos
            if (pContexto.Expresion.Length == 0)
                return;

            // Verificamos si empieza con nueve
            // ---------------------------------
            if (pContexto.Expresion.StartsWith(Nueve()))
            {
                // Agregamos el nuevo por la pocision donde este 1,10,100
                pContexto.Valor += (9 * Factor());

                // Eliminamos dos caractares IX, XC, CM
                pContexto.Expresion = pContexto.Expresion.Substring(2);
            }

            // Verificamos si empieza con cuatro
            // ----------------------------------
            else if (pContexto.Expresion.StartsWith(Cuatro()))
            {
                pContexto.Valor += (4 * Factor());

                // Eliminamos dos caracteres
                pContexto.Expresion = pContexto.Expresion.Substring(2);
            }

            // Verificamos si empieza con cinco
            // --------------------------------
            else if (pContexto.Expresion.StartsWith(Cinco())) 
            {
                pContexto.Valor += (5 * Factor());
                pContexto.Expresion = pContexto.Expresion.Substring(1);
            }

            // Recorremos las unidades encontradas I, X, C
            while (pContexto.Expresion.StartsWith(Unidad()))
            {
                pContexto.Valor += (1*Factor());
                pContexto.Expresion = pContexto.Expresion.Substring(1);
            }
        }   

        // Metodos abstractos para encontrar el caracter y el factor
        // segun la posicion

        public abstract string Unidad();
        public abstract string Cuatro();
        public abstract string Cinco();
        public abstract string Nueve();
        public abstract int Factor();
    }
}
