using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    // Esta clase es el adaptador, usa la interfaz ITarget, la cual es conocida por el cliente
    // El adaptador ciomunica al cliente con la clase adaptada

    class CAdaptador : ITarget
    {
        CCalculadoraArray adaptado = new CCalculadoraArray();

        // Aqui hacemos la adaptacion de una operacion
        public int Sumar(int pA, int pB)
        {
            double r = 0;

            // Adaptacion de una operacion 
            int[] operadores = { pA, pB };

            // Realizamos la operacion en el adaptado
            r = adaptado.suma(operadores);

            // Adaptamos el resultado
            return (int)r;


        }
    }
}
