using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    class ColegaB : IColega
    {
        private Mediador mediador;
        private string nombre;
        private int conteo;

        public ColegaB(string pNombre, Mediador pMediator)
        {
            nombre = pNombre;

            // Tenemos la referencia al mediador 
            mediador = pMediator;

            // Nos suscribimos
            mediador.Suscribir(Recibir);
        }

        public void Recibir(string emisor, string mensaje)
        {
            conteo++;
            // Lleva a cabo la recepcion segun su estilo
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("->[{0},{1}]({2}): {3}", nombre,emisor,conteo,mensaje);          
        }

        public void Enviar(string mensaje)
        {
            // Aqui colocamos la logica para el envio de mensaje
            // No necesariamente debe ser un parametro
            Console.WriteLine("->[{0}]:{1}", nombre, mensaje);
            mediador.Enviar(nombre, mensaje);
        }

        
    }
}
