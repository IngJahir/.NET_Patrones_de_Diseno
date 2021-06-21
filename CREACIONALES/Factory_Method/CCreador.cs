using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method
{
    class CCreador
    {
        public static IVehiculo MetodoFabrica(int pDinero) 
        {
            IVehiculo temp = null;

            // Seleccionamos el auto segun las reglas
            if (pDinero > 10000000)
                temp = new CAvion();
            else if (pDinero > 200000)
                temp = new CAuto();
            else
                temp = new CBici();
            return temp;
        }
    }
}
