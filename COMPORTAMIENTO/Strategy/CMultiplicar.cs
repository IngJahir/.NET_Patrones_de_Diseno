using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class CMultiplicar : IOperacion
    {
        public double operacion(double a, double b)
        {
            return a * b;
        }
    }
}
