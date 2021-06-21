using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    class LecheVaca : IProductoLeche
    {
        public string obtenDatos()
        {
            return "Leche de vaca, 250 ml";
        }

        public void producir()
        {
            Console.WriteLine("Ordeñar la vaca en la granja");
        }
    }
}
