using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class CCalcu : ITarget
    {
        public int Sumar(int pA, int pB)
        {
            return pA + pB;
        }
    }
}
