using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    // Esta implementacion es por medio de delegados
    class Mediador
    {
        //Creamos un delegado que usaremos para invocar los metodos
        // Los delegados sireven para asignar a una variable una funcion
        public delegate void DEnvio(string emisor, string mensaje);
        DEnvio enviarMensaje;

        // Adicionamos el metodo a invocar
        public void Suscribir(DEnvio metodo) 
        {
            enviarMensaje += metodo;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("---Sustcrito---");
        }

        public void Enviar(string emisor, string mensaje) 
        {
            // Usamos el mediador para censurar (Mediador)
            if (mensaje.Contains("palabrota"))
                mensaje = mensaje.Replace("palabrota","******");

            // Enviamos los mensajes correspondientes via delegado
            enviarMensaje(emisor, mensaje);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--- Mensajes enviados ---");
        }

        //Quitamos el metodo del delegado, ya no sera invocado
        public void Bloqueo(DEnvio metodo) 
        {
            enviarMensaje -= metodo;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--- Bloqueo ---");            
        }

    }
}
