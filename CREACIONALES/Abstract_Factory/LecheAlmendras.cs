using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    class LecheAlmendras : IProductoLeche
    {
        public string obtenDatos()
        {
            return "Leche organica de Almendra, 250 ml";
        }

        public void producir()
        {
            Console.WriteLine("Procesar las Almendras");
        }
    }
}

