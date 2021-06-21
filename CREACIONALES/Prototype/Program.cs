using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args) 
        {
            // Creacion del administrador
            CAdminPrototipos admin = new CAdminPrototipos();

            // ********
            // PERSONA
            // ********

            // Obtencion de instancias
            CPersona uno = (CPersona)admin.ObtenPrototipo("Persona");
            CPersona dos = (CPersona)admin.ObtenPrototipo("Persona");

            // Verificamos que tenga los valores del prototipo original
            Console.WriteLine("********");
            Console.WriteLine("PERSONAS");
            Console.WriteLine("********");
            Console.WriteLine(uno);
            Console.WriteLine(dos);
            Console.WriteLine("--------");

            //Modificamos estado
            uno.Nombre = "Ana";
            dos.Nombre = "Carlos";

            // Verificamos que cada uno tenga su estado
            Console.WriteLine(uno);
            Console.WriteLine(dos);
            Console.WriteLine("");
            
            // *****
            // AUTO
            // *****

            // Creamos una instancia
            CAuto auto = new CAuto("Nissan", 250000);

            // Lo colocamos como prototipo
            admin.AdicionaPrototipo("Auto",auto);

            CAuto auto2 = (CAuto)admin.ObtenPrototipo("Auto");

            // Cambiamos de estado
            auto2.Modelo = "Honda";

            // Verficamos que cada uno tenga su estado
            Console.WriteLine("*****");
            Console.WriteLine("AUTOS");
            Console.WriteLine("*****");
            Console.WriteLine(auto);
            Console.WriteLine(auto2);
            Console.WriteLine("");

            // ******
            // VALOR
            // ******

            // Obtenemos una instancia de valor
            CValores val = (CValores)admin.ObtenPrototipo("Valores");

            Console.WriteLine("*******");
            Console.WriteLine("VALORES");
            Console.WriteLine("******");
            Console.WriteLine(val);            
        }
    }
}
