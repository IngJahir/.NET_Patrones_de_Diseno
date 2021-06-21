using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    class ColegaA : IColega
    {
        private Mediador mediador;
        private string nombre;

        public ColegaA(string pNombre, Mediador pMediator)
        {
            nombre = pNombre;

            // Tenemos la referencia al mediador 
            mediador = pMediator;

            // Nos suscribimos
            mediador.Suscribir(Recibir);              
        }

        public void Recibir(string emisor, string mensaje)
        {
            // Lleva a cabo la recepcion segun su estilo
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Soy {0}, recibi de {1}: {2}", nombre, emisor, mensaje);
        }

        public void Enviar(string mensaje)
        {
            // Aqui colocamos la logica para el envio del mesaje 
            // No necesariamente debe ser un parametro
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Soy {0}, envio: {1}", nombre, mensaje);
            mediador.Enviar(nombre, mensaje);
        }

        
    }
}
