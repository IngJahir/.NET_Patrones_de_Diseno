using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    interface IFabrica
    {
        void CrearProductos();
        IProductoLeche ObtenProductoLeche { get; }
        IProductoSaborizante ObtenSabor { get; }
    }
}
