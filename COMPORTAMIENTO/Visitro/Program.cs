using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    class Program
    {
        static void Main(string[] arg) 
        {
            double totalCosto = 0;
            int totalObjetos = 0;
            int totalClasificaciones = 0;

            // Creamos la estructura de objetos
            Elemento estructuraObjeto =
                new Elemento(89.0, "Botiquin",
                new Elemento(25.60, "Termometro",
                new ElementoL(
                    new Elemento(35.8, "Antibiotico",
                    new Elemento(15.5, "Antiacido",
                        new ElementoL(
                            new Elemento(12.8, "Aspirina", null),
                            new Elemento(56.6, "Anti imflamatorio",
                            null)))),
                    new Elemento(12.8, "Grasa",
                    new Elemento(23.5, "Cinta",
                    new Elemento(112.5, "Tijeras", null))))));

            // Visitamos la estructura de objetos
            Visitante visitante = new Visitante();
            visitante.ContarElementos(estructuraObjeto);

            totalCosto = visitante.Total;
            totalClasificaciones = visitante.Clasificaciones;
            totalObjetos = visitante.Conteo;

            Console.WriteLine("Se tienen {0} objetos con un costo de ${1} en {2}", 
                totalObjetos,totalCosto,totalClasificaciones);
        }
    }
}
