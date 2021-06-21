using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    class FabricaNaural : IFabrica
    {
        private IProductoLeche leche;
        private IProductoSaborizante sabor;

        public IProductoLeche ObtenProductoLeche { get { return leche; } }
        public IProductoSaborizante ObtenSabor { get { return sabor; } }

        public void CrearProductos()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string selection;
            Console.WriteLine("Estamos creando tu bebida");
            Console.WriteLine("1) Almendras, 2) Coco");
            selection = Console.ReadLine();

            if (selection == "1")
                leche = new LecheAlmendras();
            else
                leche = new LecheCoco();

            leche.producir();
            Console.WriteLine("Ahora extraemos el sabor");
            sabor = new SaborVainillaNatural();
            sabor.obtener();
        }
    }
}
