using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    class Visitante : IVisitante
    {
        private int conteo;
        private int clasificaciones;
        private double total;

        public int Conteo { get => conteo; set => conteo = value; }
        public int Clasificaciones { get => clasificaciones; set => clasificaciones = value; }
        public double Total { get => total; set => total = value; }

        public void ContarElementos(Elemento pElemento) 
        {
            // Nos mandamos como visitante al elemento
            pElemento.Aceptar(this);

            // Vemos si tenemos hijo
            if (pElemento.hijo != null)
                ContarElementos(pElemento.hijo);

            // Vemos si tenemos siguiente
            if (pElemento.siguiente != null)
                ContarElementos(pElemento.siguiente);
            
        }

        public void Visitar(Elemento pElemento)
        {
            conteo++;
            total += pElemento.Costo;
        }

        public void Visitar(ElementoL pElemento)
        {
            Clasificaciones++;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("No conteo");
        }
    }
}
