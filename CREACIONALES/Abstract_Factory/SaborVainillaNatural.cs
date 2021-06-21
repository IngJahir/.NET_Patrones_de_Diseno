using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    class SaborVainillaNatural : IProductoSaborizante
    {
        public string informacion()
        {
            return "Extracto natural de vainilla";
        }

        public void obtener()
        {
            Console.WriteLine("Se extrae de las vainillas");
        }
    }
}
