using System;
using System.Collections.Generic;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            // Creacion de listas (Unshare state)
            // ----------------------------------
            List<int> Americana = new List<int>();
            List<int> Italiana = new List<int>();
            List<int> Mejicana = new List<int>();

            List<int> Carnes = new List<int>();
            List<int> Sopas = new List<int>();
            List<int> Ensaladas = new List<int>();

            List<int> Rapida = new List<int>();

            CFlyweightFactory flywf = new CFlyweightFactory();

            i = flywf.Adiciona("Hamburgesa");
            Americana.Add(i);
            Carnes.Add(i);
            Rapida.Add(i);

            i = flywf.Adiciona("Wisconsin chesse");
            Americana.Add(i);
            Ensaladas.Add(i);

            i = flywf.Adiciona("Minestrone");
            Italiana.Add(i);
            Sopas.Add(i);

            i = flywf.Adiciona("Antipasto");
            Italiana.Add(i);
            Ensaladas.Add(i);

            i = flywf.Adiciona("Tacos al pastor");
            Mejicana.Add(i);
            Carnes.Add(i);
            Rapida.Add(i);

            i = flywf.Adiciona("Coditos");
            Mejicana.Add(i);
            Sopas.Add(i);

            i = flywf.Adiciona("Nopales");
            Mejicana.Add(i);
            Ensaladas.Add(i);

            i = flywf.Adiciona("Pizza");
            Italiana.Add(i);
            Rapida.Add(i);

            // -------------
            // Comida rapida
            // -------------
            Console.WriteLine("-------------");
            Console.WriteLine("COMIDA RAPIDA");
            Console.WriteLine("-------------");
            foreach (int n in Rapida)
            {
                CReceta receta = (CReceta)flywf[n];

                // Estado extrinseco: Estado que no se encuentra de forma natural dentro del objeto 
                // sino que obtiene por un calculo
                receta.CalculaCosto();

                // Estado intrinseco: En este caso "nombre" es el estado intrinseco, es decir el estado
                // que se esta compartiendo entre todos los objetos que tenemos 
                receta.Mostrar();
            }

            // ----------------
            // Comida Americana
            // ----------------
            Console.WriteLine("----------------");
            Console.WriteLine("COMIDA AMERICANA");
            Console.WriteLine("----------------");
            foreach (int n in Americana)
            {
                CReceta receta = (CReceta)flywf[n];
                receta.Mostrar();
            }
            
            // ---------------------------------
            // Intenta adicionar un ya existente
            // ---------------------------------
            Console.WriteLine("-------");
            Console.WriteLine("ADICION");
            Console.WriteLine("-------");
            i = flywf.Adiciona("Pizza");

            // ---------
            // Ensaladas
            // ---------
            Console.WriteLine("---------");
            Console.WriteLine("ENSALADAS");
            Console.WriteLine("---------");
            foreach (int n in Ensaladas)
            {
                CReceta receta = (CReceta)flywf[n];
                receta.CalculaCosto();
                receta.Mostrar();
            }

            // ---------------------------
            // Mostramos todas las recetas
            // ---------------------------
            Console.WriteLine("-----------------");
            Console.WriteLine("TODAS LAS RECETAS");
            Console.WriteLine("-----------------");
            int m = 0;
            for (m = 0; m < flywf.Conteo; m++)
            {
                CReceta receta = (CReceta)flywf[m];
                receta.Mostrar();
            }
        }
    }
}
