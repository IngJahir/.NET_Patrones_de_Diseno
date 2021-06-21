using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Program
    {
        static void Main(string[] args) 
        {
            Director miDirector = new Director();

            // **************
            // AUTO ECONOMICO
            // **************

            // Construir 
            BuilderNormal normal = new BuilderNormal();
            miDirector.Construye(normal);

            // Obtener
            Producto auto1 = normal.ObtenProducto();
            auto1.MostrarAuto();

            Console.WriteLine("------");

            // **************
            // AUTO DEPORTIVO
            // **************

            // Construir
            BuilderDeportivo deportivo = new BuilderDeportivo();
            miDirector.Construye(deportivo);

            // Obtener
            Producto auto2 = deportivo.ObtenProducto();
            auto2.MostrarAuto();
        }
    }
}
