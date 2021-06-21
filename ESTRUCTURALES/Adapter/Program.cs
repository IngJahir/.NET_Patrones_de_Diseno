using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Este es el cliente
            int resultado = 0;

            // Usamos la interfaz que el cliente conoce con una clase que conoce
            ITarget calcu = new CCalcu();

            resultado = calcu.Sumar(4, 3);
            Console.WriteLine("El resultado es: {0}", resultado);
            Console.WriteLine("-----");

            // Hacemnos uso del adaptador
            calcu = new CAdaptador();

            // Usamos el adaptador para la operacion 
            resultado = calcu.Sumar(5, 6);

            Console.WriteLine("El resultado es: {0}", resultado);
        }
    }
}
