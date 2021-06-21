using System;

namespace Chain_Of_Responsability
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos la cadena
            Propietario elPropietario = new Propietario();
            JefePiso elJefe = new JefePiso(elPropietario);
            Vendedor elVendedor = new Vendedor(elJefe);

            int cantidad = 150;
            double precio = 10000;
            double total = 0;

            total = elVendedor.CalculaPrecioFinal(cantidad, precio);
            Console.WriteLine("total {0}, con descuento {1}", cantidad*precio, total);
            
        }
    }
}
