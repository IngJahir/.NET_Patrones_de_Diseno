using System;
using System.Collections.Generic;
using System.Text;

// Es este caso hay un namesapce propio en donde aparecen los subsistemas
// ----------------------------------------------------------------------
namespace Subsistemas
{
    class CSistemaCompra
    {
        // ****************
        // Metodos publicos
        // ****************

        // Este metodo representa alguna operacion que se puede llevar a cabo el 
        // subsitema, puede haber muchas mas y la de mayor complejidad
        public bool Comprar() 
        {
            string dato = "";
            Console.ForegroundColor= ConsoleColor.White;
            Console.WriteLine("Introducir numero de tarjeta");
            dato = Console.ReadLine();

            if (dato == "12345")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Pago aceptado");
                return true;
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Pago rechazado");
                return false;                
            }         
        }
    }

    class CSubsitemaAlmacen 
    {
        // ******************
        // Atributos privados
        // ******************
        private int cantidad;

        // ***********
        // Constructor
        // ***********
        public CSubsitemaAlmacen()
        {
            cantidad = 3;
        }

        // ****************
        // Metodos publicos
        // ****************
        public bool SacarAlmacen() 
        {
            if (cantidad > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Producto listo para envierse");
                cantidad--;
                return true;
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Producto no disponible, espera a que hay existencias");
                return false;
            }            
        }
    }

    class CSubsistemaEnvio 
    {
        // ****************
        // Metodos publicos
        // ****************
        public void EnviarPedido() 
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("El envio va en camino");
        }        
    }

}
