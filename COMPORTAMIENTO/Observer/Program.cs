using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos el sujeto
            Sujeto miSujeto = new Sujeto();

            // Creamos a los observadores
            Observador a = new Observador("A", miSujeto);
            Observador b = new Observador("B", miSujeto);
            Observador c = new Observador("C", miSujeto);

            // Trabajamos
            for (int n = 0; n < 5; n++)
                miSujeto.Trabajo();

            // Alguein se sale de la lista
            Console.WriteLine("--- Desvincular ---");
            miSujeto.Desvincular(b);

            // Trabajamos
            for (int n = 0; n < 5; n++)
                miSujeto.Trabajo();
        }
    }
}
