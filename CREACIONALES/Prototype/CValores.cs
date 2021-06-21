using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    class CValores:IPrototipo
    {
        private double sumatoria;
        private int m = 1;

        public int M { get => m; set => m = value; }
        public double Sumatoria { get => Sumatoria; set => Sumatoria = value; }

        // --------------
        // Constructores
        // --------------
        public CValores()
        {
        }

        public CValores(int pM)
        {
            m = pM;
            for (int n = 0; n < 90; n++)
            {
                sumatoria += Math.Sin(n * 0.0175);
            }
        }

        // --------------
        // Otros metodos
        // --------------

        public override string ToString()
        {
            return string.Format("{0}", sumatoria * m);
        }

        public object Clonar() 
        {
            CValores clon = new CValores();
            clon.M = m;
            clon.sumatoria = sumatoria;

            return clon;
        }
    }
}
