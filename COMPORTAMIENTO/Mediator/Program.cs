using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos el mediador
            Mediador miMediador = new Mediador();

            // Creamos los colegas
            ColegaA Ana = new ColegaA("Ana", miMediador);
            ColegaA Luis = new ColegaA("Luis", miMediador);

            ColegaB David = new ColegaB("David", miMediador);

            Ana.Enviar("Saludos a todos");
            Luis.Enviar("Como estan?");
            David.Enviar("Visiten nicosiored");
            Console.WriteLine();

            Console.WriteLine(" **** Verificamos la censura **** ");
            Luis.Enviar("Los palabrota no me agradan");
            Console.WriteLine();

            miMediador.Bloqueo(Luis.Recibir);
            Ana.Enviar("Vean los playlist");
            Console.WriteLine();

            miMediador.Suscribir(Luis.Recibir);
            David.Enviar("Me gusta programar");
            Console.WriteLine();
        }
    }
}
