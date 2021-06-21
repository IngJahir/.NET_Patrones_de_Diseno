using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args) 
        {
            double totalCosto = 0;
            int totalObjetos = 0;
            int totalClasificaciones = 0;

            // Creamos la estructura de objetos
            Elemento estructuraObjeto = 
                new Elemento(89.0,"Botiquin",
                new Elemento(25.60,"Termometro",
                new ElementoL(
                    new Elemento(35.8, "Antibiotico",
                    new Elemento(15.5, "Antiacido",
                        new ElemntoL(
                            new Elemento(12.8, "Aspirina",null),
                            new Elemento(56.6, "Anti inflamatorio",
                            null ))))

        }
    }
}

https://www.youtube.com/watch?v=1gsKQENrMg0&list=PLM-p96nOrGcbqbL_A29b0z3KUXdq2_fpn&index=42