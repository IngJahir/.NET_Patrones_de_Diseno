using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos el componente central con tipo IComponente
            // para permitir la decoracion
            IComponente miAuto = new CAuto("2018", "4 puetras", 200000);

            Console.WriteLine(miAuto);

            // Si necesitamos usar un metodo propio de CAuto
            //necesitamos hacer uso de un type cast
            ((CAuto)miAuto).Puertas(true);
            Console.WriteLine("-----------");

            // Decoramos el auto con un sistema de sonido
            // ------------------------------------------
            miAuto = new CSistemaSonido(miAuto);

            Console.WriteLine("AUTO CON SISTEMA DE SONIDO");
            Console.WriteLine(miAuto.Costo());
            Console.WriteLine(miAuto.Funciona());
            Console.WriteLine(miAuto);
            Console.WriteLine("----------------");
            
            // Decoramos el auto con un sistema de Nitrogeno
            // ----------------------------------------------
            miAuto = new CNitrogeno(miAuto);

            Console.WriteLine("AUTO CON SISTEMA DE NITROGENO");
            Console.WriteLine(miAuto.Costo());
            Console.WriteLine(miAuto.Funciona());
            Console.WriteLine(miAuto);
            Console.WriteLine("----------------");

            // Para usar algo propio del Nitrogeno necesitamos un type cats !!!!
            ((CNitrogeno)miAuto).UsaN();

            // Decoramos el auto con un sistema de sonido
            // ------------------------------------------
            miAuto = new CSuspension(miAuto);

            Console.WriteLine("AUTO CON SUSPENSION DE ALTO DESEMPEÑO");
            Console.WriteLine(miAuto.Costo());
            Console.WriteLine(miAuto.Funciona());
            Console.WriteLine(miAuto);
            Console.WriteLine("----------------");

            // OJO: No podemos usar metodos especificos una vez que decoramos

            // ((CNitrogeno)miAuto).UsaN();
            //((CAuto)miAuto).Puertas(false);
        }
    }
}
