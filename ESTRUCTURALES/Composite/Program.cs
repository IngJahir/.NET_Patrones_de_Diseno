﻿using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponente<string> arbol = new Compuesto<string>("root");
            IComponente<string> trabajo = arbol;

            string opcion = "";
            string dato = "";

            while (opcion!="6")
            {
                Console.WriteLine("Estoy en {0}",trabajo.Nombre);
                Console.WriteLine("1-Adicionar Compuesto 2-Adicionar Componente 3-Borrar 4-Buscar 5-Mostrar 6-Salir");
                opcion = Console.ReadLine();
                Console.WriteLine("-----------");

                // Adicionar compuesto
                if (opcion == "1") 
                {
                    Console.WriteLine("Dame el nombre del compuesto");
                    dato = Console.ReadLine();

                    IComponente<string> c = new Compuesto<string>(dato);
                    trabajo.Adicionar(c);
                    trabajo = c;
                }

                // Adicionar componente
                if (opcion == "2") 
                {
                    Console.WriteLine("Dame el nombre del componente: ");
                    dato = Console.ReadLine();
                    trabajo.Adicionar(new Componente<string>(dato));
                }

                // Borrar
                if (opcion == "3") 
                {
                    Console.WriteLine("Dame el elemento a borrar: ");
                    dato = Console.ReadLine();
                    trabajo = trabajo.Borrar(dato);
                }

                if (opcion == "4") 
                {
                    // La busqueda se hace desde la raiz del arbol
                    Console.WriteLine("Dame el elemento a encontrar: ");
                    dato = Console.ReadLine();
                    trabajo = arbol.Buscar(dato);                    
                }

                if (opcion == "5") 
                {
                    // Se muestra todo el arbol
                    Console.WriteLine(arbol.Mostrar(0));
                }

            }
        }
    }
}
