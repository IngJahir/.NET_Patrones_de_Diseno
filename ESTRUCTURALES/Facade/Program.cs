using System;

// Es este caso hay que usar Subsistemas, que es el namespace de CSistemasCompra y CFachada
// ----------------------------------------------------------------------------------------
using Subsistemas;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CFachada fachada = new CFachada();

            // Hacemos uso de los subsitemas a travez de la interfaz sencilla de la fachada

            fachada.Compra();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------");

            fachada.Compra();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------");

            fachada.Compra();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------");

            fachada.Compra();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------");
        }
    }
}
