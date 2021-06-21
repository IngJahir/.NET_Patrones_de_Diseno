using System;

namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            IFabrica miFabrica = new FabricaQuimica();

            miFabrica.CrearProductos();

            IProductoLeche miLeche = miFabrica.ObtenProductoLeche;
            IProductoSaborizante miSabor = miFabrica.ObtenSabor;

            miLeche.producir();
            miSabor.obtener();

            Console.WriteLine("Mi malteada es de {0} y {1}",miLeche.obtenDatos(),miSabor.informacion());
            Console.WriteLine("----------");

            miFabrica = new FabricaNaural();

            miFabrica.CrearProductos();

            miLeche = miFabrica.ObtenProductoLeche;
            miSabor = miFabrica.ObtenSabor;
            Console.WriteLine("Mi malteada es de {0} y {1}", miLeche.obtenDatos(), miSabor.informacion());

        }
    }
}
