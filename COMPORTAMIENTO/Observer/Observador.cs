using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class Observador : IObservador
    {
        private string nombre;
        private Sujeto sujeto;

        public Observador(string pNombre, Sujeto pSujeto)
        {
            nombre = pNombre;
            sujeto = pSujeto;
            sujeto.Vincular(this);
        }

        // Este metodo es usado por el sujeto en el push
        public void Update(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Push, {0}-{1}",nombre, mensaje);
        }

        // Aquie es el acceso al pull
        public void UpdatePull()
        {
            // Obtenemos del sujeto
            // puede ir mas logica para decidir cuando hacerlo
            int n = sujeto.N;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Pull, {0}-{1}", nombre,n);
        }
    }
}
