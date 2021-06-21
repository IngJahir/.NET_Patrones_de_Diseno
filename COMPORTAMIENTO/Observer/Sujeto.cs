using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    // Si vamos a tener varios sujetos se puede crear una interfaz ISujeto
    class Sujeto
    {
        private List<IObservador> observadores = new List<IObservador>();
        private string mensaje;
        private Random rnd = new Random();
        private int n;

        public int N { get => n; set => n = value; }

        public void Vincular(IObservador suscrito) 
        {
            // Lo adicionamos a la lista
            observadores.Add(suscrito);
        }

        public void Desvincular(IObservador suscrito)
        {
            // Recomendable colocar codigo de seguridad
            observadores.Remove(suscrito);
        }

        public void Notificar()
        {
            // Notificamos el nuevo estado a todos los observadores
            foreach (IObservador o in observadores)
            {
                //o.Update(mensaje);
                o.UpdatePull();
            }            
        }

        // Aqui simulamos el trabajo del observador y un cambio de estado 
        // que necesita ser modificado
        public void Trabajo() 
        {
            n = rnd.Next(10);
            if (n % 2 == 0) 
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("--- Nuevo estado valido ---");
                mensaje = string.Format("El nuevo valor es {0}",n);
                Notificar();
            }
        }




    }
}
