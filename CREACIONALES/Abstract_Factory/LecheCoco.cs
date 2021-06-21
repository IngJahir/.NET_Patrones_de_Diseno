using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    class LecheCoco : IProductoLeche
    {
        public string obtenDatos()
        {
            return "Leche de coco natural, 250 ml";
        }

        public void producir()
        {
            Console.WriteLine("Buscamos los cocos");
        }
    }
}
