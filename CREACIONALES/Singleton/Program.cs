using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // No se puede obtener la instancia directamente por que el constructor es privado
            // CSingleton single = new CSingleton;

            // Obtenemos la instancia a partir de alguien mas, se crea por primera vez
            CSingleton uno = CSingleton.ObtenInstancia();

            // Hacemos algo con la instancia
            uno.PonerDatos("Ana", 27);
            uno.AlgunProceso();
            Console.WriteLine(uno);
            Console.WriteLine("-------");

            // Obtenemos la instancia
            CSingleton dos = CSingleton.ObtenInstancia();

            // Comprobamos que es la misma instancia
            // Si lo es, tendra el mismo estado
            Console.WriteLine(dos);

        }
    }
}
