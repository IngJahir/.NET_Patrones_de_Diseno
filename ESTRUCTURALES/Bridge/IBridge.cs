using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    // Esta es la i`mplementacion que las implementaciones debe mostrar
    interface IBridge
    {
        void MostrarTotales(Dictionary<string, double> pProductos);
        void ListarProductos(Dictionary<string, double> pProductos);
    }
}
