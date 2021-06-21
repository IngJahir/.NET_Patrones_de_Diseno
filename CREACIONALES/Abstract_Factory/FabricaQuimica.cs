using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    class FabricaQuimica : IFabrica
    {
        private IProductoLeche leche;
        private IProductoSaborizante sabor;

        public IProductoLeche ObtenProductoLeche { get { return leche; } }
        public IProductoSaborizante ObtenSabor { get { return sabor; } }

        public void CrearProductos()
        {
            Console.WriteLine("Estamos produciendo tu malteada");
            leche = new LecheVaca();
            sabor = new SaborChocolate();
        }
    }
}
