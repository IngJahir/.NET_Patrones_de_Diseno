using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    // Esta es la clase que debemos adaptar, el cliente no la puede usar directamente
    // pues su interfaz es diferente.

    class CCalculadoraArray
    {
        public double suma(int[] pOperandos) 
        {
            int n = 0;
            int r = 0;

            for (n = 0; n < pOperandos.Length; n++)
                r += pOperandos[n];

            return r;            
        }
    }
}
