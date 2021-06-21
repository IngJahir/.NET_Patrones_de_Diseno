using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class CRestar : IOperacion
    {
        public double operacion(double a, double b)
        {
            return a - b;
        }
    }
}
