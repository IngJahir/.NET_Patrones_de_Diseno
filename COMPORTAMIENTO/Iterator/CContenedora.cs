using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    class CContenedora: IEnumerable
    {
        // Estructra que guarda la informacion.
        // Puede ser una lista ligada, un arbol, un diccionario, etc.
        // ----------------------------------------------------------
        private int[] valores = new int[10];

        public CContenedora()
        {
            for (int n = 0; n < 10; n++)
                valores[n] = n * n;
        }

        public IEnumerator GetEnumerator()
        {
            return (new ContenedorEnum(valores));
        }        
    }

    class ContenedorEnum : IEnumerator 
    {
        public int[] arreglo;
        private int posicion = -1;

        public ContenedorEnum(int[] pArreglo)
        {
            arreglo = pArreglo;
        }

        public bool MoveNext() 
        {
            posicion++;
            if (posicion < arreglo.Length)
                return true;
            else
                return false;
        }

        public void Reset() 
        {
            posicion = -1;            
        }

        public object Current 
        {
            get 
            {
                return arreglo[posicion];
            }
        }        
    }
}
