using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    class SaborChocolate : IProductoSaborizante
    {
        public string informacion()
        {
            return "Sabor a chocolate";
        }

        public void obtener()
        {
            Console.WriteLine("Se produce C7H8N402");
        }
    }
}
